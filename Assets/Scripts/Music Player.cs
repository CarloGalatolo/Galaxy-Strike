using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ()
    {
        int numOfMusicPlayers = FindObjectsByType<MusicPlayer>(FindObjectsSortMode.None).Length;

		if (numOfMusicPlayers > 1)
		{
			Destroy(this.gameObject);	// Destroys itself if already another one exists. Singleton approach.
		}
		else
		{
			DontDestroyOnLoad(this.gameObject);	// Persists after reload.
		}
    }


    // Update is called once per frame
    void Update ()
    {
        
    }
}
