using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private int leftBound, RightBound;
    private Vector3 pos;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(checkBounds() && Time.timeScale > 0)
        {
            pos = transform.position;
            pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            transform.position = pos;
        }
        //Debug.Log("score = " + points);
    }

    public int health()
    {
        return transform.childCount;
    }

    public void takeDamage()
    {
        if(health() > 0){
        Destroy(transform.GetChild(0).gameObject);
        }
    }

    bool checkBounds()
    {
        Vector3 mouse = Camera.main.WorldToViewportPoint(Input.mousePosition);
        leftBound = 0;
        RightBound = Screen.width;
        return Input.mousePosition.x >leftBound && Input.mousePosition.x < RightBound;
    
    }
    
}
