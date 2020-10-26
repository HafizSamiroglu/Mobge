using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLoader : MonoBehaviour
{
    [SerializeField]
    int LevelNum = 0;
    public void levelOpen(int level_num)
    {
        Application.LoadLevel(level_num);
    }
    public void LastLevel()
    {

        PlayerPrefs.SetInt("levelnum", Application.loadedLevel);
        Application.LoadLevel(LevelNum);
    }
}
