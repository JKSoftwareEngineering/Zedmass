using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    private float timer;
    private float timerMax;
    Rigidbody rig;
    //GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        timerMax = 2f;
        rig = GetComponent<Rigidbody>();
        //gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*.5f);
        rig.velocity = (transform.forward);
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Zombie"))
        {
            collision.gameObject.GetComponent<ZombieStats>().changeHealth(20);
            Destroy(gameObject);
        }
    }
}
