using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorSprite : MonoBehaviour {
	public CharElement body;
	public CharElement face;
	public CharElement eybrows;
	public Dictionary<CharElement.Location, CharElement> additionalThings;
}
