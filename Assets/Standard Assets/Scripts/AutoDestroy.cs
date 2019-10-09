using UnityEngine;
using System.Collections;

/// <summary>
/// Script encargado de la autodestrucción del GameObject que lo tiene como componente
/// Permite especificar un tiempo de delay para la destrucción
/// </summary>
public class AutoDestroy : MonoBehaviour
{
    /// <summary>
    /// Delay para la destrucción del objeto
    /// </summary>
    public float m_Delay = 3;

    /// <summary>
    /// En el start, simplemente hacemos una llamada a la función que destruye el objeto con un delay determinado 
    /// </summary> 
    void Start ()
    {
        // ## TO-DO 1 - Llamada a la función Destroy, pasandole un puntero a mi mismo (gameObject) y un delay ##
        Destroy(gameObject, m_Delay);
    }
}
