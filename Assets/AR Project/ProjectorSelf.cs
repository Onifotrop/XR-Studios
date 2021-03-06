using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectorSelf : MonoBehaviour
{
    public Vector3 playerPos;
    //public Transform selfPos;
    public GameObject arCam;
    public float dist;
    public Vector3 targetPos;
    public int speed;
    public ProjectileManager pM;
    public float lifeTimer = 5f;
    void Start()
    {
        arCam = GameObject.Find("AR Camera");
        playerPos = arCam.transform.position;
        targetPos = playerPos;
        speed = (int)Random.Range(2f, 5f);
        pM = GameObject.Find("Spawner").GetComponent<ProjectileManager>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(targetPos, transform.position);
        transform.LookAt(targetPos);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    
}
