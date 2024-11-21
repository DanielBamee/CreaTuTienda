using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    public bool modoMover = false;  // Variable que controla si el modo de mover está activado o no
    private GameObject objetoSeleccionado = null;  // El objeto actualmente seleccionado para mover
    private Vector3 posicionOriginal;  // Guardamos la posición original del objeto antes de moverlo
    private bool siguiendoCursor = false;  // Controla si el objeto sigue al cursor o no
    public GameObject circulito;

    void Update()
    {
        //LeanTween.scaleX(circulito, 1, 1f * Time.deltaTime).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() =>
        //{
        //    LeanTween.scaleX(circulito, 2, 1f * Time.deltaTime).setEase(LeanTweenType.easeInOutQuad);
        //});

        //LeanTween.scaleZ(circulito, 1, 1f * Time.deltaTime).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() =>
        //{
        //    LeanTween.scaleZ(circulito, 2, 1f * Time.deltaTime).setEase(LeanTweenType.easeInOutQuad);
        //});
        

        if (modoMover == true)
        {
            // Si el modoMover está activo y hay un objeto seleccionado, se puede mover
            if (objetoSeleccionado != null && siguiendoCursor)
            {
                MoverObjetoConCursor();  // Llama a la función para mover el objeto con el cursor
            }

            // Al hacer clic, seleccionamos un objeto si no hay ninguno seleccionado
            if (Input.GetMouseButtonDown(0))
            {
                SeleccionarObjetoConRaycast();  // Llama a la función para seleccionar un objeto
            }

            // Cuando se suelta el clic, se coloca el objeto en la nueva posición
            if (Input.GetMouseButtonUp(0) && objetoSeleccionado != null)
            {
                ColocarObjetoConRaycast();  // Llama a la función para colocar el objeto
                circulito.SetActive(false);
            }
        }   
    }
    // Función que mueve el objeto seleccionado con el cursor
    private void MoverObjetoConCursor()
    {
        // Desactivamos el objeto para que el raycast lo atraviese
        objetoSeleccionado.SetActive(false);
        circulito.SetActive(false);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Mueve el objeto a la posición donde golpea el rayo
            objetoSeleccionado.transform.position = hit.point;
            circulito.transform.position = hit.point;
        }

        // Reactivamos el objeto para que se vea en la nueva posición
        objetoSeleccionado.SetActive(true);
        circulito.SetActive(true);
    }

    // Función que selecciona un objeto si el clic fue sobre un objeto cuyo nombre contenga "(Clone)"
    private void SeleccionarObjetoConRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null && hit.collider.gameObject.name.Contains("(Clone)"))  // Comprobamos si el nombre contiene "(Clone)"
            {
                //circulito.SetActive(true);
                objetoSeleccionado = hit.collider.gameObject;  // Selecciona el objeto cuyo nombre contiene "(Clone)"
                posicionOriginal = objetoSeleccionado.transform.position;  // Guardamos la posición original
                siguiendoCursor = true;  // El objeto comienza a seguir el cursor
                //circulito.transform.parent = objetoSeleccionado.transform;
                //circulito.GetComponentInParent<Transform>();
            }
        }
    }
        
    // Función para colocar el objeto cuando el clic se suelta
    private void ColocarObjetoConRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            objetoSeleccionado.transform.position = hit.point;  // Coloca el objeto en la nueva posición
            circulito.transform.position = hit.point;
            siguiendoCursor = false;  // El objeto deja de seguir el cursor
            //circulito.transform.parent = null;
            objetoSeleccionado = null;
        }
        circulito.SetActive(false);
    }

    // Esta función será llamada desde el botón en Unity para activar/desactivar el modoMover
    public void ToggleModoMover()
    {
        modoMover = !modoMover;  // Alterna el valor de modoMover (activado/desactivado)
        if (modoMover == false)
        {
            //circulito.SetActive(false);
        }
    }
    public void DesactivarModoMover()
    {
        modoMover = false;
    }
}
