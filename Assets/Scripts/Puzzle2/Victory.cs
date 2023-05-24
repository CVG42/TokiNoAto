using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject victoryText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            victoryText.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }
}
