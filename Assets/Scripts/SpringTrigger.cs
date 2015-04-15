using UnityEngine;
using System.Collections;

public class SpringTrigger : MonoBehaviour {
	
	Animator anim;
	GameObject top;

	
	public GameObject tong; 
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider cubeTrigger)
	{    
		if (cubeTrigger.tag == "Tongs")
		{
			anim.enabled = !anim.enabled;
	}
	
}
