using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public ProjectileManager pM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        print("Triggered");
        if (other.CompareTag("Target"))
        {
            print("Hit");
            pM.hitCounter -= 1f;
        }
    }
}
