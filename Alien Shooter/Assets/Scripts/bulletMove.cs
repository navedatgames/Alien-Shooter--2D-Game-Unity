
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    	public Rigidbody2D rb;
	public float speed = 5f;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
	void OnTriggerEnter2D(Collider2D info)
	{
		if(info.gameObject.tag=="enemy")
		{
			gameObject.SetActive(false);
		}
		if(info.gameObject.tag=="boundry")
		{
			gameObject.SetActive(false);
		}
	}
	

   
}
