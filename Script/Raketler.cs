using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Raketler : MonoBehaviour
{
      
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Hareket();
    }

    protected abstract void Hareket();
    public abstract void ScoreYap();
}
