using UnityEngine;
using System.Collections.Generic;

public class TurretControl : MonoBehaviour {

    public float radius;
    public GameObject target;
    List<GameObject> possibleTargets;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        possibleTargets = new List<GameObject>();
        GameObject[] tempList = GameObject.FindGameObjectsWithTag("Enemy");
        
        foreach(GameObject go in tempList)
        {
            if (CheckInRadius(go))
            {
                possibleTargets.Add(go);
            }
        }

        GameObject tempTarget = null;
        float minDist = Mathf.Infinity;

        foreach(GameObject go in possibleTargets)
        {
            if(Utilities.CheckDistance(go, gameObject).magnitude < minDist)
            {
                minDist = Utilities.CheckDistance(go, gameObject).magnitude;
                tempTarget = go;
            }
        }

        target = tempTarget;
    }

    bool CheckInRadius(GameObject target)
    {
        if (target.transform.position.x >= gameObject.transform.position.x - radius && target.transform.position.x <= gameObject.transform.position.x + radius)
            if (target.transform.position.y >= gameObject.transform.position.y - radius && target.transform.position.y <= gameObject.transform.position.y + radius)
                return true;
        return false;
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
