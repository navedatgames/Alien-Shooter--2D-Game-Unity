
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool isPaused = false;
    void Start()
    {
        
    }

    public void pressed()
	{
		if(isPaused)
		{
			Time.timeScale = 1;
			isPaused = false;
		}
		else
		{
			Time.timeScale = 0;
			isPaused = true;
		}
	}
}
