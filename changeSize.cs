using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // para math

public class changeSize : MonoBehaviour
{

    public float minDistance = 10;
    GameObject dec_player;
    GameObject inc_player;

    void Start() {
        inc_player = GameObject.Find("Cube_player");
        dec_player = GameObject.Find("Sphere");
    }
    void Update() {
        float dinc_player = Vector3.Distance(transform.position, inc_player.transform.position);
        float ddec_player = Vector3.Distance(transform.position, dec_player.transform.position);
        dinc_player = Math.Min(dinc_player, minDistance);
        ddec_player = Math.Min(ddec_player, minDistance);
        float p1Influence = dinc_player * 0.5f / minDistance;
        float p2Influence = (minDistance - ddec_player) * 0.5f / minDistance;
        transform.localScale = Vector3.one * (p2Influence + p1Influence);
    }
}
