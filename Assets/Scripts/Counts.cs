using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counts : MonoBehaviour
{

    int count;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CountNumber();
        scoreText.text = count.ToString();
    }
    void CountNumber()
    {
        count = GameObject.FindGameObjectsWithTag("Player").Length;
    }
}
