using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFloater : MonoBehaviour {

    //occilate coin y position

    void Start ()
    {

    }
	
	void Update () {

        transform.position = new Vector3(transform.position.x, 3 + Mathf.Sin (Time.time*2), transform.position.z);

        transform.Rotate(Vector3.up * (Time.deltaTime*100));

      

    }
}
