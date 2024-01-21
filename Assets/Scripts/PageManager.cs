using UnityEngine;

public class PageManager : MonoBehaviour
{
	public Enemy enemy;
	public int pagesCollected = 0;
	

	void OnTriggerEnter(Collider other)
	{
	if (!other.gameObject.CompareTag("Page"))
		{
			return;
		}	
		
		print("page collected");
		//Destroy(other.gameObject.CompareTag("Page"));
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

		if (pagesCollected == 5)
		{
			enemy.speed *= 2;
			enemy.viewRange = 100;
		}
	}
}
