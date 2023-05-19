using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 20;
    public float speed = .1f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        changeHealth(0);
    }

    public int changeHealth(int val)
    {
        return health -= val;
    }
}
