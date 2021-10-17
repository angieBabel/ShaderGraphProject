using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveTrigger : MonoBehaviour
{

    public SkinnedMeshRenderer mr;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            mr.material.SetFloat("Vector1_de51b34c806c45d88a7956b684c43e44",Time.time);
        }
    }
}
