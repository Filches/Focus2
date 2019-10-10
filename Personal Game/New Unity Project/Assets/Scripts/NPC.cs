using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    GameObject chat, player;
    PlayerScript ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("Player").GetComponent<PlayerScript>();
        player = GameObject.Find("Player");
        chat = GameObject.Find(transform.name + "/Canvas");
        chat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(ps.interact))
        {
            chat.SetActive(true);
            Invoke("removechat", 3);
        }
        transform.LookAt(player.transform.position);
        //transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
        
    }

    void removechat()
    {
        chat.SetActive(false);
    }
}
