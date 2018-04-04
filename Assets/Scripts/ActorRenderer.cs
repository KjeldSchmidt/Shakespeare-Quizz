using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ActorRenderer : MonoBehaviour {

	private Dictionary<string, List<string>> elementTypeMap = new Dictionary<string, List<string>>();
	public SpriteRenderer eyebrow;
	public SpriteRenderer hat;
	public SpriteRenderer hair;
	public SpriteRenderer facialhair;
	public SpriteRenderer face;
	public SpriteRenderer overall;
	public SpriteRenderer handheld;
	public SpriteRenderer shirt;
	public SpriteRenderer pants;
	public SpriteRenderer shoes;
	public SpriteRenderer body;
	public SpriteRenderer wings;

	// Use this for initialization
	void Start () {

		initMap();

		string CharElemDir = Application.dataPath + "/Images/CharacterElements/";
		string[] CharElemFilePaths = Directory.GetFiles(CharElemDir);
		foreach ( string path in CharElemFilePaths ) {
			string lowerCasePath = path.ToLower();
			if ( lowerCasePath.Contains("augenbrauen") ) {
				elementTypeMap["Eyebrow"].Add(path);
			} else if (lowerCasePath.Contains("hemd")) {
				elementTypeMap["Shirt"].Add(path);
			} else if (lowerCasePath.Contains("kleider") || lowerCasePath.Contains("onesies")) {
				elementTypeMap["Overall"].Add(path);
			} else if (lowerCasePath.Contains("schuhe")) {
				elementTypeMap["Shoes"].Add(path);
			} else if (lowerCasePath.Contains("unterteil")) {
				elementTypeMap["Pants"].Add(path);
			} else if (lowerCasePath.Contains("haare#")) {
				elementTypeMap["Hair"].Add(path);
			} else {
				Debug.Log("Could not classify " + Path.GetFileName(path));
			}
		}
	}

	private void initMap() {
		elementTypeMap.Add("Eyebrow", new List<string>());
		elementTypeMap.Add("Hat", new List<string>());
		elementTypeMap.Add("Hair", new List<string>());
		elementTypeMap.Add("FacialHair", new List<string>());
		elementTypeMap.Add("Face", new List<string>());
		elementTypeMap.Add("Overall", new List<string>());
		elementTypeMap.Add("Handheld", new List<string>());
		elementTypeMap.Add("Shirt", new List<string>());
		elementTypeMap.Add("Pants", new List<string>());
		elementTypeMap.Add("Shoes", new List<string>());
		elementTypeMap.Add("Body", new List<string>());
		elementTypeMap.Add("Wings", new List<string>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
