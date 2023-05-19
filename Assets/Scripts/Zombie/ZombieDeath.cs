using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    private Animator anim;
    private int zombieHealth;
    private float timer;
    private float timerMax;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        zombieHealth = gameObject.GetComponent<ZombieStats>().health;
        timer = 0f;
        timerMax = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        zombieHealth = gameObject.GetComponent<ZombieStats>().health;
        if (zombieHealth <= 0)
        {
            anim.SetTrigger("Death");
            timer += Time.deltaTime;
            if (timer >= timerMax)
            {
                GameObject.Find("Player").GetComponent<PlayerStats>().score += 200;
                Destroy(gameObject);
            }
        }
    }
}
