using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour {
    public float bounceSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.collider.CompareTag("Piece")) {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0,bounceSpeed,0);
        }
    }
}
