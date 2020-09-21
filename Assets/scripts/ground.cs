using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public GameObject player;
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
            //Debug.Log("Apple fell");
            Destroy(collision.gameObject);
            player.GetComponent<PlayerControls>().takeDamage();
        }
    }
}
