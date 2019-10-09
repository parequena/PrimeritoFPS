using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Clase que gestiona el cambio de arma del jugador.
// En función de las teclas pulsadas por el usuario
// permite a éste alternar entre las armas disponibles
public class WeaponManager : MonoBehaviour {
	
	
	/// <summary>
	/// Variable pública que contiene referencias a las armas del player
	/// El orden en el que se asignan corresponde al número de tecla que le corresponde
	/// </summary>
	public List<GameObject> m_Weapons;
	
	/// <summary>
	/// Variable privada que contiene el arma activa en cada momento
	/// </summary>
	private GameObject m_ActiveWeapon;
	
	/// <summary>
	/// Índice del arma por defecto en el manager
	/// </summary>
	public int m_DefaultWeaponIndex = 0;
	
	/// <summary>
	/// Ininicializaciones
	/// </summary>
	void Start () {

        // ## TO-DO 1 - Activar el primer arma de la lista, y establecerlo como arma activa. Pista: m_Weapons[0] ##

    }
	
	// En el método Update estaremos leyendo de la entrada de usuario para ver qué tecla
	// se pulsa. En caso de ser alguna numérica, gestionaremos las armas, teniendo cuidado
	// de que sólo haya un arma activa en cada momento
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
            // ## TO-DO 3 - Llamar a ManageWeapon con el índice adecuado (0)

        }
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
            // ## TO-DO 4 - Llamar a ManageWeapon con el índice adecuado (1)

        }
    }

    // Dicho número indicará el índice del arma que se quiere activar/desacivar
    void ManageWeapon(int index)
    {
        // ## TO-DO 2
        // Activar el arma correspondiente (sólo si la que se quiere activar, NO es la activa)
        // Pista: m_Weapons[index]
        // ---
        // Desactivar el que estaba activo
        // Pista: Activar/Desactivar = m_ActiveWeapon.SetActiveRec...
        // ---
        // Actualizar m_ActiveWeapon


    }
}
