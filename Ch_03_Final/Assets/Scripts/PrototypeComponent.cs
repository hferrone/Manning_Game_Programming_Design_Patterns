using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// S2
public class PrototypeComponent : MonoBehaviour
{
	public T Clone<T>() where T : Component
	{
		PrototypeComponent instance = Instantiate(this);
		GameObject spawner = GameObject.Find("Spawner");
		instance.transform.SetParent(spawner.transform, worldPositionStays: false);
		instance.transform.localPosition = new Vector3(Random.Range(0, 14), 1.0f, Random.Range(0, 14));

		return instance.GetComponent<T>();
	}
}