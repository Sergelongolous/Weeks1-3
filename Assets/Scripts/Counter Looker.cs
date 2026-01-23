using UnityEngine;

public class CounterLooker : MonoBehaviour
{
    public float rotationSpeed;
    public Camera gameCamera;
    public Color startingcolor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;
    }
}
