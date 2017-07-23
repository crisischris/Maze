using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour {


    public GameObject coin;
    float[] posx = { 8,  -8,     -8,   3.5f, 3,      8,       13.5f,   -3,  -3,  -7,  -2,  3, 9 };
    float[] posz = { 42, 42.5f,   47,  63,   103.5f, 108.5f,  91,       93,  88,  80,  64, 40, 36 };
        
    int randomIndex1;
    int randomIndex2;
    int randomIndex3;
    int randomIndex4;
    int randomIndex5;

   
    
    void Start()
    {

        // pick random index number from array, depending on position in array, spin Quaternion in game.

        var posListZ = new List<float>();
        posListZ.AddRange(posz);

        var posListX = new List<float>();
        posListX.AddRange(posx);
        
                
        randomIndex1 = Random.Range(0, posListX.Count - 1);
        GameObject.Instantiate(coin, new Vector3(posListX[randomIndex1], 3, posListZ[randomIndex1]), Quaternion.Euler(0,90,0));
  
        print(posListX[randomIndex1] + "," + posListZ[randomIndex1]);
        posListX.RemoveAt(randomIndex1);
        posListZ.RemoveAt(randomIndex1);


        randomIndex2 = Random.Range(0, posListX.Count - 1);
        GameObject.Instantiate(coin, new Vector3(posListX[randomIndex2], 3, posListZ[randomIndex2]), Quaternion.Euler(0, 90, 0));

        print(posListX[randomIndex2] + "," + posListZ[randomIndex2]);
        posListX.RemoveAt(randomIndex2);
        posListZ.RemoveAt(randomIndex2);

        randomIndex3 = Random.Range(0, posListX.Count - 1);
        GameObject.Instantiate(coin, new Vector3(posListX[randomIndex3], 3, posListZ[randomIndex3]), Quaternion.Euler(0, 90, 0));
        print(posListX[randomIndex3] + "," + posListZ[randomIndex3]);
        posListX.RemoveAt(randomIndex3);
        posListZ.RemoveAt(randomIndex3);

        randomIndex4 = Random.Range(0, posListX.Count - 1);
        GameObject.Instantiate(coin, new Vector3(posListX[randomIndex4], 3, posListZ[randomIndex4]), Quaternion.Euler(0, 90, 0));
        print(posListX[randomIndex4] + "," + posListZ[randomIndex4]);
        posListX.RemoveAt(randomIndex4);
        posListZ.RemoveAt(randomIndex4);

        randomIndex5 = Random.Range(0, posListX.Count - 1);
        GameObject.Instantiate(coin, new Vector3(posListX[randomIndex5], 3, posListZ[randomIndex5]), Quaternion.Euler(0, 90, 0));
        print(posListX[randomIndex5] + "," + posListZ[randomIndex5]);
        posListX.RemoveAt(randomIndex5);
        posListZ.RemoveAt(randomIndex5);
    }

 

}
