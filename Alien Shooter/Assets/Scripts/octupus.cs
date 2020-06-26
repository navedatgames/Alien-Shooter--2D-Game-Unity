
using UnityEngine;

public class octupus : MonoBehaviour
{
	public float speed = 2;
	
	public bool canMove = true;
	public bool MoveRight = true;
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
		
			if(MoveRight){
			transform.Translate(2*Time.deltaTime * speed,0,0);
			transform.localScale = new Vector2(-12,12);
			}
			else
			{
			transform.Translate(-2*Time.deltaTime * speed,0,0);
			transform.localScale = new Vector2(12,12);
			}
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.tag=="turn")
		{
			if(MoveRight)
			{
				MoveRight = false;
			}
			else
			{
				MoveRight = true;
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
