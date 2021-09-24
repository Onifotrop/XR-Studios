using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARGameManager : MonoBehaviour
{

    [SerializeField] ARRaycastManager rayCastManager;

    List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    [SerializeField] GameObject cubePrefab;

    GameObject spawnedObject;
    
    void Start()
    {
        spawnedObject = null;
    }
    
    void Update()
    {
        
        if(Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        
        //SENDING OUT RAYCAS ON THE POINT AT WHICH WE TAPPED THE SCREEN
        if (rayCastManager.Raycast(touch.position, raycastHits))
        {
            if (touch.phase == TouchPhase.Began)
            {
                spawnedObject = Instantiate(cubePrefab,raycastHits[0].pose.position,Quaternion.identity);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                //HAVE WE SPAWNED THE CUBE?
                if (spawnedObject != null)
                {
                    //IF YES, MOVE THE CUBE TO NEW LOCATION

                    spawnedObject.transform.position = raycastHits[0].pose.position;
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                
            }
        }

    }
}
