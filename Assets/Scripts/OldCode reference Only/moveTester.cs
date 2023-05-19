using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class moveTester : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    //private float timer;
    //private float timerMax;
    //private float hitTimer;
    //private float hitTimerMax;
    public GameObject player;
    public float speed = 1.0f;
    private Animator anim;
    Rigidbody rig;
    //GameObject hit;
    //GameObject gameManager;
    void Start()
    {
     //   timer = 0f;
     //   timerMax = 2f;
     //   hitTimer = 0f;
     //   hitTimerMax = 2f;
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        //gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerWithoutY = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        if (!(health == 0))
        {
            Vector3 targetDirection = playerWithoutY - transform.position;
            float singleStep = speed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            rig.drag = 0;
            transform.Translate(Vector3.forward * .001f);
            rig.velocity = (transform.forward);
        }
        //if(Vector3.Distance(transform.position, playerWithoutY) < 2f)
        //{
        //    anim.SetTrigger("Attack");
        //    if (health > 0)
        //    {
                //gameManager.GetComponent<GameManager>().hit.SetActive(true);
                //gameManager.GetComponent<GameManager>().healthVal -= 10;
        //    }
        //}
        //if(gameManager.GetComponent<GameManager>().hit.activeSelf)
        //{
        //    hitTimer += Time.deltaTime;
        //    if (hitTimer >= hitTimerMax)
        //    {
        //        gameManager.GetComponent<GameManager>().hit.SetActive(false);
        //    }
        //}
        /*
        if (health == 0)
        {
            anim.SetTrigger("Death");
            timer += Time.deltaTime;
            if (timer >= timerMax)
            {
                Destroy(gameObject);
            }
        }
        */
    }
    
}
