using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon
{
    public void Shoot(GameObject obj)
    {
        Debug.Log("화살 공격");

        Vector3 initPos = new Vector3(transform.position.x, transform.position.y, 0);
        GameObject bullet = Instantiate(obj);
        bullet.transform.position = initPos;
    }
}
