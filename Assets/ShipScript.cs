using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public float speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Rigidbody Ship = GetComponent<Rigidbody>(); // обращение к объекту

        Ship.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed;
    }
}
