using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

	public Transform sphereTransform;
	bool toggled = true;

	// Use this for initialization
	void Start()
	{
		sphereTransform.parent = transform;
		sphereTransform.localScale = Vector3.one * 2;
	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.up * Time.deltaTime * 180, Space.World);
		transform.Translate(Vector3.forward * Time.deltaTime * 7, Space.World);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (toggled == true)
			{
				sphereTransform.localPosition = Vector3.left * 2;
				toggled = false;
			}
			else
			{
				sphereTransform.localPosition = Vector3.right * 2;
				toggled = true;
			}
		}
	}
}