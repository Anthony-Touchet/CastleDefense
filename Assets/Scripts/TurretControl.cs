using UnityEngine;
using System.Collections.Generic;

public class TurretControl : MonoBehaviour {

    public float radius;                //How Far Can the Unit look for Units
    public GameObject target;           //The Enemy the Unit will be shooting at
    List<GameObject> possibleTargets;   //All the Units that can be Targeted. Must Be in Range

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        possibleTargets = new List<GameObject>();
        GameObject[] tempList = GameObject.FindGameObjectsWithTag("Enemy");
        
        foreach(GameObject go in tempList)
        {           
            if (Utilities.InRange(radius, gameObject, go))
            {
                possibleTargets.Add(go);
            }
        }

        GameObject tempTarget = null;
        float minDist = Mathf.Infinity;

        foreach(GameObject go in possibleTargets)
        {
            if(Utilities.GetDistance(go, gameObject).magnitude < minDist)
            {
                minDist = Utilities.GetDistance(go, gameObject).magnitude;
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
