using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance { get; private set; }

    public GameObject player { get; private set; }

    private const float spawnDelay = 2f;

    private const float radiusMin = 10f;
    private const float radiusMax = 20f;

    private const float height = 1f;

    void Awake() {
        instance = this;
        player = Instantiate(Assets.player, new Vector3(0, height, 0), Quaternion.identity) as GameObject;
    }

    void Start() {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies() {
        while (true) {
            float spawnAngle = Random.Range(0, 360);
            float spawnRadius = Random.Range(radiusMin, radiusMax);
            Vector3 spawnPos = new Vector3(spawnRadius * Mathf.Cos(spawnAngle), height, spawnRadius * Mathf.Sin(spawnAngle));
            Instantiate(Assets.enemy, spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);
        }
    }

}
