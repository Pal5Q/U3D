using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class musiccontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
        m_audiosource = GetComponent<AudioSource>();
	}
    AudioSource m_audiosource;
    public AudioClip bjyy;
    void OnGUI()
    {
        if (GUI.Button(new Rect(50, 50, 50, 30), Time.timeScale == 1 ? "暂停" : "恢复"))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }

        GUI.Label(new Rect(50, 20, 120, 30), "当前timeScale:" + Time.timeScale.ToString());

        //if (GUI.Button(new Rect(50, 90, 95, 30), m_audiosource.isPlaying? "背景音乐 - 关" : "背景音乐 - 开"))
        //{
        //    if (m_audiosource.isPlaying)
        //        m_audiosource.PlayOneShot(bjyy);
        //    else
        //        m_audiosource.Stop();
        //}

        if (GUI.Button(new Rect(50, 80, 95, 30), Time.timeScale == 1 ? "2倍加速" : "1倍加速"))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 2;
            else
                Time.timeScale = 1;
        }
    }
    float audiodelaytime = 50;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && audiodelaytime < 0)
        {
            m_audiosource.Play();
            audiodelaytime = 50;
        }
        audiodelaytime -=1;
	}
}
