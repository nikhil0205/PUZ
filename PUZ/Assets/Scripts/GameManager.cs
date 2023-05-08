using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay=1f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void EngGame ()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart",restartDelay);
            //();
        }
        

        
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
