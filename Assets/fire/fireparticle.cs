using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireparticle : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        ParticleSystem.Emit(1);
    }
}
