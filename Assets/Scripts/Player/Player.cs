using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private void Awake() {
        Instance = this;
    }

    public PlayerMovement playerMovement;

    public float range = 10f;

    public Vector2 Position {
        get {
            return this.transform.position - new Vector3(0, 0.15f);
        }
    }
}
