using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
	public string name;

	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume;

	[Range(0.1f, 3f)]
	public float pitch;

	[Range(0f, 1f)]
	public float spatial_blend;

	public bool loop;

	public bool mute;

	public bool play_on_awake;

	[HideInInspector]
	public AudioSource source;
	
}
