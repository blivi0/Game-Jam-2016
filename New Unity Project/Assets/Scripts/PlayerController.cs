using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Camera camera;

    void Awake() {
        camera = transform.FindChild("Camera").GetComponent<Camera>();
    }

	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.tag == "Enemy") {
                    Destroy(hit.collider.gameObject);
                }
            }
                
        }
	}
}
