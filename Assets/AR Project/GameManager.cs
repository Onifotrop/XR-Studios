using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class GameManager : MonoBehaviour
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

        if (Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);

            if (Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                pM.hitCounter += 1;
                Destroy(hit.transform.gameObject);
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
