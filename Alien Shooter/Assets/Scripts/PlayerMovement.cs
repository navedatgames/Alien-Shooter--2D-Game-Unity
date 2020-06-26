using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   	public CharacterController2D control;
  	 public float runspeed = 40f;
	 float horizontalMove =0f;
	bool jump = false;
   	bool crouch = false;
	bool hurt = false;
	public Animator anim;
	public GameObject bullet;
	public Transform firepoint;
	public Transform firepoint1;
	public AudioSource audio;
	public AudioSource audi;
	
	public AudioSource startsound;

	public Vector3 respawnPoint;
	public GameManager game;
	
	public int lifeValue = 5;
	private int limit = 1;
		
	bool isPaused  = true;
	public GameObject pauseScreen;
	
	
	private bool shoot = true;
	void start()
	{
		
	}
    
	
	void Update()
    {
       
	Move(); 
	Shoot();
	stop();
	
    }
	void stop()
	{
		if(Input.GetButtonDown("Cancel"))
		
		{		
			if(isPaused)
			{

				
			
			
				Time.timeScale = 0;
				isPaused = false;
				pauseScreen.SetActive(true);
			}
			else
			{
				
				Time.timeScale = 1;
				isPaused = true;
				pauseScreen.SetActive(false);
			}
		}
		
	}
		
	void Move()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
		anim.SetFloat("speed",Mathf.Abs(horizontalMove));
		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
			anim.SetBool("isjump",true);
		}
	
		if(Input.GetButtonDown("alt"))
		{
			anim.SetBool("shootup",true);
			
			if(Input.GetButton("Fire2"))
			{
				Debug.Log("up");	
			Instantiate(bullet,firepoint1.position,firepoint1.rotation);
			}
	
		}
		else if(Input.GetButtonUp("alt"))
		{
			anim.SetBool("shootup",false);
			
		}
		
		if(Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if(Input.GetButtonUp("Crouch"))
			{
				crouch = false;
			}
		
			
			
	
		
	}
	
	void Shoot()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Instantiate(bullet,firepoint.position,firepoint.rotation);
			audio.Play();
		}
	}		

	public void OnLanding()
	{
		anim.SetBool("isjump",false);
	}
	
	public void OnCrouching(bool iscrouch)
	{
		anim.SetBool("iscrouch",iscrouch);
	}
	void FixedUpdate()
	{
		control.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump);
		jump = false;
	}
		
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.tag=="fall"||info.gameObject.tag=="enemy" )
		{
			if(lifeValue>limit)
			{
				transform.position = respawnPoint;
				lifeValue--;
				FindObjectOfType<GameManager>().ChangeValue(lifeValue);
			}
			else
			{
				FindObjectOfType<GameManager>().GameOver();
			}
					
		}
		if(info.gameObject.tag=="checkpoint")
		{
			
			respawnPoint = info.transform.position;
		}
	
		
	}
	
	void OnCollisionEnter2D(Collision2D info)
	{
		if(info.gameObject.tag=="lift")
		{	
			transform.parent = info.gameObject.transform;
		}
	}
	void OnCollisionExit2D(Collision2D info)
	{
		if(info.gameObject.tag=="lift")
		{
			transform.parent = null;
		}
	}
			
	
	
}
