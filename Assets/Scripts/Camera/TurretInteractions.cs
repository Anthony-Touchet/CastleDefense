using UnityEngine;
using System.Collections;

public class TurretInteractions : MonoBehaviour {

    Ray ray;        //Ray
    RaycastHit hit; //Raycast hit that stores the Info of what it hit

    // Use this for initialization
    void Start () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        hit = new RaycastHit();
    }
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //Ray
        RaycastHit hit = new RaycastHit();                              //Raycast hit that stores the Info of what it hit

        if (Input.GetAxisRaw("Fire1") != 0)  //Selecting Target.
        {
            Physics.Raycast(ray.origin, ray.direction, out hit);            //Actual Casting of the ray

            Debug.Log(hit.transform.gameObject.name);
        }

        Physics.Raycast(ray.origin, ray.direction, out hit);
    }
}
