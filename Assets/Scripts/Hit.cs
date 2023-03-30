using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hit : MonoBehaviour
{
    public Text textHints;
    GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision theObject) {
        if(theObject.gameObject.name=="coconut") {
            GetComponent<Animator>().SetTrigger("hit");
        }       
    }
    
}
