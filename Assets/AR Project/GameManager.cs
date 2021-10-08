using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProjectileManager pM;
    public GameObject spawnerTwo;
    public GameObject spawnerThree;
    void Start()
    {
        pM = GameObject.Find("Spawner").GetComponent<ProjectileManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pM.hitCounter >= 10f)
        {
            spawnerTwo.SetActive(true);
        }
        if (pM.hitCounter >= 20f)
        {
            spawnerThree.SetActive(true);
        }
    }
}
