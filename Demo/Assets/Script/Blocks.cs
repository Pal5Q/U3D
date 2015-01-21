using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour
{
    private Transform m_transform;
    void Start()
    {
        m_transform = GetComponent<RectTransform>();
    }

    Vector3 offpos = new Vector3(3, 0, 0);
    public bool timeScalecontrol;
    void Update()
    {
        if (timeScalecontrol)
            m_transform.position = new Vector3(200, 200, 0) + new Vector3(60 * Mathf.Sin(Time.time * 2), 0, 0);
        else
        {
            if (m_transform.position.x < 120)
                offpos = new Vector3(3, 0, 0);
            if (m_transform.position.x > 260)
                offpos = new Vector3(-3, 0, 0);
            m_transform.position += offpos;
        }        
    }
}
