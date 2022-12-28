using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDlay = 1f;
    public void EndGamne()
    {
        if (gameHasEnded == false )
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDlay);
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
