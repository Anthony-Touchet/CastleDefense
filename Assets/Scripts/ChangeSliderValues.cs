using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;
using System.Reflection;

public class ChangeSliderValues : MonoBehaviour {

    public string varName;
    public Component componet;
    public Slider slider;
    int result;

    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {
       
	}

    void OnValidate()
    {
        float val;
        if(int.TryParse(varName, out result) == true)
        {
            val = result;
        }

        else
        {
            val = (float)componet.GetType().GetProperty(varName).GetValue(componet, null);
        }

        slider.value = val;
    }
}
