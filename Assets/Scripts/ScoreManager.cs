using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2Text;
    public float player1scale = 3;
    public float player2scale = 3;
    public float multiplier = 0.8f;
    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    private Vector3 currentscale;

    public void AddP1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();

        Vector3 currentscale = player1.transform.localScale;
        currentscale.y = currentscale.y - 0.35f;

        player1.transform.localScale = currentscale;
    }
    public void AddP2Score()
    {
        player2Score++;
        p2Text.text = player2Score.ToString();

        Vector3 currentscale = player2.transform.localScale;
        currentscale.y = currentscale.y - 0.35f;

        player2.transform.localScale = currentscale;
    }
    public void Update()
    {
      
    }
}