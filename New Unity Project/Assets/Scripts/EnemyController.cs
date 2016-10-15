using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private const float speed = 5f;
	
	void Update () {
        transform.LookAt(GameManager.instance.player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            // TODO: Player take damage
            Destroy(gameObject);
        }
    }
}
