using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject unityChan = GameObject.Find ("unitychan");
		float updateStartPos = unityChan.transform.position.z;
		if(this.gameObject.transform.position.z<updateStartPos-20){
			Destroy(this.gameObject);
		}
		
	}
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
}
