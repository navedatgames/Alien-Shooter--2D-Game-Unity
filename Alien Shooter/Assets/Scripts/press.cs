using UnityEngine.SceneManagement;
using UnityEngine;

public class press : MonoBehaviour
{
    public AudioSource enter;
    void Start()
    {
       
    }

   
    void Update()
    {
	if(Input.GetButtonDown("Submit"))
	{	
		Invoke("next",1f);
		enter.Play();
		
	} 
        
    }
	void next()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
