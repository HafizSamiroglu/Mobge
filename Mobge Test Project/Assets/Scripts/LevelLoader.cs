using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    
    [SerializeField]
    int LevelNum=0;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Car1")
        {
            SceneManager.LoadScene(LevelNum) ;
           
            
        }
    }
}
