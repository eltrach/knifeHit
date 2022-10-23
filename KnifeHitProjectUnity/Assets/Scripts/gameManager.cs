using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class gameManager : MonoBehaviour
{
    public static gameManager instance;



    [SerializeField] private GameObject gameOverPanel;
	void Awake ()
	{
        gameOverPanel.gameObject.SetActive(false);
		if (instance) 
		{
			DestroyImmediate (gameObject);
		} 
		else 
		{
			DontDestroyOnLoad (gameObject);
			instance = this;
		}
	}

    public void Victory()
    {

    }

    public void GameOver()
    {
        Debug.Log("!! YOU LOSE !!");
        gameOverPanel.gameObject.SetActive(true);
        

    }
    public void retry()
    {
        SceneManager.LoadScene(0);
        gameOverPanel.gameObject.SetActive(false);

    }

}
