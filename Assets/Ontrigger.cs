using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ontrigger : MonoBehaviour
{
    public Text TextCount;
    public ParticleSystem ParticleSystem;
    public int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        count++;
        TextCount.text = count.ToString();
        ParticleSystem.Play();
        

    }
}
