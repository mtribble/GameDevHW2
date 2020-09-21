using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag.Equals("apple")){
            Debug.Log("Apple Caught");
            PlayerControls parent = transform.parent.GetComponent<PlayerControls>();
            parent.points += 100;
            Destroy(collision.gameObject);
        }
    }
}
