using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundsScript : MonoBehaviour {

	public AudioSource randomSound;

	public AudioClip[] audioSources;

	// Use this for initialization
	void Start () {

		CallAudio ();
	}


	void CallAudio()
	{
		Invoke ("RandomSoundness", 1);
	}

	void RandomSoundness()
	{
		randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
		randomSound.Play ();
		CallAudio ();
	}
}