using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    private AudioSource audioSource;
    public int maxHealthPoints;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("FirstPersonCharacter").GetComponent<AudioSource>();
        uiManager.UpdateHealth(maxHealthPoints);

        uiManager = FindObjectOfType<UIManager>();

        healthPoints = maxHealthPoints;
    }

    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <= damagePoints)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("FPS parkour");
            return;
        }
        
        healthPoints-= damagePoints;
        if (damagePoints > 0)
        {
            audioSource.Play();
            Debug.Log("Damage taken");
        }
        

        uiManager.UpdateHealth(healthPoints);
    }
 
}
