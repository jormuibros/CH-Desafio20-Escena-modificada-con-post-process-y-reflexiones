using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LandingController : MonoBehaviour
{
    [SerializeField] private InputField inputUsername;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     PlayerController.onDeath += onGameOverHandler; 
    }

    public void OnChangeInputUsername()
    {
        Debug.Log("CHANGE");
        Debug.Log(inputUsername.text); 
    }

    public void OnEndEditInputUsername()
    {
        Debug.Log("END EDIT");
        ProfileManager.instance.SetPlayerName(inputUsername.text);
        Debug.Log("SAVED USERNAME"+ ProfileManager.instance.GetPlayerName());
    }

    public void OnClickPlay()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void onGameOverHandler()
    {
      SceneManager.LoadScene("GameOver"); 
      Debug.Log("ASESINADO"); 
    }
}
