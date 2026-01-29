using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerMouseFollow : MonoBehaviour
{
    //public camera variable so that the mouse poisiton function is actually on screen when paying the demo
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        //Similar to code used in week 3, only this time the mouse will follow the x-axis instead of the z-axis
        //Ima still credit Kelly for the basis of this code

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);

        //Made the y position very specific so that the controller keeps its controller shape in the demo screen
        worldMousePosition.y = -2.9f;

        //Left the z-axis position 0 so that you can actually see the game object in motion
        worldMousePosition.z = 0;

        //Made it so that the mouse position affects the position in the transform component of the game object

        transform.position = worldMousePosition;

    }
}
