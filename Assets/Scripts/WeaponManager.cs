using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Bullet,
    Misile,
    Arrow
}

public class WeaponManager : MonoBehaviour
{
    public GameObject arrow;
    public GameObject bullet;
    public GameObject misile;

    private GameObject myWeapon;
    private IWeapon iweapon;

    // Start is called before the first frame update
    void Start()
    {
        SetWeaponType(WeaponType.Bullet);
    }

    public void ChangeBullet()
    {
        SetWeaponType(WeaponType.Bullet);
    }

    public void ChangeMisile()
    {
        SetWeaponType(WeaponType.Misile);
    }

    public void ChangeArrow()
    {
        SetWeaponType(WeaponType.Arrow);
    }

    private void SetWeaponType(WeaponType weaponType)
    {
        Component c = gameObject.GetComponent<IWeapon>() as Component;  //명시적 캐스팅

        if (c != null) { Destroy(c); }
        switch (weaponType)
        {
            case WeaponType.Bullet:
                iweapon = gameObject.AddComponent<Bullet>();
                myWeapon = bullet;
                break;
            case WeaponType.Misile:
                iweapon = gameObject.AddComponent<Misile>();
                myWeapon = misile;
                break;
            case WeaponType.Arrow:
                iweapon = gameObject.AddComponent<Arrow>();
                myWeapon = arrow;
                break;
        }
    }

    public void Fire()
    {
        iweapon.Shoot(myWeapon);
    }
}
