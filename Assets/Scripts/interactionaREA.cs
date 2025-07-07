using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionaREA : MonoBehaviour
{
    public GameObject interactionMsg;
    public GameObject Caja;
    public ScoreManager scoreManager;
    public MercaderiaScript mercaderiaScript;
    // Start is called before the first frame update
    void Start()
    {
        interactionMsg.SetActive(false);
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<MercaderiaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Caja)
            {
                scoreManager.AddScore(mercaderiaScript.scorePoints);
                Destroy(Caja.gameObject);
                
                StopInteraction();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        Caja = other.gameObject;
        if (Caja)
        { interactionMsg.SetActive(true); }

    }
    private void OnTriggerExit(Collider other)
    {

        StopInteraction();

    }
    void StopInteraction()
        {
             interactionMsg.SetActive(false);
        Caja = null;
        }
      
}
