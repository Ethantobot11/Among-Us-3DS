using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 4.0f;

	void Update()
	{
		Vector3 movement = Vector3.zero;

		if (Input.GetKey(KeyCode.Keypad8) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			movement.y += 1f;
			Debug.Log("Up key pressed!");
		}
		else if (Input.GetKey(KeyCode.Keypad2) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			movement.y -= 1f;
		}

		if (Input.GetKey(KeyCode.Keypad4) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			movement.x -= 1f;
		}
		else if (Input.GetKey(KeyCode.Keypad6) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			movement.x += 1f;
		}

		if (movement.magnitude > 1f)
		{
			movement.Normalize();
		}
		transform.position += movement * speed * Time.deltaTime;
	}
}