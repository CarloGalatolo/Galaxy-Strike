using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
	// Cache
	[SerializeField] TMP_Text scoreText;

	// State
	int score = 0;


	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		
    }


    // Update is called once per frame
    void Update()
    {
        
    }


	public void ModifyScore (int amount)
	{
		score += amount;
		scoreText.text = "Score = " + score;
	}
}
