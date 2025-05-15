using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRespawn : MonoBehaviour
{
    public float deathHeight = -11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y< deathHeight)
        {
            Debug.Log("respawn");
            SceneManager.LoadScene("FPSParkour");

        }
    }
}
