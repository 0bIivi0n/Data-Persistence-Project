using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class MenuUIHandler : MonoBehaviour
{
   [SerializeField] Text PlayerNameInput;
   [SerializeField] Button startButton;

   void Start()
   {
        
   }

   void Update()
   {
        if(PlayerNameInput.text != "")
        {
            startButton.GetComponent<Button>().interactable = true;
        }
   }
   public void StartGame()
   {
    SceneManager.LoadScene(1);
   }

   public void SetPlayerName()
   {
    PlayerInfo.playerInfo.playerName = PlayerNameInput.text;
   }

   public void ExitGame()
   {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
   }
}
