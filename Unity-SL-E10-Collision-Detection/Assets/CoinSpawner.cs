using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	public GameObject coinPrefab;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			Vector3 randomSpawnPosition = new Vector3(Random.Range(-10f, 10), 1.25f, Random.Range(-10f, 10f));
			Vector3 randomSpawnRotation = Vector3.up * Random.Range(0, 360);

			GameObject newChair = (GameObject)Instantiate(coinPrefab, randomSpawnPosition, Quaternion.Euler(randomSpawnRotation));
			newChair.transform.parent = transform;
		}
	}
}