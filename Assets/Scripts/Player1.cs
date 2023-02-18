using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mPos = Input.mousePosition;
        if (mPos.x > Screen.width / 2)
        {
            float prevX = transform.position.x;
            Vector2 nextPos = Camera.main.ScreenToWorldPoint(mPos);
            nextPos.x = prevX;
            nextPos.y = Mathf.Clamp(nextPos.y, -4, 4);

            transform.position = nextPos;
        }
    }
}