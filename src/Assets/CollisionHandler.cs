using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private static ScoreBoard sb;

    private void Start() {
        if (sb == null) {
            GameObject scoreBoard = GameObject.Find("ScoreBoard");
            sb = scoreBoard.GetComponent<ScoreBoard>();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Boulder")) {
            Debug.Log("Hit a boulder");
            sb.incrementScore();
            Destroy(other.gameObject);
            Destroy(gameObject)     ;
        }
    } 
}
