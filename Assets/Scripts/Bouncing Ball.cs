using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float speed = 10f;
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;
    public Camera gameCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x += speed * Time.deltaTime;
        transform.position = moverXPos;

        Vector3 moverYPos = transform.position;
        moverYPos.y += speed * Time.deltaTime;
        transform.position = moverYPos;

        //set xMax to wherever is too far to the right for the player to see
        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;
        yMax = Screen.height;

        //set xMin to wherever is too far to the left for the player to see
        xMin = 0;
        yMin = 0;

        if (xMax < screenTransformPosition.x)
        {
            speed *= -1;
        }


        if (xMin > screenTransformPosition.x)
        {
            speed *= -1;
        }

        if (yMax < screenTransformPosition.y)
        {
            speed *= -1;
        }
        if (yMin > screenTransformPosition.y)
        {
            speed *= -1;
        }
    }
}
