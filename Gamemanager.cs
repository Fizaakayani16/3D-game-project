using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
public float Restartdely = 1f;
bool gamehasEnded = false; //assined a vaiable to gamemanager
public GameObject Completelevelui;
public void CompleteLevel()// to end game
{
    Completelevelui.SetActive(true);
    Debug.Log("Level Complete");

}
public void GameOver()

    {
        if (gamehasEnded == false) //condition for the gamemanager
    {
        gamehasEnded = true;
        Debug.Log("GAME OVER :(");
        Invoke("Restart", Restartdely);
    }
    }

    void Restart() //function used to restart the gameScene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// code used to active the next scene 
    }
}
