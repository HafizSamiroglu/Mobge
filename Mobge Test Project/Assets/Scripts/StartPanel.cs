using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPanel : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Oyun sadece bilgisyarda denendiginden touch yerine key kullanilmistir.
       /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Time.timeScale = 1f;
            Panel.SetActive(false);
        } */ 
        if (Input.anyKey)
        {

            Time.timeScale = 1f;
            Panel.SetActive(false);
        }
    }
}
