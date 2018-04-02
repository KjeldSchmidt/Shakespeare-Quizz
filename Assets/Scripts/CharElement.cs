using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharElement : MonoBehaviour {
	public enum Type {Inherent, Costume};
	public enum Location {Body, Hair, Eyebrows, Face, FacialHair, Shoes, Pants, Shirt, Overall};

	public Location location;
	public Type type;
	public Texture image;
}
