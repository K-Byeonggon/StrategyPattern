using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon
{
    //접근점을 가져와서 어쩌고 저쩌고? 전략패턴?

    private IWeapon weapon;

    public void SetWeapon(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void Shoot(GameObject obj)
    {
        weapon.Shoot(obj);
    }
}
