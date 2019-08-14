using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    public int MinRange = 0;
    public int MaxRange = 1;
    public float MinSpawnTime = 1.0f;
    public float MaxSpawnTime = 10.0f;

	// Use this for initialization
	void Start () {
        Invoke("WordSpawn", Random.Range(MinSpawnTime, MaxSpawnTime));
	}
	
    void WordSpawn () {
        int WordRange = Random.Range(MinRange, MaxRange);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
