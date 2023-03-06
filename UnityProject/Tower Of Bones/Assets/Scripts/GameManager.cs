using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreUI;
    private float score;

    public void AddScore(float score)
    {
        this.score += score;
		this.score = Mathf.Round(this.score * 100f) / 100f;
		scoreUI.text = "$" + this.score;
    }
}
