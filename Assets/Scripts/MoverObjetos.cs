using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    public bool modoMover = false;  // Variable que controla si el modo de mover está activado o no
    private GameObject objetoSeleccionado = null;  // El objeto actualmente seleccionado para mover
    private Vector3 posicionOriginal;  // Guardamos la posición original del objeto antes de moverlo
    private bool siguiendoCursor = false;  // Controla si el objeto sigue al cursor o no

    void Update()
    {
        // Si el modoMover está activo y hay un objeto seleccionado, se puede mover
        if (modoMover && objetoSeleccionado != null && siguiendoCursor)
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
        }
    }

    // Función que mueve el objeto seleccionado con el cursor
    private void MoverObjetoConCursor()
    {
        // Desactivamos el objeto para que el raycast lo atraviese
        objetoSeleccionado.SetActive(false);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Mueve el objeto a la posición donde golpea el rayo
            objetoSeleccionado.transform.position = hit.point;
        }

        // Reactivamos el objeto para que se vea en la nueva posición
        objetoSeleccionado.SetActive(true);
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
                objetoSeleccionado = hit.collider.gameObject;  // Selecciona el objeto cuyo nombre contiene "(Clone)"
                posicionOriginal = objetoSeleccionado.transform.position;  // Guardamos la posición original
                siguiendoCursor = true;  // El objeto comienza a seguir el cursor
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
            siguiendoCursor = false;  // El objeto deja de seguir el cursor
        }
    }

    // Esta función será llamada desde el botón en Unity para activar/desactivar el modoMover
    public void ToggleModoMover()
    {
        modoMover = !modoMover;  // Alterna el valor de modoMover (activado/desactivado)
    }
}
