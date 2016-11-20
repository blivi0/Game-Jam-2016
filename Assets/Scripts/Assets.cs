using UnityEngine;
using System.Collections;

public class Assets : MonoBehaviour {

    private const string prefabsPath = "Prefabs/";

    public static readonly GameObject player = Resources.Load<GameObject>(prefabsPath + "Player");
    public static readonly GameObject enemy = Resources.Load<GameObject>(prefabsPath + "Enemy");
    public static readonly GameObject shot = Resources.Load<GameObject>(prefabsPath + "Shot");

}
