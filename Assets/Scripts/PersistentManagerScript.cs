using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    
    public static PersistentManagerScript Instance {get; private set;}

    public int Value;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    //https://youtu.be/CPKAgyp8cno?si=bvKJjticMKbHHN3U
    //Manager script across scene with SceneManagerScript

}
