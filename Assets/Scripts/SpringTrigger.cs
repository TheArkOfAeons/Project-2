using UnityEngine;
using System.Collections;

public class SpringTrigger : MonoBehaviour {
	Animator anim;
	int springHash = Animator.StringToHash("hinge");

	
	public GameObject tong; 
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger (springHash);
        }
		
	
	}

	void OnTriggerEnter (Collider cubeTrigger)
	{    
		
	}
	
}
