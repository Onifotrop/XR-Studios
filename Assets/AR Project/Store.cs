using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class Store : MonoBehaviour
{
    ARRaycastManager rayCastManager;
    public ProjectileManager pM;
    public GameObject spawnerTwo;
    public GameObject spawnerThree;
    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();
    public Camera arCam;
    private RaycastHit hit;
    private Ray ray;
    void Start()
    {
        pM = GameObject.Find("Spawner").GetComponent<ProjectileManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);
        if (Physics.Raycast(ray, Mathf.Infinity))
        {
            Debug.Log("Hit something");
        }
        if(Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);

        if (rayCastManager.Raycast(touch.position, raycastHits))
        {
            if (touch.phase == TouchPhase.Began)
            {
                
                Ray ray = arCam.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.CompareTag("Target"))
                    {
                        Destroy(hit.collider.gameObject);
                        pM.hitCounter += 1;
                    }
                    
                }
            }
        }
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