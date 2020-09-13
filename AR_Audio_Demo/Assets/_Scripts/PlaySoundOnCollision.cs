using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
	public string clip_name;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "MainCamera")
		{
		
			FindObjectOfType<AudioManager>().Play(clip_name);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.tag == "MainCamera")
		{
			FindObjectOfType<AudioManager>().Stop(clip_name);
		}
	}
}
