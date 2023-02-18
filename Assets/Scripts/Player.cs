using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector2 mPos = Input.mousePosition;

        float prevX = transform.position.x;
        Vector2 nextPos = Camera.main.ScreenToWorldPoint(mPos);
        nextPos.x = prevX;
        nextPos.y = Mathf.Clamp(nextPos.y, -4, 4);

        transform.position = nextPos;
    }
}
