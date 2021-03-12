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
            helix.transform.SetParent(this.transform);
            if (Random.Range(0, 1) < GameManager.Instance.helixProb - 1.0f/Mathf.Exp(level+1)) {
                helix.GetComponent<Renderer>().enabled = true;
                helix.GetComponent<MeshCollider>().isTrigger = false;
            }
            
        }
        
        // make sure at least 1 empty piece
        int emptyIndex = Random.Range(0, helixs.Count);
        helixs[emptyIndex].GetComponent<Renderer>().enabled  = false;
        helixs[emptyIndex].GetComponent<MeshCollider>().isTrigger = true;
    }

    public void BreakPlatform() {
        foreach (var helix in helixs) {
            helix.GetComponent<Rigidbody>().isKinematic = false;
            print(helix.transform.position);
            helix.GetComponent<Rigidbody>().velocity=  Random.insideUnitCircle.normalized*(helix.transform.position - GameManager.Instance.Ball.transform.position)*GameManager.Instance.platformBreakSpeed;
        }
    }
    


}
