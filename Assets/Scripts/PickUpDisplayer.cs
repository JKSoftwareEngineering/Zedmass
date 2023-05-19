using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLight;
    private float timer;
    private float timerMax;
    private bool high;
    private bool low;
    void Start()
    {
        timer = 0f;
        timerMax = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
        timer += Time.deltaTime;
        if(timer >= timerMax && myLight.intensity < 2f)
        {
            myLight.intensity = 2f;
            timer = 0;
        }
        if (timer >= timerMax && myLight.intensity > 1f)
        {
            myLight.intensity = 1f;
            timer = 0;
        }
    }
}
