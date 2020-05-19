using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speed, 0);
        }

         if (Input.GetKey(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x - speed, player.transform.position.y, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag)
        {

            case "Stand":
                inventory.objects.Add("Item");
                break;
            case "MilkStand":
                inventory.objects.Add("Milk");
                break;
            case "MeatStand":
                inventory.objects.Add("Meat");
                break;
            case "ToiletPaperStand":
                inventory.objects.Add("Toilet paper");
                break;
        }
        /*if (collision.gameObject.tag=="Stand")
        {
            inventory.objects.Add("Item");
        }*/
    }
    public void OnTriggerStay2D(Collider2D detector)
    {
        if(detector.gameObject.tag=="People")
        {
            Debug.Log("Help CoronaVirus");
        }
    }
}
