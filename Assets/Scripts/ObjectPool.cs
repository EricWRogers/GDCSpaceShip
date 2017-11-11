using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public GameObject poolObject; //The GameObject we want to be pooling
	public int poolSize = 10; //Initial size of the pool
	public bool expand = false; //Do we want to create new objects and expand the pool if we run out of objects in the pool?

	public List<GameObject> pool; //The list of objects in the pool

	void Start () {
		pool = new List<GameObject>();
		for (int i = 0; i < poolSize; i++) { //Create a new object for whatever the inital size of the pool is
			CreateObject();
		}
	}

	GameObject CreateObject() { //Creates a new object, adds it to the pool
		GameObject obj = (GameObject)Instantiate(poolObject);
		obj.SetActive(false);
		pool.Add(obj);
		return obj;
	}

	public GameObject GetFromPool() { //Get an inactive object from the pool (Returns an object if either we can create new objects or if we have an inactive object available, null otherwise)
		for (int i = 0; i < pool.Count; i++) {
			if (!pool[i].activeInHierarchy) return pool[i]; //Once we get an inactive object in the pool, return it
		}
		if (expand) { //If we can create new objects
			return CreateObject(); //Create a new object and return it
		}
		return null;
	}
}
