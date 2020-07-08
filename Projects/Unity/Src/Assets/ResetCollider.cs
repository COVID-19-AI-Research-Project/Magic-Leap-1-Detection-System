using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCollider : MonoBehaviour
{
    string[] materials = {
            "Covid (10)",
            "Covid (76)",
            "Covid (156)",
            "Covid (356)",
            "Covid (675)",
            "Non-Covid (1)",
            "Non-Covid (54)",
            "Non-Covid (104)",
            "Non-Covid (389)",
            "Non-Covid (582)"
    };

    void OnCollisionEnter(Collision collision)
    {
        foreach (string i in materials)
        {
            GameObject dataCube = GameObject.Find(i);
            dataCube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
