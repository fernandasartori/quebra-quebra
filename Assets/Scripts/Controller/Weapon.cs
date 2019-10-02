using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected VRInteractiveItem m_InteractiveItem;

    Rigidbody _rb;

    void Start()
    {
        if (m_InteractiveItem == null)
        {
            m_InteractiveItem = GetComponent<VRInteractiveItem>();
        } else
        {
            _rb = GetComponent<Rigidbody>();
        }
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleOver;
    }

    private void OnDisable()
    {
        m_InteractiveItem.OnClick -= HandleOver;
    }

    void HandleOver()
    {
        _rb.AddForce(0, 1, -5, ForceMode.Impulse);
    }
}
