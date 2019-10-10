using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public AudioClip m_deathSound;

    private AudioSource m_audio;
    private GameObject m_GameManager;
    public GameObject m_spawnPoint;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
        // TO-DO 1 Buscar al GameManager y cachearlo
    }

    public virtual void OnDeath()
    {
        Debug.Log("DEAD");
        m_audio.clip = m_deathSound;
        m_audio.Play();

        // var spawn_point = m_spawnPoint.transform.position;
        // var sp2 = new Vector3(spawn_point.x, spawn_point.y, spawn_point.z);
        // transform.position = sp2;
        // transform.position = m_spawnPoint.transform.position; // Return to spawn

        var spawn_point = m_spawnPoint.transform.position;
        var characterCtrl = GetComponent<CharacterController>();
        characterCtrl.enabled = false;
        transform.position = spawn_point;
        characterCtrl.enabled = true;

        // TO-DO 2 Respaunear usando el GameManager con el mensaje RespawnPlayer.
    }
}
