using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] Transform _parentTransform;
    int _inventorySize;

    private void Start()
    {
        _inventorySize = _parentTransform.childCount;
    }
    public bool HasWeapon()
    {

        if (_inventorySize<=0)
        {
            GameManager.Instance.OnGameOver?.Invoke();
            return false;
        }

        RemoveWeapon();

        return true;
    }

    private void RemoveWeapon()
    {
        _inventorySize--;
        _parentTransform.GetChild(_inventorySize).GetComponent<Image>().color = Color.black;
    }
}
