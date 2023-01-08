using System.Collections.Generic;
using UnityEngine;
using System.Collections;

//This is an old player controller of mine from a small project I made ~6 months ago
//a few added changes such as the respawn as I always used the button r to return me back
//to the start for testing purposes
public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform playerCamera = null;
    // Start is called before the first frame update
    [SerializeField] float mouseSensitivity = 3.5f;
    [SerializeField] bool lockCursor = true;
    [SerializeField] float walkSpeed = 4.0f;
    [SerializeField] float gravity = -9.81f;
    float cameraPitch = 0.0f;
    float velocityY = 0.0f;
    CharacterController controller = null;
    public bool fell = false;

    public CharacterController Controller { get => controller; set => controller = value;}

    void Start()
    {
        Controller = GetComponent<CharacterController>();
        if(lockCursor){
           Cursor.lockState = CursorLockMode.Locked;
           Cursor.visible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMouseLook();
        UpdateMovement();
	  if(Input.GetKey(KeyCode.R)){
		Controller.transform.position = new Vector3(0,1.04999995f,0);
	  }if(fell==true){
		Controller.transform.position = new Vector3(0,4,0);
		print("oops, you fell!");
		fell = false;
        }
    }
    void UpdateMouseLook(){
      Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
      // horizontal camera movement
      cameraPitch -= mouseDelta.y;
      cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
      playerCamera.localEulerAngles = Vector3.right *cameraPitch;
      // vertical camera movement
      transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
      

    }
  
    void UpdateMovement(){
      Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      inputDir.Normalize();
      if(controller.isGrounded){
         velocityY = 0.0f;
      } 
	if(Input.GetKey(KeyCode.Space) && controller.isGrounded){
	   velocityY= 4.5f;
	}
	if(Input.GetKeyDown(KeyCode.LeftShift)){
	    walkSpeed = 6f;
	}
	if(Input.GetKeyUp(KeyCode.LeftShift)){
	    walkSpeed = 4f;
	}
      velocityY += gravity * Time.deltaTime;
      Vector3 velocity = (transform.forward *inputDir.y + transform.right * inputDir.x) *walkSpeed + Vector3.up * velocityY;
      Controller.Move(velocity * Time.deltaTime);
    }
}