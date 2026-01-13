using System;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class SphereMovement : MonoBehaviour
{
    public float WaitTime = 2;
    public float Speed;
    public float Min_X;
    public float Max_X;
    public float dir = 1;
    public float count;
    
    void Update()
    {
        if (transform.position.x > Max_X || transform.position.x < Min_X)
        {
            count += Time.deltaTime;
            if (count >= WaitTime)
            {
                dir *= -1;
                count = 0;
                transform.position += new Vector3(10 * dir * Speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            transform.position += new Vector3(dir * Speed * Time.deltaTime, 0, 0);
        }
        //Debug.Log(Time.time)
    }
}