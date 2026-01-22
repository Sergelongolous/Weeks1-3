using UnityEngine;
using UnityEngine.InputSystem;

public class DuckFollow : MonoBehaviour
{
    public Camera gameCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //worldMousePosition.z = 0;
        //transform.position = worldMousePosition;
        //worldMousePosition.x = 0;

        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        Vector3 worldMousePosition.x = gameCamera.WorldToScreenPoint(worldMousePosition):
        worldMousePosition.z = 0;
        transform.position = worldMousePosition;
        
        //how the hell do i make the sprite only follow the mouse on the x.axis? This was muc easier last term ;-;
    }
}
