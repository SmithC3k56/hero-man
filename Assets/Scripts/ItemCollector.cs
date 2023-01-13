using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private Text cherryText;
    [SerializeField] private AudioSource audioCollectionSource;

    private void Start()
    {
        audioCollectionSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        // get GameObject of the object that collided with the trigger
        if(collision.gameObject.CompareTag("Cherry")){
            audioCollectionSource.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherryText.text = "Your score: "+ cherries.ToString();
        }
    }
}
