using UnityEngine;
using System.Collections;

public class Flammes : MonoBehaviour {


	public float startTime;

	// Use this for initialization
	void Start () {

		float startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > startTime + 1) {
			this.transform.localScale += new Vector3 (0.1F, 0.0f, 0.0f);
			this.transform.localPosition += new Vector3 (0.05F, 0.0f, 0.0f);
			//marche pas, voir en bas pour des idées
		}
		


		if (Time.time > startTime + 8) {
			Destroy (this.gameObject);
		}			
	


	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.name.Equals ("X")) {
			Destroy (this.gameObject);
		}

		if (c.gameObject.name.Equals ("O")) {
			Destroy (c.gameObject);
			Destroy (this.gameObject);
		}
		if (c.gameObject.name.Equals ("J")) {
			// -1 sur attribut "vie" du gameobject joueur
			Destroy (this.gameObject);
		}
	
	}




}


// ajouter une variable "dir" globale valant 0/1/2/3 selon la flamme, et s'en servir pour orienter le deplacement (avec des if)
// utiliser "gameObject.GetComponent<bomb_test> ().dir" ?

