using UnityEngine;

public class FlyUpandDown : MonoBehaviour
{
    public Transform startValue;
    public Transform endValue;
    public float T;
    public AnimationCurve flyCurve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Peer from Kit's class helped with this code, so credit to both of them

        //Time now counts the second instead of frames, makes it easier to manage
        T += Time.deltaTime;
        if (T > 2)
        {
            //resets the time all the way down to 0
            T = 0;
        }

        transform.position = Vector2.Lerp(startValue.position, endValue.position, flyCurve.Evaluate(T));
      
    }
}
