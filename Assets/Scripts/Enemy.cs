using UnityEngine;

public class Enemy : MonoBehaviour
{
	// Params
	[SerializeField] int hitPoints  = 6;
	[SerializeField] int scoreValue = 1;

	// Cache
	[SerializeField] GameObject explosionVFX;
	Scoreboard scoreboard;



	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start ()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }


    // Update is called once per frame
    void Update ()
    {
        
    }


	void OnParticleCollision (GameObject other)
	{
		hitPoints--;

		if (hitPoints <= 0)
		{
			scoreboard.ModifyScore(scoreValue);
			Instantiate(explosionVFX, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
