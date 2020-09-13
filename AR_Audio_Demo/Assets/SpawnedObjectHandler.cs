using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObjectHandler : MonoBehaviour
{

    public GameObject[] spawnableObjects;

    public void SpawnObject(int number)
	{
		Instantiate(spawnableObjects[number], new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z + 1f), Quaternion.identity);
	}

}
