using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Đảm bảo sử dụng thư viện TextMeshPro

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText; // Sử dụng TMP_Text thay vì Text hoặc Text_Pro

    public GameObject gameoverPanel;

    public void SetScoreText(string txt)
    {
        if (scoreText != null)
        {
            scoreText.text = txt;
        }
        else
        {
            Debug.LogWarning("Score Text is not assigned in the Inspector.");
        }
    }

    public void ShowGameoverPanel(bool isShow)
    {
        if (gameoverPanel != null)
        {
            gameoverPanel.SetActive(isShow);
        }
        else
        {
            Debug.LogWarning("Gameover Panel is not assigned in the Inspector.");
        }
    }
}
