
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public Animator anim;
	public AudioSource checkPoint;
    void OnTriggerEnter2D(Collider2D info)	
	{
		if(info.tag=="Player")
		{
			anim.Play("touch");
			checkPoint.Play();
		}
	}

}
