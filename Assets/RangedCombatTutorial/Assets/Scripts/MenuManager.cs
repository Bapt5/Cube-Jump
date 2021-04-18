using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	//Music
	public AudioMixer Music;
	public bool activMusic = true;
	public Button GOMusic;
	public Sprite vraiMusic;
	public Sprite fauxMusic;

	//Effect
	public AudioMixer Effect;
	public bool activEffect = true;
	public Button GOEffect;
	public Sprite vraiEffect;
	public Sprite fauxEffect;

	public void Update () {
		//Music
		if (activMusic == true) {
			Music.SetFloat ("volume", 0);
			GOMusic.image.overrideSprite = vraiMusic;
		}

		if (activMusic == false) {
			Music.SetFloat ("volume", -80);
			GOMusic.image.overrideSprite = fauxMusic;
		}

		//Effect
		if (activEffect == true) {
			Effect.SetFloat ("volume", 0);
			GOEffect.image.overrideSprite = vraiEffect;
		}

		if (activEffect == false) {
			Effect.SetFloat ("volume", -80);
			GOEffect.image.overrideSprite = fauxEffect;
		}
	}

	public void SetVolumeMusic() {
		activMusic = !activMusic;
	}

	public void SetVolumeEffect() {
		activEffect = !activEffect;
	}

	public void Game () {
		Application.LoadLevel ("game");
	}
}
