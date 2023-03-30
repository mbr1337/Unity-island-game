using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathTrigger : MonoBehaviour
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
    void OnTriggerEnter(Collider other) {
        if(other.gameObject == _player ){
            textHints.SendMessage("ShowHint", "Game Over");
            Time.timeScale = 0.1f;
            Invoke(nameof(Load),0.2f);
        }
    }
    public void Load() {
        Time.timeScale = 1;
        Retry();
    } 
    public void Retry()
    {
        //Restarts current level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
