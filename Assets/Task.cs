using UnityEngine;

public class Task : MonoBehaviour
{
	public GameObject taskUI;
	private bool playerInRange = false;

	void Update()
	{
		if (playerInRange && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.E)))
		{
			if (taskUI != null)
			{
				taskUI.SetActive(!taskUI.activeSelf);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			playerInRange = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			playerInRange = false;
			if (taskUI != null)
			{
				taskUI.SetActive(false);
			}
		}
	}
}