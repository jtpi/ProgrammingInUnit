using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //public GameObject player;
    public GameObject Camera;
    public GameObject cam1;
    public GameObject cam2;
    //private Vector3 offset = new Vector3(0, 5, -10);
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1")) {
            Camera.SetActive(true);
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        if (Input.GetKey("2"))
        {
            Camera.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        //transform.position = player.transform.position + offset;


    }
}
