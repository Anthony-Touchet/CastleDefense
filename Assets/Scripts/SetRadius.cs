using UnityEngine;
using System.Collections;

public class SetRadius : MonoBehaviour {

	// Use this for initialization
	void Update () {
        float newRadius = transform.parent.transform.parent.gameObject.GetComponent<TurretControl>().radius * 0.01f;
        GetComponent<RectTransform>().localScale = new Vector3(newRadius, newRadius, 1);	
	}
}
