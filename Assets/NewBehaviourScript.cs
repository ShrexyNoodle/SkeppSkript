using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteRenderer rend;
    public float spaceShipStartSpeed;
    [Range(-100, 100)]
    public float spaceShipRotationSpeedRight;
    [Range(-100, 100)]
    public float spaceShipRotationLeft;
    public float timer;
    public float timerPrint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Ship is in constant speed
        transform.Translate(spaceShipStartSpeed * Time.deltaTime, 0, 0);

        //When Player holds down D, rotate ship to the right and change color to blue
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, spaceShipRotationSpeedRight * Time.deltaTime);
            rend.color = new Color(0f, 0f, 1f);

        }
        //When Player holds down A, rotate ship to the left and change color to green
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, spaceShipRotationLeft * Time.deltaTime);
            rend.color = new Color(0f, 1f, 0f);
        }
        //When Player holds down S, reduce Ship speed by half
        if (Input.GetKeyDown(KeyCode.S))
        {
            spaceShipStartSpeed = spaceShipStartSpeed / 2;

        }
        //When Player releases S, increase Ship speed back to normal
        if (Input.GetKeyUp(KeyCode.S))
        {
            spaceShipStartSpeed = spaceShipStartSpeed * 2;
        }
        timer = timer + 1 * Time.deltaTime;

        if (timerPrint >= 1)
        {
            print(string.Format("Timer:" + timer));
            timerPrint = 0;
        }

        timerPrint = timerPrint + 1 * Time.deltaTime;
    }
}
