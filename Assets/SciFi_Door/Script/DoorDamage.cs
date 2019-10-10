using UnityEngine;

public class DoorDamage : MonoBehaviour
{
    public Door m_door;
    public float m_damage;
    private GameObject m_player;
    // Start is called before the first frame update
    private void Start()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == m_player && m_door.DoorState == Door.State.CLOSING)
        {
            m_player.SendMessage("Damage", m_damage);
        }
    }
}