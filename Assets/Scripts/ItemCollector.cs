using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Fruits = 0;

    [SerializeField] private Text FruitsText;

    //[SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            //collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            Fruits++;
            FruitsText.text = "Fruits: " + Fruits;
        }
    }
}