using UnityEngine;

public class MoverObjetos : MonoBehaviour
{
    public bool modoMover = false;  // Variable que controla si el modo de mover est� activado o no
    private GameObject objetoSeleccionado = null;  // El objeto actualmente seleccionado para mover
    private Vector3 posicionOriginal;  // Guardamos la posici�n original del objeto antes de moverlo
    private bool siguiendoCursor = false;  // Controla si el objeto sigue al cursor o no

    void Update()
    {
        // Si el modoMover est� activo y hay un objeto seleccionado, se puede mover
        if (modoMover && objetoSeleccionado != null && siguiendoCursor)
        {
            MoverObjetoConCursor();  // Llama a la funci�n para mover el objeto con el cursor
        }

        // Al hacer clic, seleccionamos un objeto si no hay ninguno seleccionado
        if (Input.GetMouseButtonDown(0))
        {
            SeleccionarObjetoConRaycast();  // Llama a la funci�n para seleccionar un objeto
        }

        // Cuando se suelta el clic, se coloca el objeto en la nueva posici�n
        if (Input.GetMouseButtonUp(0) && objetoSeleccionado != null)
        {
            ColocarObjetoConRaycast();  // Llama a la funci�n para colocar el objeto
        }
    }

    // Funci�n que mueve el objeto seleccionado con el cursor
    private void MoverObjetoConCursor()
    {
        // Desactivamos el objeto para que el raycast lo atraviese
        objetoSeleccionado.SetActive(false);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Mueve el objeto a la posici�n donde golpea el rayo
            objetoSeleccionado.transform.position = hit.point;
        }

        // Reactivamos el objeto para que se vea en la nueva posici�n
        objetoSeleccionado.SetActive(true);
    }

    // Funci�n que selecciona un objeto si el clic fue sobre un objeto cuyo nombre contenga "(Clone)"
    private void SeleccionarObjetoConRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null && hit.collider.gameObject.name.Contains("(Clone)"))  // Comprobamos si el nombre contiene "(Clone)"
            {
                objetoSeleccionado = hit.collider.gameObject;  // Selecciona el objeto cuyo nombre contiene "(Clone)"
                posicionOriginal = objetoSeleccionado.transform.position;  // Guardamos la posici�n original
                siguiendoCursor = true;  // El objeto comienza a seguir el cursor
            }
        }
    }

    // Funci�n para colocar el objeto cuando el clic se suelta
    private void ColocarObjetoConRaycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            objetoSeleccionado.transform.position = hit.point;  // Coloca el objeto en la nueva posici�n
            siguiendoCursor = false;  // El objeto deja de seguir el cursor
        }
    }

    // Esta funci�n ser� llamada desde el bot�n en Unity para activar/desactivar el modoMover
    public void ToggleModoMover()
    {
        modoMover = !modoMover;  // Alterna el valor de modoMover (activado/desactivado)
    }
}
