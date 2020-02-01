using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{

	public GameObject Projectile ;

	// Start is called before the first frame update
	void Start()
	{
		SpawnProjectile();

	}

	private void SpawnProjectile()
	{
		var horzExtent = Camera.main.orthographicSize * Screen.width / Screen.height;
		GameObject tmp = Instantiate(Projectile);
		float randomX = Random.value * (Camera.main.orthographicSize * 2) - Camera.main.orthographicSize;
		tmp.transform.position = new Vector3(randomX, horzExtent, 0.0f);
	}

	// Update is called once per frame
	void Update()
    {
		if (Time.realtimeSinceStartup % 5 < 0.01) {
			SpawnProjectile();
		}
	}
}
