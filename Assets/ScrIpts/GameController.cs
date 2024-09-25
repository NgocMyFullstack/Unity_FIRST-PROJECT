using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // lưu dữ quả bóng 
    public GameObject ball;

    // Time của quả bóng đc tạo ra
    public float spawnTime;

    // Biến để lưu dữ liêu  spawnTime
    float m_spawnTime;

    // Lưu giá trị về điểm 
    int m_score;

    // kiểm tra xem trang thái của game
    bool m_isGameover;

    // tham chiếu
    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        // điểm
        m_ui.SetScoreText("Score: "+m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        // kiểm tra trò chs kết thúc
        if(m_isGameover)
        {
            m_spawnTime = 0;
            m_ui.ShowGameoverPanel(true);
            return ;
        }

        // thời gian bóng rơi
        if(m_spawnTime <= 0)
        {
            SpawnBall();
            // không có hàm này nó in ra không ngừng
            m_spawnTime = spawnTime;
        }
    }
    // Phuong thức chs lại
    public void Replay(){
        m_score = 0;
        m_isGameover = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameoverPanel(false);
    }
    // tạo ra quả bóng
    public void SpawnBall()
    {
        Vector2 spawnpos = new Vector2(Random.Range(-7,7),6);
        if(ball)
        {
            Instantiate(ball, spawnpos, Quaternion.identity);
        }
    } 

    //get 
    public void SetScore(int value)
    {
        m_score = value;
    }
    
    // set
    public int GetScore()
    {
        return m_score;
    }

    // hàm tính điểm
    public void IncrementScore()
    {
        m_score++;
        // tham chiếu 
        m_ui.SetScoreText("Score" + m_score);
    }
    // 
    public bool IsGameover()
    {
        return m_isGameover;
    }

    // 
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }

}
