using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
   private GameManager game;
	public int coinValue;
    void Start()
    {
       game = FindObjectOfType<GameManager>(); 
    }

   void OnTriggerEnter2D(Collider2D info)
	{
		if(info.tag=="Player")
		{
			Destroy(gameObject);
			game.AddCoin(coinValue);
			
		}
	}
}
