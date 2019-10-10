using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public float m_health;
    private float m_CurrentHealth;
    public Death m_death;

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
        m_CurrentHealth -= amount;
        // m_health = m_CurrentHealth;
        Debug.Log("Damaged: " + m_CurrentHealth);
        ///  // ## TO-DO 1 si la salud inicial es menor que 0 enviar mensaje void OnDeath() por si a alguien le interesa..

        if(m_CurrentHealth <= 0)
        {
            gameObject.SendMessage("OnDeath");
        }
    }


}
