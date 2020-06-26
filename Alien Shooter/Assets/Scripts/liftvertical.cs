
using UnityEngine;

public class liftvertical : MonoBehaviour
{
    public bool moveUP = true;
	public float speed = 2f;
    

  
    void Update()
    {
       if(moveUP)
	{
		transform.Translate(0,2*Time.deltaTime* speed,0);
	}
	else
	{
		transform.Translate(0,-2*Time.deltaTime* speed,0);
	}
		
    }
	
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.tag=="push")
		{	
			if(moveUP)
			{
				moveUP = false;
			}
			else
			{
				moveUP = true;
			}
		}
	}
}
