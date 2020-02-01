using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{

	public GameObject Projectile ;
	public double rateOfSpawn;
	public double nextSpawnTime;
	public Sprite[] projectileOptions;

	// Start is called before the first frame update
	void Start()
	{
		SpawnProjectile();
		rateOfSpawn = 5;
		nextSpawnTime = Time.realtimeSinceStartup + rateOfSpawn;
	}

	private void SpawnProjectile()
	{
		var horzExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
		GameObject tmp = Instantiate(Projectile);
		int sprite = Random.Range(0, 3);
		tmp.GetComponent<SpriteRenderer>().sprite = projectileOptions[sprite];
		float randomX = Random.value * (Camera.main.orthographicSize * 2) - Camera.main.orthographicSize;
		tmp.transform.position = new Vector3(randomX, horzExtent, 0.0f);
	}

	// Update is called once per frame
	void Update()
    {

		if (Time.realtimeSinceStartup >= nextSpawnTime) {
			SpawnProjectile();
			nextSpawnTime = Time.realtimeSinceStartup + rateOfSpawn;
			if (rateOfSpawn > 0.1)
			{

			rateOfSpawn = rateOfSpawn - 0.1;
	}
		}
	}
}
