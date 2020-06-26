using UnityEngine.SceneManagement;
using UnityEngine;

public class backButton : MonoBehaviour
{
    public GameObject ctr;
	public GameObject str;
	
	public void Back()
	{
		ctr.SetActive(false);
		str.SetActive(true);
	}
}
