using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Recorder : MonoBehaviour
{
    public GameObject CrashPanel;
    [SerializeField]
    int level=0;
    public AnimationClip clip;
    private bool crash= false;

    private GameObjectRecorder m_Recorder;
    
    void Start()
    {
        CrashPanel.SetActive(false);
        m_Recorder = new GameObjectRecorder(gameObject);
        crash = false;
        m_Recorder.BindComponentsOfType<Transform>(gameObject, true);
    }

    void LateUpdate()
    {
        if (clip == null)
            return;
        m_Recorder.TakeSnapshot(Time.deltaTime);

       
        
    }

    void OnDisable()
    {
        if (clip == null)
            return;

        if (m_Recorder.isRecording && crash==false)
        {
            m_Recorder.SaveToClip(clip);
            
        }
        else clip.ClearCurves();
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car1" || collision.gameObject.tag == "Ev")
        {
            crash = true;
            CrashPanel.SetActive(true);
            Time.timeScale = 0f;
          
        }
    }
    public void restart()
    {

        SceneManager.LoadScene(level);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
