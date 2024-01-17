using UnityEngine;

public class PageManager : MonoBehaviour
{
	public Enemy enemy;
	public int pagesCollected = 0;

	void OnTriggerEnter(Collider other)
	{
		print("page collected");
		Destroy(other.gameObject);

		pagesCollected++;

		if (pagesCollected == 1)
		{
			enemy.target = transform;
		}

		if (pagesCollected == 2)
		{
			enemy.speed *= 2;
		}

		if (pagesCollected == 3)
		{
			enemy.viewRange = 50;
		}

		if (pagesCollected == 4)
		{
			enemy.speed *= 2;
		}

		if (pagesCollected == 4)
		{
			enemy.viewRange = 60;
		}
	}
}
