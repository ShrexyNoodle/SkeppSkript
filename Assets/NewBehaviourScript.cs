using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript: MonoBehaviour
{
    public int spaceShipStartSpeed;
    [Range(-100, 100)]
    public float spaceShipRotationSpeed;

    // Use this for initialization
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(spaceShipStartSpeed, 0, 0);

        if (Input.GetKey(KeyCode.D))
        { 
         

        }
        
    }
}
