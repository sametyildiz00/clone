using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private float enemySpeed = 8.5f;
    private Rigidbody rb;


    public float timer;
    private float delay;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        delay += Time.deltaTime;   
        if(delay > timer)
        {
            EnemyMove();
        }
        
    }
    void EnemyMove()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, player.position, enemySpeed * Time.fixedDeltaTime);
        rb.MovePosition(pos);
        transform.LookAt(player);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}

}
