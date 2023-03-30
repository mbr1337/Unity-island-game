using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    bool doorIsOpen = false;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void DoorCheck(){
        if(!doorIsOpen){
            Door(true, doorOpenSound, "dooropen");
        }
    }
    
    void Door(bool openCheck,AudioClip aClip, string animName){
        if(openCheck == true){
            openCheck = true;
            GetComponent<AudioSource>().PlayOneShot(aClip);
            transform.parent.GetComponent<Animation>().Play(animName);
        } else {
            openCheck = false;
            GetComponent<AudioSource>().PlayOneShot(aClip);
            transform.parent.GetComponent<Animation>().Play(animName);
        }
    }
}

