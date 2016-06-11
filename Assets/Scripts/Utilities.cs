using UnityEngine;
using System.Collections;

public class Utilities : MonoBehaviour {

    public static Vector3 CheckDistance(GameObject self, GameObject target)
    {
        return target.transform.position - self.transform.position;
    }
}
