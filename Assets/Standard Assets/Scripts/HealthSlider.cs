using UnityEngine;
using System.Collections;

public class HealthSlider : MonoBehaviour {


    public Health m_health;

    private UnityEngine.UI.Slider m_slider;

	// Use this for initialization
	void Start () {

        //TO-DO 1 Cargar HealthSlider y configurarlo con valores por defecto
        m_slider = GetComponent<UnityEngine.UI.Slider>();
        if (m_slider != null)
        {
            m_slider.minValue = 0f;
            m_slider.maxValue = m_health.m_health;
            m_slider.value = m_health.m_health;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        //TO-DO 2 leer el valor del health actual
        m_slider.value = m_health.CurrentHelth;
    }
}
