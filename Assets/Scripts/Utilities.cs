using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {

    public static Vector3 CheckDistance(GameObject self, GameObject target)
    {
        return target.transform.position - self.transform.position;
    }

    public static GameObject ShootRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //Ray
        RaycastHit hit = new RaycastHit();                              //Raycast hit that stores the Info of what it hit
        Physics.Raycast(ray.origin, ray.direction, out hit);            //Actual Casting of the ray

        return hit.transform.gameObject;    //Return the GameObject
    }
}
