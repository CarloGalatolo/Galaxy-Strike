using TMPro;
using UnityEngine;

public class DialogueLines : MonoBehaviour
{
	// Params
	[SerializeField] string[] timelineTextLines;

	// Cache
	[SerializeField] TMP_Text dialoguetext;

	// State
	int currentLine = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


	public void NextDialogueLine ()
	{
		dialoguetext.text = timelineTextLines[currentLine];
		currentLine++;
	}
}
