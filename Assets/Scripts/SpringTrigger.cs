using UnityEngine;
using System.Collections;

public class SpringTrigger : MonoBehaviour {

  public float JumpMagnitude = 20;
	Animator anim;
	GameObject top;

	
  //public GameObject tong; 
  //// Use this for initialization
  //void Start () {
  //  anim = GetComponent<Animator>();
  //}

  public void ControllerEnter2D(CharacterController2D controller)
  {
    controller.SetVerticalForce(JumpMagnitude);
  }
	
  //// Update is called once per frame
  //void Update () {

  //}

  //void OnTriggerEnter(Collider cubeTrigger)
  //{
  //  if (cubeTrigger.tag == "Tongs")
  //  {
  //    anim.enabled = !anim.enabled;
  //  }
  //}
	
}
