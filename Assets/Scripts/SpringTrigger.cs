using UnityEngine;
using System.Collections;

public class SpringTrigger : MonoBehaviour {

  public float JumpMagnitude = 20;
    Animator animator;
	Animation animation;
	GameObject top;

	
  void Start () {
      animation = GetComponent<Animation>();
  }

  public void ControllerEnter2D(CharacterController2D controller)
  {
    controller.SetVerticalForce(JumpMagnitude);
  }
	
  //// Update is called once per frame
  //void Update () {

  //}

  void OnTriggerEnter(Collider cubeTrigger)
  {
    if (cubeTrigger.tag == "Player")
    {
        animation.Play("hinge");
        
    }
  }
	
}
