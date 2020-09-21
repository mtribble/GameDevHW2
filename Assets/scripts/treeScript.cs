using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeScript : MonoBehaviour
{
    public float speed = 5f;
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed* Time.deltaTime,0,0);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag.Equals("wall")){
            speed *= -1;
        }
    }

}
