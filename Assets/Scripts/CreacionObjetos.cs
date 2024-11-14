using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionObjetos : MonoBehaviour
{
    [SerializeField]
    GameObject prefabObject1;
    GameObject object1;
    bool objectB1 = false;
    [SerializeField]
    GameObject prefabObject2;
    GameObject object2;
    bool objectB2 = false;
    [SerializeField]
    GameObject prefabObject3;
    GameObject object3;
    bool objectB3 = false;
    [SerializeField]
    GameObject prefabObject4;
    GameObject object4;
    bool objectB4 = false;
    [SerializeField]
    GameObject prefabObject5;
    GameObject object5;
    bool objectB5 = false;
    [SerializeField]
    GameObject prefabObject6;
    GameObject object6;
    bool objectB6 = false;
    [SerializeField]
    GameObject prefabObject7;
    GameObject object7;
    bool objectB7 = false;
    [SerializeField]
    GameObject prefabObject8;
    GameObject object8;
    bool objectB8 = false;
    [SerializeField]
    GameObject prefabObject9;
    GameObject object9;
    bool objectB9 = false;
    [SerializeField]
    GameObject prefabObject10;
    GameObject object10;
    bool objectB10 = false;
    [SerializeField]
    GameObject prefabObject11;
    GameObject object11;
    bool objectB11 = false;
    [SerializeField]
    GameObject prefabObject12;
    GameObject object12;
    bool objectB12 = false;
    [SerializeField]
    GameObject prefabObject13;
    GameObject object13;
    bool objectB13 = false;
    [SerializeField]
    GameObject prefabObject14;
    GameObject object14;
    bool objectB14 = false;
    [SerializeField]
    GameObject prefabObject15;
    GameObject object15;
    bool objectB15 = false;

    private void Update()
    {
        if (objectB1 == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                 object1.transform.position = hit.point;
            }
            object1.SetActive(true);
        }
        if (objectB2 == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                object2.transform.position = hit.point;
            }
            object2.SetActive(true);
        }
        if (objectB3 == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                object3.transform.position = hit.point;
            }
            object3.SetActive(true);
        }
        if (objectB4 == true)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                object4.transform.position = hit.point;
            }
            object4.SetActive(true);
        }
        if (objectB5 == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                object5.transform.position = hit.point;
            }
            object5.SetActive(true);
        }
        if (objectB6 == true)
        {

        }
        if (objectB7 == true)
        {

        }
        if (objectB8 == true)
        {

        }
        if (objectB9 == true)
        {

        }
        if (objectB10 == true)
        {

        }
        if (objectB11 == true)
        {

        }
        if (objectB12 == true)
        {

        }
        if (objectB13 == true)
        {

        }
        if (objectB14 == true)
        {

        }
        if (objectB15 == true)
        {

        }
    }
    public void CrearObjeto1()
    {
        object1 = Instantiate(prefabObject1, Vector3.zero, Quaternion.identity);
        objectB1 = true;
    }
    public void CrearObjeto2()
    {
        object2 = Instantiate(prefabObject2, Vector3.zero, Quaternion.identity);
        objectB2 = true;
    }
    public void CrearObjeto3()
    {
        object3 = Instantiate(prefabObject3, Vector3.zero, Quaternion.identity);
        objectB3 = true;
    }
    public void CrearObjeto4()
    {
        object4 = Instantiate(prefabObject4, Vector3.zero, Quaternion.identity);
        objectB4 = true;
    }
    public void CrearObjeto5()
    {
        object5 = Instantiate(prefabObject5, Vector3.zero, Quaternion.identity);
        objectB5 = true;
    }
    public void CrearObjeto6()
    {
        object6 = Instantiate(prefabObject6, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object6.transform.position = hit.point;
        }
        object6.SetActive(true);
    }
    public void CrearObjeto7()
    {
        object7 = Instantiate(prefabObject7, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object7.transform.position = hit.point;
        }
        object7.SetActive(true);
    }
    public void CrearObjeto8()
    {
        object8 = Instantiate(prefabObject8, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object8.transform.position = hit.point;
        }
        object8.SetActive(true);
    }
    public void CrearObjeto9()
    {
        object9 = Instantiate(prefabObject9, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object9.transform.position = hit.point;
        }
        object9.SetActive(true);
    }
    public void CrearObjeto10()
    {
        object10 = Instantiate(prefabObject10, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object10.transform.position = hit.point;
        }
        object10.SetActive(true);
    }
    public void CrearObjeto11()
    {
        object11 = Instantiate(prefabObject11, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object11.transform.position = hit.point;
        }
        object11.SetActive(true);
    }
    public void CrearObjeto12()
    {
        object12 = Instantiate(prefabObject12, Vector3.zero, Quaternion.identity); Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object12.transform.position = hit.point;
        }
        object12.SetActive(true);
    }
    public void CrearObjeto13()
    {
        object13 = Instantiate(prefabObject13, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object13.transform.position = hit.point;
        }
        object13.SetActive(true);
    }
    public void CrearObjeto14()
    {
        object14 = Instantiate(prefabObject14, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object14.transform.position = hit.point;
        }
        object14.SetActive(true);
    }
    public void CrearObjeto15()
    {
        object15 = Instantiate(prefabObject15, Vector3.zero, Quaternion.identity);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            object15.transform.position = hit.point;
        }
        object15.SetActive(true);
    }
}
