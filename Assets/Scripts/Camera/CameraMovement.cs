using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    Vector3 movement;

    public float moveSpeed;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
	  
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        movement = new Vector3();
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        float mouseZoom = Input.GetAxisRaw("Mouse ScrollWheel");

        movement = new Vector3(moveX, mouseZoom, moveZ);

        if(Input.GetAxisRaw("Fire2") != 0)
        {
            float rotateX = Input.GetAxisRaw("Mouse X");
            float rotateY = Input.GetAxisRaw("Mouse Y");

            Vector3 eularAngle = new Vector3(0, rotateX, 0);
            transform.parent.eulerAngles += eularAngle * rotateSpeed * Time.deltaTime;
            transform.eulerAngles += new Vector3(rotateY, 0, 0) * rotateSpeed * Time.deltaTime;
        }

        transform.parent.Translate(movement.normalized * moveSpeed * Time.deltaTime, Space.Self);
	}
}
