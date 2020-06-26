using UnityEngine.SceneManagement;
using UnityEngine;

public class startGame : MonoBehaviour
{	
	public GameObject srt;
	public GameObject ctr;
	
	public void start()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void control()
	{
		srt.SetActive(false);
		ctr.SetActive(true);
	}
	
	public void exit()
	{
		Application.Quit();
	}
		
}
