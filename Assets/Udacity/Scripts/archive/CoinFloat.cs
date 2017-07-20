using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFloat : MonoBehaviour {

    public GameObject ThingToFloat;
    public float speed;

	// Use this for initialization
	void Start () {

        ThingToFloat.transform.Translate(new Vector3(0, speed * -Time.deltaTime,0));

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
