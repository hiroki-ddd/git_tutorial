using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	float speed=5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.gameObject.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0);
		}
	}

}
