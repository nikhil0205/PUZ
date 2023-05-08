using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollide : MonoBehaviour
{
   // public GameManager gameManager;
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "player")
        {
            Destroy(collisionInfo.gameObject);
            //Debug.Log("Game Over");
            //SceneManager.LoadScene("gameover");
            FindObjectOfType<GameManager>().EngGame();
            
        }
       // Debug.Log("OutsideFunction");

    }
}