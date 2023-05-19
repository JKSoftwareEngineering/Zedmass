using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    private Rigidbody rig;
    private float zombieSpeed;
    private float turnSpeed = 1f;
    private int zombieHealth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        zombieSpeed = GetComponent<ZombieStats>().speed;
        zombieHealth = gameObject.GetComponent<ZombieStats>().health;
    }

    // Update is called once per frame
    void Update()
    {
        zombieSpeed = GetComponent<ZombieStats>().speed;
        zombieHealth = gameObject.GetComponent<ZombieStats>().health;
        Vector3 playerWithoutY = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        if (zombieHealth > 0)
        {
            Vector3 targetDirection = playerWithoutY - transform.position;
            float singleStep = turnSpeed * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            rig.drag = 0;
            transform.Translate(Vector3.forward * zombieSpeed * Time.deltaTime);
            rig.velocity = (transform.forward);
        }
        if (Vector3.Distance(transform.position, playerWithoutY) > 50f)
        {
            Destroy(gameObject);
        }
    }
}
