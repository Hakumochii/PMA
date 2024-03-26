using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CollectSensorData : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction accelerationAction;
    //[SerializeField] private 

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        //accelerationAction = playerInput.actions["Acceleration"];
    }

    public void CollectAcceleration()
    {
        Debug.Log("You are now collecting acceleration data. Yipieeee!");
    }
}
