using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
	// Cache
	[SerializeField] GameObject explosionVFX;
	[SerializeField] GameObject masterTimeline;
	GameSceneManager gameSceneManager;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


	void OnTriggerEnter (Collider other)
	{
		// Debug.Log($"Hit {other.name}");	// String interpolation in C#.
		Instantiate(explosionVFX, transform.position, Quaternion.identity);
		Destroy(this.gameObject);
		Destroy(masterTimeline);
		gameSceneManager.ReloadLevel();
	}
}
