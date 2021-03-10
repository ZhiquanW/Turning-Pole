using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject platformPrefab;
    public float helixProb;
    public static GameManager Instance;

    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start() {
        GameObject platform = GameObject.Instantiate(platformPrefab);
        platform.GetComponent<Platform>().EnableHelix(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
