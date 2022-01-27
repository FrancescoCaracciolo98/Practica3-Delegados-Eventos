using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindroAway : MonoBehaviour
{
    private GameObject player;
    private float range;
    public float speed = 5f;
    public float minDistance = 5f;
    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("Cube_player");
    }

    // Update is called once per frame
    void Update() {
        range = Vector3.Distance(transform.position, player.transform.position);
        if (range < minDistance) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, -1 * speed  * Time.deltaTime * 10);
        }
    }
}
