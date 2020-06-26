using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public int coin = 0;
	public Text coinText;
	public Text lifeText;
	public Text endScoreText;
	public Text levelScoreText;
	public GameObject gameover;
	public GameObject levelComplete;
	public PlayerMovement move;
	public AudioSource coincollect;
	public AudioSource respawn;
	public AudioSource levelcom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void AddCoin(int noOfCoin)
	{
		coin+=noOfCoin;
		coinText.text = coin.ToString();
		coincollect.Play();
		
	}
	public void ChangeValue(int lifeValue)
	{
		lifeText.text = lifeValue.ToString();
		respawn.Play();
	}
	
	public void GameOver()
	{
		endScoreText.text = coin.ToString();
		gameover.SetActive(true);
		move.enabled = false;
	}
	
	public void LevelComplete()
	{
		levelScoreText.text = coin.ToString();
		levelComplete.SetActive(true);
		move.enabled = false;
		levelcom.Play();
	}
		
		
		
		
	
}
