using UnityEngine;
using System.Collections;

public class particle : MonoBehaviour {

	// Use this for initialization
    ParticleSystem m_particle;
    
    //public bool pause;
	void Start () {
        m_particle = GetComponent<ParticleSystem>();
        //ParticleEmitter pe = GetComponent<ParticleEmitter>();
        //pe.si
        lasttime = Time.realtimeSinceStartup;
	}
    float lasttime = 0;
    float deltatime = 0;
    public bool timeScalecontrol;
	void Update () {
        if (!timeScalecontrol)
        {
            deltatime = Time.realtimeSinceStartup - lasttime;
            m_particle.Simulate(deltatime, true, false);
        }
        else
        {
            m_particle.Simulate(Time.deltaTime, true, false);
        }
        lasttime = Time.realtimeSinceStartup;
	}
}
