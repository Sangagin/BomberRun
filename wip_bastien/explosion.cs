using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	public float startTime;
	public GameObject flammes;

	// Use this for initialization
	void Start () {
		float startTime = Time.time;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Time.time > startTime + DelayedAttribute) {
			Vector3 pos = this.transform.position;
			for (int i = 0; i < PowerAttribute; i++) {
				Instantiate (flammes, pos.x + i, this.transform.rotation);
				Instantiate (flammes, pos.x - i, this.transform.rotation);
				Instantiate (flammes, pos.z + i, this.transform.rotation);
				Instantiate (flammes, pos.z - i, this.transform.rotation);
			}
			Destroy (this.gameObject);
		}
	}
}

