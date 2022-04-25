using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public Rigidbody2D Toprb;
    public int ms = 10;
    public Raketler AI, Human;

    

    void Start()
    {
        Toprb.velocity = new Vector2(1, 0) * ms;
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Taglar Degilenyer=collision.gameObject.GetComponent<Taglar>();
        if (Degilenyer == null) return;

        Tag CollisionTag = Degilenyer.myTag;


        

        if (CollisionTag == Tag.SagDuvar)
        {
            AI.ScoreYap();

        }
        if (CollisionTag == Tag.SolDuvar)
        {

            Human.ScoreYap();

        }
    }
}
