using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovement_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed;
    public float rotationSpeed;

    void Update()
    {
        MoveUP();
        MoveDOWN();
        RotateObject_LEFT();
        RotateObject_RIGHT();
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
}
