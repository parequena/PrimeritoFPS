using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Esta clase se encarga de guardar información relevante sobre la lógica
/// y progreso del juego. Deberá estar siempre disponble, por lo que el usuario
/// se tiene que asegurar de que este componente nunca sea eliminado de la escena
/// </summary>
public class GameManager : MonoBehaviour {
	

	
	#region Exposed Fields
	
	/// <summary>
	/// Punto de spawn inicial
	/// </summary>
	public Transform m_InitialSpawnPoint;
	
	/// <summary>
	/// ¿Quién es el jugador?
	/// </summary>
	private CharacterController m_Player;
	
	
	
	#endregion
	
	#region Non-Exposed Fields
	
	/// <summary>
	/// Actual punto de spawn. 
	/// Durante el juego el punto de spawn puede variar (en función de los 
	/// niveles que hayamos desbloqueado)
	/// </summary>
	private Transform m_CurrentSpawnPoint;
	


	#endregion
	
	void Awake()
	{
		if(!m_InitialSpawnPoint)
			Debug.LogWarning("No se ha asignado un punto de spawn inicial");
		
		// Al principio, el punto incial será el punto actual de spawn
		m_CurrentSpawnPoint = m_InitialSpawnPoint;
		

    }

	/// <summary>
	/// Inicialización del jugador. Se recoloca en el escenario
	/// </summary>
	void Start () {

        // ## TO-DO 1 - Buscar al player y guardarlo en m_Player.

        RespawnPlayer();
	}
	
	/// <summary>
	/// Desde fuera pueden configurar el punto de spawn
	/// </summary>
	/// <param name="current">
	/// Nuevo punto de spawn <see cref="Transform"/>
	/// </param>
	public void SetCurrentSpawnPoint(Transform current)
	{
		m_CurrentSpawnPoint = current;	
	}
	
	/// <summary>
	/// Desde fuera nos pueden pedir el punto de spawn
	/// </summary>
	/// <returns>
	/// Actual punto de spawn <see cref="Transform"/>
	/// </returns>
	public Transform GetCurrentSpawnPoint()
	{
		return m_CurrentSpawnPoint;
	}
	
	/// <summary>
	/// Esta función setea la posición del player, haciéndola coincidir
	/// con la posición del punto de spawn actual
	/// </summary>
	public void RespawnPlayer()
	{
        // Colocamos al player en el punto de spawn actual
        // ## TO-DO 2 - Teletransportar al player al ultimo punto de reespawn y reestaurar su vida. Activar y desactivar el Character Contorller para que este no restee la posición.

    }
	
	
}
