using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject,2);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
