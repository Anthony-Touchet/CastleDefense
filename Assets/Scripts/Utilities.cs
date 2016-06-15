using UnityEngine;
using System.Collections.Generic;

public class Utilities : MonoBehaviour {

    public delegate bool Conditional<T>(T a);

    public static bool InRange(float radi, GameObject self, GameObject target)  //If They are In Range, Return true
    {
        if (target.transform.position.x >= self.transform.position.x - radi && target.transform.position.x <= self.transform.position.x + radi)
            if (target.transform.position.y >= self.transform.position.y - radi && target.transform.position.y <= self.transform.position.y + radi)
                return true;
        return false;
    }

    public static Vector3 GetDistance(GameObject self, GameObject target)
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
