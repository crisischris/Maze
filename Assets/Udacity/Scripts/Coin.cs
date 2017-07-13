using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public GameObject ObjectToCreate;


    void start()
    {
        Debug.Log("this should be working!");
        Object.Instantiate(ObjectToCreate, new Vector3(0, 5, 130), Quaternion.Euler(-90, 0, 0));

       
    }

    // public void OnCoinClicked() {

    //Object.Instantiate(coinPoof, new Vector3(10,10,10), Quaternion.identity);
    // Instantiate the CoinPoof Prefab where this coin is located
    // Make sure the poof animates vertically
    // Destroy this coin. Check the Unity documentation on how to use Destroy
    // }

}
