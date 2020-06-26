
using UnityEngine;

public class exit : MonoBehaviour
{
    
  
	
   void OnTriggerEnter2D(Collider2D info)
	{
		if(info.tag=="Player")
		{
			
		
		FindObjectOfType<GameManager>().LevelComplete();
		}
	}
}
