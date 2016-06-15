using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    Vector3 movement;           //In What Direction will the camera Move

    public float moveSpeed;     //How Fast can the camera move?
    public float rotateSpeed;   //How fast can the Camera turn?
    public float zoomSpeed;     //How Much do we zoom in?
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = new Vector3();                                   //Reset Movement
        float moveX = Input.GetAxisRaw("Horizontal");               //Get movement on X plane
        float moveZ = Input.GetAxisRaw("Vertical");                 //Get Movement on Z plane
        float mouseZoom = Input.GetAxisRaw("Mouse ScrollWheel");    //Get ScrollWheel movement

        movement = new Vector3(moveX, 0, moveZ);                    //Set Base MoveMent

        if(Input.GetAxisRaw("Fire2") != 0)      //Are we able to Rotate. Set to hold down the right mouse Button.
        {
            float rotateX = Input.GetAxisRaw("Mouse X");
            float rotateY = Input.GetAxisRaw("Mouse Y");

            Vector3 eularAngle = new Vector3(0, rotateX, 0);
            transform.parent.eulerAngles += eularAngle * rotateSpeed * Time.deltaTime;
            transform.eulerAngles += new Vector3(rotateY, 0, 0) * rotateSpeed * Time.deltaTime;
        }

        if (mouseZoom != 0)
            transform.parent.transform.position += transform.forward * mouseZoom * zoomSpeed;

        transform.parent.Translate(movement.normalized * moveSpeed * Time.deltaTime, Space.Self);
	}
}
