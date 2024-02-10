using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Weapon weapon;
    [SerializeField] Transform positionToSpawn;
    [SerializeField] Inventory inventory;

    private void Update()
    {
        GenerateWeapon();
    }

    private void GenerateWeapon()
    {
        if (Input.GetMouseButtonDown(0) && inventory.HasWeapon())
        {
            Instantiate(weapon, positionToSpawn.position, Quaternion.identity).Throw();
        }
    }
}
