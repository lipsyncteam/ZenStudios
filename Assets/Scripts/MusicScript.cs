﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MusicScript : MonoBehaviour {
	

	public AudioSource Music;
	public AudioClip MusicSound;

	public static int onceplay = 0;

	void Awake()
	{
		
		onceplay += 1;
		print (onceplay);

		if (onceplay == 1) {
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy(gameObject);

		}
	}




	void Update () 
	{
		Music = GetComponent<AudioSource> ();
		if(PlayerPrefs.GetInt("Mute") == 1)
		{
			Music.volume = 0.0f;

		}

		else if (PlayerPrefs.GetInt("Mute") == 0){
			Music.volume = 1f;

		}

	}
	



}