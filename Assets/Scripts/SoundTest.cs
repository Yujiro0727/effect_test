using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void SoundCoin()
	{
		SoundManager.Instance.PlaySe("coin");
	}
	public void SoundError()
	{
		SoundManager.Instance.PlaySe("error");
	}
}
