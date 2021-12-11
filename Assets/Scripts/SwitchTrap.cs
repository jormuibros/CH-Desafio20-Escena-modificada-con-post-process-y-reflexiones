using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchTrap : MonoBehaviour
{
    [SerializeField] private UnityEvent onSwitchTrap;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.CompareTag("Player"));
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("DESACTIVAR TRAMPA");
            onSwitchTrap?.Invoke();
        }
    }
}
