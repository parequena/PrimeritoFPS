using UnityEngine;

public class WeaponCtol : MonoBehaviour
{

    public int selectedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0) // Scroll up.
        {
            if (++selectedWeapon >= transform.childCount)
                selectedWeapon = 0;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0) // Scroll down.
        {
            if (--selectedWeapon <= 0)
                selectedWeapon = transform.childCount - 1;
        }

        // And take the selected weapon.
        selectWeapon();
    }

    void selectWeapon()
    {
        var currWeapon = 0;

        foreach (Transform weap in transform)
        {
            weap.gameObject.SetActive(currWeapon == selectedWeapon); // Enable just the selected weapon.
            ++currWeapon;
        }
    }
}
