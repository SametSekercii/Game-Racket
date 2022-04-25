using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIRacket : Raketler
{
    public Transform Topunyeri;
    //public int AIRacketms = 3.5f;
    public int score { get; private set; }
    public Text AIscore;

    protected override void Hareket()
    {
        float mesafe=Mathf.Abs(Topunyeri.position.y-transform.position.y);

        if (mesafe > 3.5f)
        {
            if (Topunyeri.position.y > transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0,1)*5; 
            }

            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1)*5;

            }
        }     



    }

    public override void ScoreYap()
    {
        score++;
        AIscore.text=score.ToString();

}
}
