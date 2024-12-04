using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSounds : MonoBehaviour
{
    public AudioClip[] crashSounds;
    private AudioSource audioSourceOfThisObject;
    // Start is called before the first frame update
    void Start()
    {
        audioSourceOfThisObject = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision coll)
    {
        int randClipIndex = Random.Range(0, crashSounds.Length);
        audioSourceOfThisObject.clip = crashSounds[randClipIndex];
        audioSourceOfThisObject.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
