using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public Button[] Buttons;
    void Start()
    {
        keyStstem();

    }

    
    public void keyStstem()
    {
        int levelnums = PlayerPrefs.GetInt("levelnum");
        Debug.Log(levelnums);
        for(int i =0; i < Buttons.Length; i++)
        {
            if (levelnums+1 >= int.Parse(Buttons[i].name))
            {
                Buttons[i].interactable = true;
            }
            else
            {
                Buttons[i].interactable = false;
            }
        }
    }
}
