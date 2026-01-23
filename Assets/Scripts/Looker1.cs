using UnityEngine;

public class Looker1 : MonoBehaviour
{
    public float rotationSpeed;
    public float zMax;
    public float zMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If we wanted to move the object, we would use transform.position
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;

        //zMax = 10 * Time.deltaTime;
       // zMin = -10 * Time.deltaTime;

        if (transform.eulerAngles.z > zMax)
        {
            rotationSpeed += -1;
        }

        if (transform.eulerAngles.z < zMin)
        {
            rotationSpeed += -1;
        }

       // Debug.Log(transform.eulerAngles);

    }
}
