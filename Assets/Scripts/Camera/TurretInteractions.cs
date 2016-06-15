using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurretInteractions : MonoBehaviour {

    [SerializeField]
    private RawImage targetSights;  //Targeting Image

    public bool clicked = false;    //Prevents Multiple rays from firing on one click.
	
	// Update is called once per frame
	void Update () {

        targetSights.transform.position = Input.mousePosition;  //Set the Target's transform

        if (Input.GetAxisRaw("Fire1") == 1 && clicked == false) //If the Button is being held and we can click it
        {
            Debug.Log(Utilities.ShootRay().name);   //Fire Ray and reutrn the GameObject
            clicked = true;                         //Prevents Multiple RayCasts from one click
        }
        
        else if (Input.GetAxisRaw("Fire1") == 0)    //Once we let go of the Mouse
            clicked = false;                        //Able to click again
    }
}
