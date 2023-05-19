using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    GameObject[] pauseEnemys;
    GameObject[] pauseSpawners;
    public GameObject player;
    public bool paused = false;
    public bool callOnce = true;
    public Camera pauseCam;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            paused = !paused;
            callOnce = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (callOnce)
        {
            if (paused)
            {
                pauseCam.gameObject.SetActive(true);
                player.SetActive(false);
                //GameObject.Find("PowerUpSpawner").GetComponent<SpawnPowerUp>().spawning = false;
                pauseEnemys = GameObject.FindGameObjectsWithTag("Zombie");// find all of this thing at time of press
                foreach (GameObject n in pauseEnemys)//same as for( : );
                {
                    n.SetActive(false);
                }
                pauseSpawners = GameObject.FindGameObjectsWithTag("Spawner");// find all of this thing at time of press
                foreach (GameObject n in pauseSpawners)//same as for( : );
                {
                    n.SetActive(false);
                }
            }
            if (!paused)
            {
                pauseCam.gameObject.SetActive(false);
                player.SetActive(true);
                //GameObject.Find("PowerUpSpawner").GetComponent<SpawnPowerUp>().spawning = true;
                if (pauseEnemys != null)
                {
                    foreach (GameObject n in pauseEnemys)
                    {
                        if (n != null)
                        {
                            n.SetActive(true);
                        }
                    }
                }
                //check at every step for null otherwise you get errors
                if (pauseSpawners != null)
                {
                    foreach (GameObject n in pauseSpawners)
                    {
                        if (n != null)
                        {
                            n.SetActive(true);
                        }
                    }
                }
            }
            callOnce = false;// could also be a seperate method
        }
    }
    public void pauseButton()
    {
        paused = !paused;
        callOnce = true;
    }
}
