using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


	public void ReloadLevel ()
	{
		StartCoroutine(ReloadLevelRoutine());
	}


	IEnumerator ReloadLevelRoutine ()
	{
		yield return new WaitForSeconds(2);
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex);
	}
}
