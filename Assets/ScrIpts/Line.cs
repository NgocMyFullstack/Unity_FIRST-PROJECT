using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    // Tốc độ của vật thể 
    public float moveSpeed;
    // Nút di chuyển của vật thể
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Khi bấm nút sang trái thì trả về -1 , phải thì 1
        xDirection = Input.GetAxisRaw("Horizontal");
        // Di chuyển vật thể theo trục x
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        // kiểm tra thanh Line không bị ra ngoài 
        if((transform.position.x <= -8f && xDirection < 0 ) || (transform.position.x >= 8f && xDirection > 0))
        return;
        
        transform.position = transform.position + new Vector3(moveStep,0,0);
    }
}
