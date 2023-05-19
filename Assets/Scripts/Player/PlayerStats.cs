using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int hunger;
    public float speed;
    public int ammo;
    public int score;
    public int scoreIn;//might want this later load last score
    public Slider playerHpDisplay;
    public Slider playerHungerDisplay;
    public TextMeshProUGUI ammoDisplay;
    public TextMeshProUGUI ScoreDisplay;
    private Rigidbody rig;
    private AudioSource pickUp;

    void Start()
    {
        health = 100;
        hunger = 100;
        ammo = 5;
        speed = 3f;
        score = 0;
        rig = GetComponent<Rigidbody>();
        pickUp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHpDisplay.value = health;
        playerHungerDisplay.value = hunger;
        ammoDisplay.text = "" + ammo;
        ScoreDisplay.text = "" + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            pickUp.Play();
            Destroy(collision.gameObject);
            ammo += 20;
            score += 50;
        }
        if (collision.gameObject.CompareTag("Health"))
        {
            if (health < 100)
            {
                pickUp.Play();
                Destroy(collision.gameObject);
                health += 20;
                score += 50;
                if (health > 100)
                {
                    health = 100;
                }
            }
        }
        if (collision.gameObject.CompareTag("Hunger"))
        {
            if (hunger < 100)
            {
                pickUp.Play();
                Destroy(collision.gameObject);
                hunger += 50;
                score += 50;
                if (hunger > 100)
                {
                    hunger = 100;
                }
            }
        }
    }
}
