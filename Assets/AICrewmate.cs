using UnityEngine;

public class AICrewmate : MonoBehaviour
{
	public float speed = 2.0f;
	private GameObject[] waypoints;
	private Vector3 targetPosition;
	private bool isWaiting = false;
	private float waitTimer = 0f;

	void Start()
	{
		waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
		PickNewWaypoint();
	}

	void Update()
	{
		if (isWaiting)
		{
			waitTimer -= Time.deltaTime;
			if (waitTimer <= 0)
			{
				isWaiting = false;
				PickNewWaypoint();
			}
		}
		else
		{
			MoveTowardsTarget();
		}
	}

	void PickNewWaypoint()
	{
		if (waypoints.Length == 0) return;
		int randomIndex = Random.Range(0, waypoints.Length);
		targetPosition = waypoints[randomIndex].transform.position;
	}

	void MoveTowardsTarget()
	{
		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

		if (Vector3.Distance(transform.position, targetPosition) < 0.2f)
		{
			isWaiting = true;
			waitTimer = Random.Range(3.0f, 6.0f);
		}
	}
}