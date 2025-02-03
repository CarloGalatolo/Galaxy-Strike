using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	// Params
	[SerializeField] float controlSpeed = 10;
	[SerializeField] Vector2 clampRange;
	[SerializeField] float rotationSpeed = 10;
	[SerializeField] float controlRotationFactor = 20;

	// State
	Vector2 movement;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start ()
    {
        
    }


    // Update is called once per frame
    void Update ()
    {
		// Process translation //
		Vector2 moveOffset = movement * controlSpeed * Time.deltaTime;

		float rawPositionX = transform.localPosition.x + moveOffset.x;
		float rawPositionY = transform.localPosition.y + moveOffset.y;

		float clampedPositionX = Mathf.Clamp(rawPositionX, -clampRange.x, clampRange.x);
		float clampedPositionY = Mathf.Clamp(rawPositionY, -clampRange.y, clampRange.y);

        transform.localPosition = new Vector3(clampedPositionX, clampedPositionY, 0);

		// Process rotation //
		float newPitch = controlRotationFactor * -movement.y;
		float newYaw   = controlRotationFactor *  movement.x;
		float newRoll  = controlRotationFactor * -movement.x;

		Quaternion targetRotation = Quaternion.Euler(newPitch, newYaw, newRoll);
		transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * rotationSpeed);
    }


	public void OnMove (InputValue value)
	{
		movement = value.Get<Vector2>();
	}
}
