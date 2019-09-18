using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float calories = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<FoodManager>() != null)
        {
            collision.gameObject.GetComponent<FoodManager>().weight += calories;
            Destroy(this.gameObject);
        }
    }

}
