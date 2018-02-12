using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RobotControls : MonoBehaviour
{ 
    public Transform Player;
    int MoveSpeed = 1;
    //int MaxDist = 10;
    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;

       
    }
}