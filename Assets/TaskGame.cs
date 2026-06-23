using UnityEngine;
using UnityEngine.UI;

public class TaskGame : MonoBehaviour
{
	public GameObject taskUI;
	public Button completionButton;
	private SpriteRenderer spriteRenderer;
	private bool isCompleted = false;

	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();

		if (completionButton != null)
		{
			completionButton.onClick.AddListener(CompleteTask);
		}
	}

	void CompleteTask()
	{
		isCompleted = true;

		if (taskUI != null)
		{
			taskUI.SetActive(false);
		}

		if (spriteRenderer != null)
		{
			spriteRenderer.color = Color.gray;
		}

		Task script = GetComponent<Task>();
		if (script != null)
		{
			script.enabled = false;
		}
	}
}