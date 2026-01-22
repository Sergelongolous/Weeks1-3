using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Teleporter : MonoBehaviour
{
    public Transform startValue;
    public Transform endValue;
    public Vector3 output;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Time.deltaTime * output;
        output = endValue.position;
        transform.position = output;

        if (endValue != true)
        {
            startValue.position = output;
        }

    }

}
