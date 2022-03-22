using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody enemyRB;
    public float speed = 5.0f;
    public float startTime = 1.0f;
    public float posChangeInterval = 2.0f;
    private bool isForward = false, isLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        InvokeRepeating("MoveForward", startTime, posChangeInterval);
        startTime++;
        InvokeRepeating("MoveRight", startTime, posChangeInterval);
        startTime++;
        InvokeRepeating("MoveLeft", startTime, posChangeInterval);
        startTime++;
        InvokeRepeating("MoveBack", startTime, posChangeInterval);
    }

    void MoveForward()
    {
        isForward = true;
        enemyRB.AddForce(Vector3.down * speed, ForceMode.Force);
    }

    void MoveBack()
    {
        isForward = false;
        enemyRB.AddForce(Vector3.up * speed, ForceMode.Force);
    }

    void MoveLeft()
    {
        isLeft = true;
        enemyRB.AddForce(Vector3.left * speed, ForceMode.Force);
    }

    void MoveRight()
    {
        isLeft = false;
        enemyRB.AddForce(Vector3.right * speed, ForceMode.Force);
    }
}
