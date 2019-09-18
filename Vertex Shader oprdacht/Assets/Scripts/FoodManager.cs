using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{
    public List<Material> mats;
    public float weight = 0;
    public Text weightDisplay;

    private void Update()
    {
        foreach(Material mat in mats)
        {
            mat.SetFloat("_Amount", weight);
        }

        if(weight > 0)
        {
            weight -= Time.deltaTime/2;
        }
        if(weight < 0)
        {
            weight = 0;
        }
        weightDisplay.text = "Weight: "+weight;
    }

}
