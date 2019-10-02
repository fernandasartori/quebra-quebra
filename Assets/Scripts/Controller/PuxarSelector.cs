using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using VRStandardAssets.Menu;

public class PuxarSelector : MonoBehaviour
{
    [SerializeField] protected VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.
    
    // Start is called before the first frame update
    void Start()
    {
        if (m_InteractiveItem == null)
            m_InteractiveItem = GetComponent<VRInteractiveItem>();
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
    }

    void HandleOver()
    {
        print("testando o puxar");
        if (Vector3.Distance(transform.position, Camera.main.transform.position) < 2)
        {
            transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2;
        }
        else
           transform.position += (Camera.main.transform.position - transform.position) * 0.8f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
