using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject prefab;
    private float timer;
    private float timerMax;
    private float replacementTimer;
    private float replacemantTimerMax;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        timerMax = 7.5f;
        replacementTimer = 0f;
        replacemantTimerMax = 60f;
        //for (int i = 0; i < 20; i++)
        //{
        //    Instantiate(prefab, new Vector3(Random.Range(transform.position.x - 7, transform.position.x + 7), 0.1f, Random.Range(transform.position.z - 7, transform.position.z + 7)), prefab.transform.rotation);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        replacementTimer += Time.deltaTime;
        if(timer >= timerMax)
        {
            Instantiate(prefab, new Vector3(Random.Range(transform.position.x - 7, transform.position.x + 7),0.1f, Random.Range(transform.position.z - 7, transform.position.z + 7)), prefab.transform.rotation);
            timer = 0;
        }
        if(replacementTimer >= replacemantTimerMax)
        {
            replacementTimer = 0;
            timerMax -= .5f;
            if(timerMax < .5f)
            {
                timerMax = .5f;
            }

        }
    }
}
