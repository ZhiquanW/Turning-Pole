using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject platformPrefab;
    public Transform Ball;
    public float helixProb;
    public Transform platformFamily;
    public static GameManager Instance;
    public int initLevel = 0;
    public int level = 0;
    public int platformInterval = 0;
    public int platformBreakSpeed = 0;
    private void Awake() {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start() {
        InitPlatforms();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InitPlatforms() {
        for (int i = 0; i < initLevel; ++i) {
            CreatePlatform();
            // Debug.Log(i);
            level += 1;

        }
    }
    public void CreatePlatform() {
        var parent = platformFamily.transform;
        GameObject platform = Instantiate(platformPrefab, parent.position-new Vector3(0,platformInterval*level,0), Quaternion.identity,parent);
        platform.GetComponent<Platform>().EnableHelix(level++);
        
    }
}
