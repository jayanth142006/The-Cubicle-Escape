using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BinManager : MonoBehaviour
{
    public TMP_Text countText;                 // assign in Inspector
    private AudioSource audioSource;       // sound when cube enters
    private HashSet<GameObject> cubesInBin = new HashSet<GameObject>();

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cube"))
        {
            // Add cube to set; only if it's new do we play sound & update
            if (cubesInBin.Add(other.gameObject))
            {
                if (audioSource != null)
                    audioSource.Play();

                UpdateText();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cube"))
        {
            if (cubesInBin.Remove(other.gameObject))
            {
                UpdateText();
            }
        }
    }

    private void UpdateText()
    {
        if (countText != null)
        {
            countText.text = cubesInBin.Count.ToString();
        }
    }
}
