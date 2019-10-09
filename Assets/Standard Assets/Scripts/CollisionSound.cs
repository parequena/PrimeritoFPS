using UnityEngine;
using System.Collections;

// Esta clase se encarga de reproducir un sonido cuando el GameObject
// padre colisiona contra cualquier objeto
public class CollisionSound : MonoBehaviour
{
    /// <summary>
    /// AudioClip público. Será el sonido que se reproducirá cuando el GameObject colisione
    /// </summary>
    public AudioClip m_CollisionSound;
    // Esta función se llama cada vez que el objeto colisiona contra algún objeto
    // ## TO-DO 1.1 - Añadir la función de la API que se lanza cada vez que el GameObject colisiona. Pista: OnCollisi...

    // ## TO- DO 1.2 - En caso de que haya sonido, reproducirlo una única vez. Pista: audio.PlayOne...

    void OnCollisionEnter()
    {
        // ## TO- DO 1.2 - En caso de que haya sonido, reproducirlo una única
        if (m_CollisionSound != null)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(m_CollisionSound);
        }
    }
}
