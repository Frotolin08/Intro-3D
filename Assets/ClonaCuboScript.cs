using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCuboScript : MonoBehaviour
{
    public GameObject cuboPrefab;
    // Start is called before the first frame update
    void Start()
    {
        ClonarCubo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ClonarCubo()
    {
        Instantiate(cuboPrefab);

    }
}
