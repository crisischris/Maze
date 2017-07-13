using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoofMaker : MonoBehaviour {

    public GameObject objectToCreate;

	// Use this for initialization
	void Start () {

        Object.Instantiate(objectToCreate, new Vector3(0, 5, 130), Quaternion.Euler(-90,0,0));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
