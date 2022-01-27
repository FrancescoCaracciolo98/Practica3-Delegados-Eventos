using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cilindroA : MonoBehaviour
{
    private GameObject player;
    private float range;
    public float speed = 5f;
    public float minDistance = 5f;

    public delegate void delegateA();
    public static event delegateA OnCollideA;  // static para aplicarlo a todos
    public static event delegateA OnNear;

    void Start()
    {
        player = GameObject.Find("Cube_player");
        cilindroB.OnCollideB += incrementarFuerza;
    }

    void Update()
    {
        range = Vector3.Distance(transform.position, player.transform.position);
        if (range < minDistance)
        {
            OnNear();
            if (Input.GetKeyDown("space"))
            {
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, -1 * speed * Time.deltaTime * 10);
            }
        }
    }

    private void incrementarFuerza()
    {
        speed *= 2;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            OnCollideA(); // dispara evento onCollideA al chocar con jugador
    }
}