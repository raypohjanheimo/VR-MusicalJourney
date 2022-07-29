using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ArtPiece : MonoBehaviour
{

    [SerializeField] private UnityEvent triggerEvent = new UnityEvent();

    public GameObject sphere;

    public AudioSource sphereSound;
    
    // Start is called before the first frame update
    void Start()
    {
        DisableEmission();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered!");
        EnableEmission();
        triggerEvent.Invoke();
    }

    private void EnableEmission() {
        Material sphereMaterial = sphere.GetComponent<Renderer>().material;
        sphereMaterial.EnableKeyword("_EMISSION");
    }


    public void DisableEmission() {
        Material sphereMaterial = sphere.GetComponent<Renderer>().material;
        sphereMaterial.DisableKeyword("_EMISSION");
    }
}
