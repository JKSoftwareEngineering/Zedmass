using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHungerControle : MonoBehaviour
{
    private float timer;
    private float timerMax;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        timerMax = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            if (GetComponent<PlayerStats>().hunger > 0)
            {
                GetComponent<PlayerStats>().hunger -= 1;
            }
            if (GetComponent<PlayerStats>().health > 0 && GetComponent<PlayerStats>().hunger <= 0)
            {
                GetComponent<PlayerStats>().health -= 1;
            }
            timer = 0;
        }
    }
}
