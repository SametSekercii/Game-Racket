using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRacket : Raketler
{
    string OKTuslari= "OKTuslari";
    public float ms = 10;
    public Text HumanScore;

    public int score { get; private set; }
    protected override void Hareket()
    {
        float HareketKomutu = Input.GetAxis(OKTuslari)*ms;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, HareketKomutu);
        
    }
    public override void ScoreYap()
    {
        score++;
        HumanScore.text = score.ToString();

    }
}
