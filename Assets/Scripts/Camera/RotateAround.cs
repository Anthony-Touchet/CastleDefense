using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

    public GameObject target;

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 0f);
    }
}
