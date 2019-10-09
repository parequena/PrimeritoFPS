using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public float m_health;
    private float m_CurrentHealth;

    // Use this for initialization


    void Start () {
        ResetHelth();
    }

    public float CurrentHelth
    {
        get { return m_CurrentHealth; }
    }

    public void ResetHelth()
	{
        m_CurrentHealth = m_health;
    }

    /// <summary>
    /// Mensaje que aplica el daño y lanza el mensaje OnDeath cuando la salud es menor que 0.
    /// </summary>
    /// <param name="amount"></param>
    public void Damage(float amount)
    {

        ///  // ## TO-DO 1 si la salud inicial es menor que 0 enviar mensaje void OnDeath() por si a alguien le interesa..


    }

}
