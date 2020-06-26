
using UnityEngine;

public class jumer : MonoBehaviour
{
	public float speed = 2;
	
	public bool canMove = true;
	public bool MoveUP = true;
	public GameObject deatheffect;
	public AudioSource audio;
	
	
    
    void Update()
    {
        Move();
    }
	void Move()
	{
		if(canMove)
		{
		
			if(MoveUP){
			transform.Translate(0,2*Time.deltaTime * speed,0);
			
			}
			else
			{
			transform.Translate(0,-2*Time.deltaTime * speed,0);
			
			}
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.tag=="turn")
		{
			if(MoveUP)
			{
				MoveUP = false;
			}
			else
			{
				MoveUP = true;
			}
		}
		
		if(info.gameObject.tag=="bullet")
		{
			canMove = false;
			Invoke("disable",0.1f);
			Instantiate(deatheffect,transform.position,Quaternion.identity);
			
			
			
		}
	}
		
	void disable()
	{
		gameObject.SetActive(false);
	}
		
	
	
}
