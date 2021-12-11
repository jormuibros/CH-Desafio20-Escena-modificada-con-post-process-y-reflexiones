using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called before the first frame update

     private  Stack inventoryOne;
     private  Queue inventoryTwo;
     private  Queue inventoryThree;
     Dictionary<string, GameObject> inventoryFour;

     [SerializeField] private int[] foodQuantity = {0, 0, 0, 0};

    void Start()
    {
        inventoryOne = new Stack();
        inventoryTwo = new Queue();
        inventoryThree = new Queue();
        inventoryFour = new Dictionary<string, GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountFood(GameObject food)
    {
        FoodController f = food.GetComponent<FoodController>();
        switch (f.GetTypeFood())
        {
            case GameManager.typesFood.Apple:
                foodQuantity[0]++;
                break;
            case GameManager.typesFood.Watermelon:
                foodQuantity[1]++;
                break;
            case GameManager.typesFood.Peach:
                foodQuantity[2]++;
                break;
            case GameManager.typesFood.Gold:
                foodQuantity[3]++;
                break;
            default:
                Debug.Log("NO SE PUEDE CONTAR");
                break;
        }
    }

    public int[] GetFoodQuantity()
    {
        return foodQuantity;
    }

    public void AddInventoryOne(GameObject item)
    {
        inventoryOne.Push(item);
    }

    public GameObject GetInventoryOne()
    {
        return inventoryOne.Pop() as GameObject;
    }

    public void SeeInventoryOne()
    {
        Debug.Log(inventoryOne.ToString());
        foreach (var item in inventoryOne)
        {
            Debug.Log(item.ToString());
        }
    }

    public bool InventoryOneHas()
    {
        return inventoryOne.Count > 0;
    }
    //-------------------------- INVENTORY QUEQUE -------------------------//
    public void AddInventoryTwo(GameObject item)
    {
        inventoryTwo.Enqueue(item);
    }

    public GameObject GetInventoryTwo()
    {
        return inventoryTwo.Dequeue() as GameObject;
    }

    public void SeeInventoryTwo()
    {
        Debug.Log(inventoryTwo.ToString());
        foreach (var item in inventoryTwo)
        {
            Debug.Log(item.ToString());
        }
    }

    public bool InventoryTwoHas()
    {
        return inventoryTwo.Count> 0;
    }

      public void AddInventoryThree(GameObject item)
    {
        inventoryThree.Enqueue(item);
    }

    public GameObject GetInventoryThree()
    {
        return inventoryThree.Dequeue() as GameObject;
    }

    public void SeeInventoryThree()
    {
        Debug.Log(inventoryThree.ToString());
        foreach (var item in inventoryThree)
        {
            Debug.Log(item.ToString());
        }
    }

    public bool InventoryThreeHas()
    {
        return inventoryThree.Count> 0;
    }

    //-------------------------- INVENTORY DIC -------------------------//
    public void AddInventoryFour(string key,GameObject item)
    {
        inventoryFour.Add(key, item);
    }

    public GameObject GetInventoryFour(string key)
    {
        return inventoryFour[key] as GameObject;
    }

    public void SeeInventoryFour()
    {
        Debug.Log(inventoryFour.ToString());
        foreach (var item in inventoryFour)
        {
            Debug.Log(item.ToString());
        }
    }
 
    public bool InventoryFourHas()
    {
        return inventoryThree.Count > 0;
    }
}