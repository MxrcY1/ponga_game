using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laszti : MonoBehaviour
{
    public GameObject BallPref;
    // Start is called before the first frame update
    void Start()
    {
        spawnLaszti();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnLaszti()
    {
        var spawnLaszti = Instantiate(BallPref);
        spawnLaszti.GetComponent<Rigidbody2D>().AddForce(new Vector2(0.5f, 0.5f) * 2,);
    }
}
