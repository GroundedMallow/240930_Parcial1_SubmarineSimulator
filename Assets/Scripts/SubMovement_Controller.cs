using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovement_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed;
    public float rotationSpeed;

    [SerializeField] public bool isPowered; //use for detection
    [SerializeField] private bool noPower;
    public Transform submarinePosition;

    //power mechanic
    [SerializeField] private float currentPower;
    [SerializeField] private float maxPower;

    private void Start()
    {
        isPowered = false;
        currentPower = maxPower;

        noPower = false;
    }

    void Update()
    {

        if (isPowered && currentPower > 0) //move sub forward while power is on
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            currentPower -= 10 * Time.deltaTime;
        }
        else
        {
            noPower = true;
            isPowered = false;
        }
        
        //check y position
        Debug.Log("Submarine Height =" + submarinePosition.position.y.ToString());
    }

    public void MoveUP()
    {
            //move transform y along y axis UP
            transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    public void MoveDOWN()
    {
            //move transform y along y axis DOWN
            transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void RotateObject_LEFT()
    {
        //rotate along Y axis 
        transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);  
    }
    public void RotateObject_RIGHT()
    {
        //rotate along Y axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }

    public void TurnPowerON()
    {
        isPowered = !isPowered;
    }

    public void RefillPower()
    {
        currentPower += 10 * Time.deltaTime;
        noPower = false;

        if(currentPower > maxPower)
        {
            currentPower = maxPower;
        }
    }
}
