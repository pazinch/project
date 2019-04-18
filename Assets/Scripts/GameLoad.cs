using UnityEngine;
using System.Collections;

public class GameLoad : MonoBehaviour {

	public void LoadMainLevel()
    {
        Application.LoadLevel("Main");
        Debug.Log("Main executing");
    }

    public void LoadMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void LoadOptions()
    {
        Application.LoadLevel("Options");
    }

    public void LoadRanking()
    {
        Application.LoadLevel("Ranking");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void LoadRegister()
    {
        Application.LoadLevel("Register");
    }

	
}
