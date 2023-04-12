using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private float speed = 20;
    private float turnSpeed =45;
    private float horizontalInput;
    private float forwardInput;
    public  string inputID;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"+inputID);
        forwardInput = Input.GetAxis("Vertical"+inputID);
        //Vamos mover o carro para a frente
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput*speed);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
