using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;

public class ChangeSliderValues : MonoBehaviour {

    public Slider slider;
    public Damageable att;
	
	// Update is called once per frame
	void Update () {
        slider.value = att.health;
	}
}
