using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteRenderer shipColorRenderer;
    public float spaceShipStartSpeed;
    [Range(-100, 100)]
    public int spaceShipRotationSpeed;
    [Range(-100, 100)]
    public float timer;
    public float timerPrint;

    // Use this for initialization
    void Start()
    {
        spaceShipStartSpeed = Random.Range(7, 18);

        spaceShipRotationSpeed = Random.Range(190, 230);

    }

    // Update is called once per frame
    void Update()
    {
        //Ship is in constant speed
        transform.Translate(spaceShipStartSpeed * Time.deltaTime, 0, 0);

        //When Player holds down D, rotate ship to the right and change color to blue
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -222  * Time.deltaTime);
            shipColorRenderer.color = new Color(0f, 0f, 1f);

        }
        //When Player holds down A, rotate ship to the left and change color to green
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, (spaceShipRotationSpeed - 10) * Time.deltaTime);
            shipColorRenderer.color = new Color(0f, 1f, 0f);
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
        timer += 1 * Time.deltaTime;
        timerPrint += 1 * Time.deltaTime;

        if (timerPrint >= 1)
        {
            print(string.Format("Timer:" + timer));
            timerPrint = 0;
        }

        timerPrint = timerPrint + 1 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shipColorRenderer.color = new Color(Random.Range(0f, 2f), Random.Range(0f, 2f), Random.Range(0f, 2f));
        }
        if (transform.position.x <= -12)
        {
            transform.position = new Vector3(11.9f, transform.position.y);
        }
        if (transform.position.x >= 11.9)
        {
            transform.position = new Vector3(-12f, transform.position.y);
        }
        if (transform.position.y <= -8.7)
        {
            transform.position = new Vector3(transform.position.x, 8.7f);
        }
        if (transform.position.y >= 8.7)
        {
            transform.position = new Vector3(transform.position.x, -8.7f);
        }

    }
}
