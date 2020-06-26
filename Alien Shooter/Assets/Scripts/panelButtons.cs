using UnityEngine.SceneManagement;
using UnityEngine;

public class panelButtons : MonoBehaviour
{
	
	public void restartButton()
	{
		SceneManager.LoadScene("game");
		Time.timeScale = 1;
	}
	
	public void startButton()
	{
		SceneManager.LoadScene("menupage");
		Time.timeScale = 1;
	}
    
}
