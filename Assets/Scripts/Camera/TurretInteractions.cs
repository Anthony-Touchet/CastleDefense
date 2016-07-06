using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurretInteractions : MonoBehaviour {

    public RotateAround displayCamera;

    [SerializeField]
    private RawImage targetSights;  //Targeting Image
    bool clicked = false;    //Prevents Multiple rays from firing on one click.
    [HideInInspector]
    public GameObject currentTarget;

    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {

        targetSights.transform.position = Input.mousePosition;  //Set the Target's transform

        if (Input.GetAxisRaw("Fire1") == 1 && clicked == false) //If the Button is being held and we can click it
        {
            LeaveCurrentUnit();
            currentTarget = Utilities.ShootRay();   //Fire Ray and reutrn the GameObject
            displayCamera.target = currentTarget;
            LookingAtUnit();
            clicked = true;                         //Prevents Multiple RayCasts from one click
        }
        
        else if (Input.GetAxisRaw("Fire1") == 0)    //Once we let go of the Mouse
            clicked = false;                        //Able to click again
    }

    void LookingAtUnit()
    {
        if (currentTarget.CompareTag("Turret"))
        {
            
            SetCanvasActive(true);
        }
    }

    void LeaveCurrentUnit()
    {
        if(currentTarget != null && currentTarget.CompareTag("Turret"))
        {
            SetCanvasActive(false);
        }
    }

    void SetCanvasActive(bool active)
    {
        currentTarget.transform.FindChild("Canvas").gameObject.SetActive(active);
    }
}
