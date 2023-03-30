using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent (typeof (AudioSource))]
public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioClip lockedSound;
    public Text textHints;
    public Light doorLight;
    void OnTriggerEnter(Collider col){
        // if(col.gameObject.tag == "Player"){
        //     transform.Find("door").SendMessage("DoorCheck");
        // }
        if(col.gameObject.tag == "Player"){
            if(Inventory.charge == 4){
                transform.Find("door").SendMessage("DoorCheck");
                if(GameObject.Find("PowerGUI")){
                    Destroy(GameObject.Find("PowerGUI"));
                    doorLight.color = Color.green;
                }
            }
            else if (Inventory.charge > 0 && Inventory.charge < 4){
                textHints.SendMessage("ShowHint", "Drzwi ani drgną … \n pewnie potrzebują więcej mocy...");
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
            }
            else {
                transform.Find("door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                col.gameObject.SendMessage("HUDon");
                textHints.SendMessage("ShowHint", "Te drzwi wyglądają na zamknięte, \n być może generator wymaga \n odpowiedniego zasilania...");
            }
        }
    }
}
