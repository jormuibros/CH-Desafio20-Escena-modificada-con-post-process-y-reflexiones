using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDController : MonoBehaviour
{
    [SerializeField] private Text textPeach;
    [SerializeField] private Text textWatermelon;
    [SerializeField] private Text textApple;
    [SerializeField] private Text textGold;
    [SerializeField] private TextMeshProUGUI textLives;

    [SerializeField] private TextMeshProUGUI textScore;

    [SerializeField]  private InventoryManager mgInventory;
    [SerializeField]  private GameObject panelItems;

    

    // Start is called before the first frame update
    
    void Awake()
    {
       PlayerController.onLivesChange += onLivesChangeHandler;
       GameManager.onPointsInScreen += onUpdateScoreHandler;
    }
    
    void Start()
    {
        
    }

    public void onLivesChangeHandler(int health)
    {
        textLives.text = "HP " + health;
    }

    public void onUpdateScoreHandler(int points)
    {
        textScore.text = "Score " + points;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFoodUI();
    }

     void UpdateFoodUI()
    {
        int[] foodCount = mgInventory.GetFoodQuantity();
        textPeach.text = "x"+foodCount[0];
        textWatermelon.text = "x"+foodCount[1];
        textApple.text = "x"+foodCount[2];
        textGold.text = "x"+foodCount[3];
    }

    public void TooglePanel()
    {
        panelItems.SetActive(!panelItems.activeSelf);
    }
}
