using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public AudioClip m_deathSound;

    private AudioSource m_audio;
    private GameObject m_GameManager;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
        // TO-DO 1 Buscar al GameManager y cachearlo
    }

    public virtual void OnDeath()
    {

        m_audio.clip = m_deathSound;
        m_audio.Play();
        // TO-DO 2 Respaunear usando el GameManager con el mensaje RespawnPlayer.
    }
}
