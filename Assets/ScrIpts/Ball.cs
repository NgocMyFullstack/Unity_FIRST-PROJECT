using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    // tính điểm bóng 
    private void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("Player"))
        {
            // tính điểm
            m_gc.IncrementScore();
            // quả bóng rơi vào rỗ thì biến mất
            Destroy(gameObject);
            Debug.Log("Qua bom da va cham");
        }
    }
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("DeathZone"))
        {
            // kết thúc game
            m_gc.SetGameoverState(true);
            Destroy(gameObject);

            Debug.Log("Qua bong da va cham voi deathzone,Gameove");
        }
    }
}
