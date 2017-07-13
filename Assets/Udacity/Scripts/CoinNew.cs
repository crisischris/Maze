using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNew : MonoBehaviour {

    public GameObject ObjectToCreate;



  //  public GameObject coin;

   // private GameObject ObjectToDestroy;


    void Start()
    {

        GameObject.Instantiate(ObjectToCreate, new Vector3(0, 1, 130), Quaternion.Euler(-90, 0, 0));

      //  ObjectToDestroy = Object.Instantiate(coin, new Vector3(0, 1, 130), Quaternion.Euler(-90, 0, 0));
      
       // Object.Instantiate(ObjectToCreate, new Vector3(0, 1, 130), Quaternion.Euler(-90, 0, 0));

       // Destroy(ObjectToDestroy);
        
      

    }
}




// public void OnCoinClicked() {

//Object.Instantiate(coinPoof, new Vector3(10,10,10), Quaternion.identity);
// Instantiate the CoinPoof Prefab where this coin is located
// Make sure the poof animates vertically**
// Destroy this coin. Check the Unity documentation on how to use Destroy
// }

