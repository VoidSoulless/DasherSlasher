using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashDash : MonoBehaviour
{
    bool mouseDown = false;
    Vector2 mouseDownPosition;
    Vector2 mouseUpPosition;
    Rigidbody rigidBodyCharacter;
    private void OnMouseDown()
    {

        mouseDown = true;
       
    }

    private void OnMouseUp()
    {
        mouseDown = false;
    }

    private void Update()
    {
        if ( mouseDown == true)
        {
            Debug.Log("está presionado");

            mouseDownPosition = (Input.mousePosition);
        }
        else
        {
            mouseUpPosition = (Input.mousePosition);
            Debug.Log("El mouse no está presionado");
        }
    }

    private void Dashear()
    {

    }
}
