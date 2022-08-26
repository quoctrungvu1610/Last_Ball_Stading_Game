using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed = 0.5f;
    private Rigidbody enemyRb;
    private GameObject player;
    void Start()
    {
        enemyRb = gameObject.GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce( lookDirection * enemySpeed);
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
