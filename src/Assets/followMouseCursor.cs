using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouseCursor : MonoBehaviour {

    public GameObject Bullet;
    public GameObject gameOverPanel;
    private bool gameFinished = false;
    private Vector2 offset;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (!gameFinished) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;

            // Calculate the direction and angle
            Vector2 direction = mousePosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Apply an offset if needed
            angle -= 90f;

            // Set the object's rotation
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            if (Input.GetMouseButtonDown(0)) {
                SpawnBullet();
            }
        }
    }

    private void SpawnBullet() {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = 0f;
        Vector3 direction = (worldMousePosition - transform.position).normalized;   
        GameObject bulletObject = Instantiate(Bullet, transform.position, Quaternion.identity);
        BulletBehaviour bullet = bulletObject.GetComponent<BulletBehaviour>();
        bullet.setDirection(direction);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Boulder")) {
            Debug.Log("Opps... lost the Game");
            gameFinished = true;
            gameObject.SetActive(false);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    } 
}
