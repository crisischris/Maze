using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour {

    // this is wrong, these data points need to be in sets. i.e. 8.3.42 , or -8.3.42, or 3.5,3,63



    public GameObject coin;
    float[] posx = { 8, -8, -8, 3.5f, 3, 8 };
    float[] posz = { 42, 42, 47, 63, 103.5f, 108.5f };


    private float xpos;
    private float zpos;

    private float xpos2;
    private float zpos2;



    float selection1;
    float selection2;
    float selection3;

    // Use this for initialization
    void Start() {

        xpos = posx[Random.Range(0, posx.Length - 1)];
        zpos = posz[Random.Range(0, posx.Length - 1)];
       



         GameObject.Instantiate(coin, new Vector3(xpos, 3, zpos), Quaternion.identity);

   


       print(xpos + ", 3 ," + zpos);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
