using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
	// Params
	[SerializeField] GameObject[] lasers;
	[SerializeField] float targetDistance = 100;

	// Cache
	[SerializeField] RectTransform crosshair;
	[SerializeField] Transform targetPoint;

	// State
	bool bIsFiring = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ()
    {
        Cursor.visible = false;	// Hide mouse cursor.
    }


    // Update is called once per frame
    void Update ()
    {
		// Process firing //
		foreach (GameObject laser in lasers)
		{
			var emissionModule = laser.GetComponent<ParticleSystem>().emission;
			emissionModule.enabled = bIsFiring;
		}

		// Move crosshair //
		crosshair.position = Input.mousePosition;

		// Move target point //
		Vector3 targetPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
		targetPoint.position = Camera.main.ScreenToWorldPoint(targetPosition);
			
		// Aim lasers //
		Vector3 fireDirection = targetPoint.position - this.transform.position;
		Quaternion rotationToTarget = Quaternion.LookRotation(fireDirection);

		foreach (GameObject laser in lasers)
		{
			laser.transform.rotation = rotationToTarget;
		}
    }


	public void OnFire (InputValue value)
	{
		bIsFiring = value.isPressed;
	}
}
