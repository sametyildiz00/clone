using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePlayer : MonoBehaviour
{

    public GameObject playerPrefab;
    public int cloneNum;
    public float radius;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Clone(cloneNum, playerPrefab.transform.position, radius);
        }
    }

    void Clone(int cloneNum, Vector3 point, float radius)
    {


        for (int i = 0; i < cloneNum; i++)
        {
            var radians = Mathf.PI * 2 / cloneNum * i;
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);

            var spawnDir = new Vector3(horizontal, 0, vertical);
            var spawnPos = point + spawnDir * radius;

            var clonePL = Instantiate(playerPrefab, spawnPos, Quaternion.identity) as GameObject;

        }


    }


}
