using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    private Animator anim;
    public GameObject player;
    private float timer;
    private float timerMax;
    private bool hitTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        timer = 0f;
        timerMax = 3f;
    }

// Update is called once per frame
void Update()
    {
        Vector3 playerWithoutY = new Vector3(player.transform.position.x, 1, player.transform.position.z);
        if (Vector3.Distance(transform.position, playerWithoutY) < 3f)
        {
            anim.SetTrigger("Attack");
            if (hitTimer)
            {
                if (Vector3.Distance(transform.position, playerWithoutY) < 2f)
                {
                    player.GetComponent<PlayerStats>().health -= 10;
                    hitTimer = false;
                }
            }
        }
        if(!hitTimer)
        {
            timer += Time.deltaTime;
            if (timer >= timerMax)
            {
                hitTimer = true;
                timer = 0f;
            }
        }
    }
}
