using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{ 

 public GameObject door;
 bool locked = true;
 bool opening = false;
 float doorPos;
 //public AudioSource[] sources = new AudioSource [2];


    public AudioClip soundOpening;
    public AudioClip soundLocked;


    void start()
    {
        
    }

    void Update() {

        //check door y position
        doorPos = transform.position.y;
        
        //move door up
        if (opening == true && doorPos < 8)
        {
            
                door.transform.Translate(new Vector3(-0, 8f * Time.deltaTime, 0));
            
        }

    }

    public void OnDoorClicked() {
        print("locked = " + locked);

        if ( locked == false)

        {
            opening = true;
            print(opening);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(soundOpening);

        }


        else
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(soundLocked);

        }
                 
    }
    
    public void Unlock()
    {

        locked = false;
            
    }




}
