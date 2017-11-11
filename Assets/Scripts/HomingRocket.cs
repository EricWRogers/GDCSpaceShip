using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingRocket : MonoBehaviour {

	public int dmg = 60;
	ObjectPool manager;
	GameObject target;
	Rigidbody rb;
	public float detectAngle = 90;
	public float rotateSpeed = 20f;
	public float speed = 50f;
	public float lifetime = 300f;

	void Start () {
		manager = GameObject.FindGameObjectWithTag("Enemy Manager").GetComponent<ObjectPool>();
		rb = gameObject.GetComponent<Rigidbody>();
	}

	void GetTarget () {
		for (int i = 0; i < manager.pool.Count; i++) {
			if (manager.pool[i].activeInHierarchy) {
				Vector3 dir = manager.pool[i].transform.position - transform.position;
				float angle = Vector3.Angle(dir, transform.forward);
				if (angle <= detectAngle/2) {
					if (!target || !target.activeInHierarchy || Vector3.Distance(manager.pool[i].transform.position, transform.position) < Vector3.Distance(target.transform.position, transform.position)) {
						target = manager.pool[i];
					}
				}
			}
		}
	}

	void Update() {
		lifetime--;
		float step = rotateSpeed * Time.deltaTime;
		if (!target || !target.activeInHierarchy) {
			GetTarget();
		}
		if (target) {
			Vector3 dir = target.transform.position - transform.position;
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), step);
		}
		rb.velocity = transform.forward * speed;
		if (lifetime == 0) {
			DestroyMissile();
		}
	}

	void DestroyMissile() {
		ParticleSystem ps = gameObject.GetComponentInChildren<ParticleSystem>();
		ps.gameObject.transform.parent = null;
		ParticleSystem.EmissionModule em = ps.emission;
		em.enabled = false;
		Destroy(ps.gameObject, ps.startLifetime);
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
			other.GetComponent<Enemy>().Damage(dmg);
			DestroyMissile();
		}
	}
}
