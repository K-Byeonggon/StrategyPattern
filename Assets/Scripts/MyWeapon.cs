using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon
{
    //�������� �����ͼ� ��¼�� ��¼��? ��������?

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
