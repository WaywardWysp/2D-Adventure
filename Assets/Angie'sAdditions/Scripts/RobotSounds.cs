using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSounds : MonoBehaviour


{
    public List<AudioClip> robotNPCSounds = new List<AudioClip>();
    private AudioSource source;
    private List<AudioClip> currentList;


    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();            
    }

    void OnCollisionEnter()
    {
        AudioClip clip = currentList[Random.Range(0, currentList.Count)];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
