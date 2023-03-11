using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Transform player;

    private float timebtwshot;
    public float startTimeshots;

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timebtwshot = startTimeshots;
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwshot <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timebtwshot = startTimeshots;
        }
        else
        {
            timebtwshot -= Time.deltaTime;
        }
    }
}
