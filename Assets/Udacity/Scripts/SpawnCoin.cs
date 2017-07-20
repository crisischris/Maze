using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour {
    
    public GameObject coin;
    float[] posx = { 8, -8, -8, 3.5f, 3, 8 };
    float[] posz = { 42, 42.5f, 47, 63, 103.5f, 108.5f };

    int randomIndex;

    private float xpos;
    private float zpos;
    
    void Start()
    {
        // pick random index number from array, depending on position in array, spin Quaternion in game.

            randomIndex = Random.Range(0, posx.Length - 1);
        
            if (randomIndex == 0 || randomIndex == 2 || randomIndex == 4)
            {
                GameObject.Instantiate(coin, new Vector3(posx[randomIndex], 3, posz[randomIndex]), Quaternion.Euler(0, 90, 0));

            print("Index number = " + randomIndex);
            print("Coin transform = " + posx[randomIndex] + ", 3 ," + posz[randomIndex]);

            return;

            }
            
            GameObject.Instantiate(coin, new Vector3(posx[randomIndex], 3, posz[randomIndex]), Quaternion.identity);

        //print checks 

        print("Index number = " + randomIndex);
        print("Coin transform = " + posx[randomIndex] + ", 3 ," + posz[randomIndex]);
        
    }
  
}
