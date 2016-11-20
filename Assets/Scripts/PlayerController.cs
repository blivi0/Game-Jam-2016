using UnityEngine;
using VRStandardAssets.Utils;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Camera camera;

    void Awake() {
        camera = transform.FindChild("MainCamera").GetComponent<Camera>();
    }

    void Start() {
        camera.GetComponent<VRInput>().OnClick += Shoot;
    }

	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }
	}

    private void Shoot() {
        GameObject bullet = (GameObject) Instantiate(Assets.shot, transform.position, Quaternion.Euler(90, 0, -camera.transform.localRotation.eulerAngles.y));
    }
}
