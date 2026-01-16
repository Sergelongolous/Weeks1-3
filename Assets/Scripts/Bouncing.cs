using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public Vector3 speed = new Vector3(2f, 2f, 0);
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
        moverXPos.x += speed.x * Time.deltaTime;
        transform.position = moverXPos;

        Vector3 moverYPos = transform.position;
        moverYPos.y += speed.y * Time.deltaTime;
        transform.position = moverYPos;

        //set xMax and yMax to wherever is too far to the right for the player to see
        Vector3 screenTransformPosition = gameCamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;
        yMax = Screen.height;

        //set xMin and yMin to wherever is too far to the left for the player to see
        xMin = 0;
        yMin = 0;

        if (xMax < screenTransformPosition.x)
        {
            speed.x *= -1;
        }


        if (xMin > screenTransformPosition.x)
        {
            speed.x *= -1;
        }

        if(yMax < screenTransformPosition.y)
        {
            speed.y *= -1;
        }

        if(yMin > screenTransformPosition.y)
        {
            speed.y *= -1;
        }
    }
    }
