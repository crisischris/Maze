using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public GameObject poof;
    public GameObject coin;
    public GameObject door;

    float xpos;
    float zpos;
    
    void start()
    {

    }

     public void OnCoinClicked() {

        // Locate the instantiated coin position.
        
        xpos = coin.transform.position.x;
        zpos = coin.transform.position.z;

        //instantiate the poof prefab - dpending on Quaternion - and destroy the coin prefrab unpon click

        if(zpos == 42 || zpos == 47 || zpos == 103.5f)

        {
            Object.Instantiate(poof, new Vector3(xpos, 0, zpos), Quaternion.Euler(-90, 0, 0));
                    }

        else

        {
            Object.Instantiate(poof, new Vector3(xpos, 0, zpos), Quaternion.Euler(0, 0, -90));
        }

        Destroy(coin);

        //print checks
        print("made the poof at " + coin.transform.position.x + ", " + coin.transform.position.y + ", " + coin.transform.position.z);
        print("you got the coin, stupid!");
    }
}
