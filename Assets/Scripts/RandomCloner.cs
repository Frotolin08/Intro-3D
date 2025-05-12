using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public int randomNumber;
    public int min = 0;
    public int max = 3;
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max);
        switch (randomNumber)
        {
            case 0:
                Instantiate(cubePrefab);
                break;
            case 1:
                Instantiate(spherePrefab);
                break;
            case 2:
                Instantiate(cylinderPrefab);
                break;
        }
    }
}
