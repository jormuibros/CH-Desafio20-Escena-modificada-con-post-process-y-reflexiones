using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

    [SerializeField] GameManager.typesFood typeFood; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameManager.typesFood GetTypeFood()
    {
        return typeFood;
    }
}
