using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    public List<Transform> helixs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableHelix(int level) {
        // int helixNum = (int) (8 * GameManager.Instance.helixProb);
        foreach (var helix in helixs) {
            if (Random.Range(0, 1) < GameManager.Instance.helixProb) {
                helix.GetComponent<Renderer>().enabled = true;
                helix.GetComponent<MeshCollider>().isTrigger = false;
            }
            
        }
    }
}
