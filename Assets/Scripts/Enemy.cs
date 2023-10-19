using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 40.0f;
    private Rigidbody enemyRB;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(lookDirection * speed);
    }
}
