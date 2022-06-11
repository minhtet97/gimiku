using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
   /* private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player")
        {
            Destroy (GameObject.FindWithTag("Player"));
        }
        
    }*/
    public string ChangeScene;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(ChangeScene);
        }
    }
}
