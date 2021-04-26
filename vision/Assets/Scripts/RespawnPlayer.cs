using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private Vector3 startPos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
      startPos=player.transform.position;  
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.name==player.name){
            player.transform.position=startPos;
            print("player");
        }
    }

}
