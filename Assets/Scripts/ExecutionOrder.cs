using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    void Awake()
    {



        Debug.Log("Awake");
    }
    void Start()
    {
        Debug.Log("start");        
    }
    void Update()
    {
        Debug.Log("update");
    }
    void FixedUpdate()
    {
        Debug.Log("fixedUpdate");
    }
    void OnEnable()
    {
        Debug.Log("onEable");

    }
}
