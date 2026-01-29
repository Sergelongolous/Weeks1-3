using UnityEngine;

public class BoltPulsing : MonoBehaviour
{
    //THIS CODE WAS THE ONE USED FOR WEEK 2 OF CLASS, CREDIT TO PROF. KELLY
    //Declaring an AnimationCurve to make the the bolts slowing pulse, along with a duration variable (public) to determine how long it will pulse

    public AnimationCurve pulseCurve;
    public float duration;
    public float output;

    private float progress = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Using Time.deltaTime to make it change over time

        progress += Time.deltaTime / duration;
        output = pulseCurve.Evaluate(progress);

        //The transform variable being changed over time is the scale, making it so that the bolts change size while the AnimationCurve is in motion

        transform.localScale = Vector3.one * output;

        if (progress > 1f)
        {
            progress = 0f;
        }

    }
}
