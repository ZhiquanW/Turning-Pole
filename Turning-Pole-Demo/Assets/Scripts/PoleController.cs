using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PoleController : MonoBehaviour
{
    public float angularSpeed;

    public List<Transform> pieces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        int rotateDir = 0;
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rotateDir = 1;
        }else if (Input.GetKey(KeyCode.RightArrow)) {
            rotateDir = -1;
        }
        this.transform.Rotate(Vector3.up,rotateDir * angularSpeed*Time.deltaTime);

    }
}
