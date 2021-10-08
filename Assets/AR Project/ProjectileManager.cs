using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ProjectileManager : MonoBehaviour
{
    public float spawnCounter;
    public float timer;
    public GameObject projectilePrefab;
    public Vector3 spawnPos;
    public float hitCounter;
    public Text scoreCounter;
    void Start()
    {
        hitCounter = 0f;
        timer = Random.Range(0f, 3f);

    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnCounter)
        {
            spawnPos = Random.onUnitSphere * 20f;
            Instantiate(projectilePrefab, spawnPos, Quaternion.identity);
            timer = Random.Range(0f, 3f);
        }

        scoreCounter.text = "Score: " + hitCounter;
    }

}
