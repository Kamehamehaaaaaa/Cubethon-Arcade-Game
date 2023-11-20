using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    AudioManager audioManager;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        audioManager = FindObjectOfType<AudioManager>();
        audioManager.CompleteLevelSFX();
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            audioManager = FindObjectOfType<AudioManager>();
            audioManager.CrashSFX();
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
