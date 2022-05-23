using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPush : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{
		gameObject.transform.position = Vector3.forward * Time.deltaTime * Speed;
	}
}
