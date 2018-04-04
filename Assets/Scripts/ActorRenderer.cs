using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ActorRenderer : MonoBehaviour {

	private Dictionary<string, List<string>> elementTypeMap = new Dictionary<string, List<string>>();
	private Dictionary<string, SpriteRenderer> typeToRenderer = new Dictionary<string, SpriteRenderer>();
	public SpriteRenderer handheldRenderer;
	public SpriteRenderer headpieceRenderer;
	public SpriteRenderer helmetRenderer;
	public SpriteRenderer hairRenderer;
	public SpriteRenderer facialhairRenderer;
	public SpriteRenderer neckwearRenderer;
	public SpriteRenderer overallRenderer;
	public SpriteRenderer shirtRenderer;
	public SpriteRenderer pantsRenderer;
	public SpriteRenderer shoesRenderer;
	public SpriteRenderer eyebrowRenderer;
	public SpriteRenderer makeupRenderer;
	public SpriteRenderer eyelidsRenderer;
	public SpriteRenderer facialfeaturesRenderer;
	public SpriteRenderer bodyRenderer;
	public SpriteRenderer wingsRenderer;

	// Use this for initialization
	void Start () {

		initMaps();

		string CharElemDir = Application.dataPath + "/Images/CharacterElements/";
		string[] CharElemFilePaths = Directory.GetFiles(CharElemDir);
		foreach ( string path in CharElemFilePaths ) {
			string lowerCasePath = path.ToLower();
			if ( lowerCasePath.Contains("augenbrauen") ) {
				elementTypeMap["Eyebrow"].Add(path);
			} else if (lowerCasePath.Contains("hemd")) {
				elementTypeMap["Shirt"].Add(path);
			} else if (lowerCasePath.Contains("body")) {
				elementTypeMap["Body"].Add(path);
			} else if (lowerCasePath.Contains("kleider") || lowerCasePath.Contains("onesies")) {
				elementTypeMap["Overall"].Add(path);
			} else if (lowerCasePath.Contains("shoes")) {
				elementTypeMap["Shoes"].Add(path);
			} else if (lowerCasePath.Contains("pants")) {
				elementTypeMap["Pants"].Add(path);
			} else if (lowerCasePath.Contains("hair") || lowerCasePath.Contains("helmet")) {
				elementTypeMap["Hair"].Add(path);
			} else if (lowerCasePath.Contains("kopfbedeckungen")) {
				elementTypeMap["Helmet"].Add(path);
			} else if (lowerCasePath.Contains("flecken")) {
				elementTypeMap["FacialFeatures"].Add(path);
			} else if (lowerCasePath.Contains("facialhair")) {
				elementTypeMap["FacialHair"].Add(path);
			} else if (lowerCasePath.Contains("headpiece")) {
				elementTypeMap["Headpiece"].Add(path);
			} else if (lowerCasePath.Contains("handheld")) {
				elementTypeMap["Handheld"].Add(path);
			} else if (lowerCasePath.Contains("makeup")) {
				elementTypeMap["Makeup"].Add(path);
			} else if (lowerCasePath.Contains("neckwear")) {
				elementTypeMap["Neckwear"].Add(path);
			} else if (lowerCasePath.Contains("wings")) {
				elementTypeMap["Wings"].Add(path);
			} else if (lowerCasePath.Contains("eyelids")) {
				elementTypeMap["Eyelids"].Add(path);
			} else {
				Debug.Log("Could not classify " + Path.GetFileName(path));
			}
		}

		initRandomCostume();
	}

	private string relativePath( string path ) {
		return path.Remove(0, Application.dataPath.Length+1);
	}

	private void initMaps() {
		elementTypeMap.Add("Eyebrow", new List<string>() );
		elementTypeMap.Add("Shirt", new List<string>() );
		elementTypeMap.Add("Body", new List<string>() );
		elementTypeMap.Add("Overall", new List<string>() );
		elementTypeMap.Add("Shoes", new List<string>() );
		elementTypeMap.Add("Pants", new List<string>() );
		elementTypeMap.Add("Hair", new List<string>() );
		elementTypeMap.Add("Helmet", new List<string>() );
		elementTypeMap.Add("FacialFeatures", new List<string>() );
		elementTypeMap.Add("FacialHair", new List<string>() );
		elementTypeMap.Add("Headpiece", new List<string>() );
		elementTypeMap.Add("Handheld", new List<string>() );
		elementTypeMap.Add("Makeup", new List<string>() );
		elementTypeMap.Add("Neckwear", new List<string>() );
		elementTypeMap.Add("Wings", new List<string>() );
		elementTypeMap.Add("Eyelids", new List<string>() );

		typeToRenderer.Add("Eyebrow", eyebrowRenderer );
		typeToRenderer.Add("Shirt", shirtRenderer );
		typeToRenderer.Add("Body", bodyRenderer );
		typeToRenderer.Add("Overall", overallRenderer );
		typeToRenderer.Add("Shoes", shoesRenderer );
		typeToRenderer.Add("Pants", pantsRenderer );
		typeToRenderer.Add("Hair", hairRenderer );
		typeToRenderer.Add("Helmet", helmetRenderer );
		typeToRenderer.Add("FacialFeatures", facialfeaturesRenderer );
		typeToRenderer.Add("FacialHair", facialhairRenderer );
		typeToRenderer.Add("Headpiece", headpieceRenderer );
		typeToRenderer.Add("Handheld", handheldRenderer );
		typeToRenderer.Add("Makeup", makeupRenderer );
		typeToRenderer.Add("Neckwear", neckwearRenderer );
		typeToRenderer.Add("Wings", wingsRenderer );
		typeToRenderer.Add("Eyelids", wingsRenderer );
	}

	private void initRandomCostume() {
		foreach ( string type in elementTypeMap.Keys ) {
			assignRandomOfType(type);
		}
	}
	
	private void assignRandomOfType(string type) {
		if ( elementTypeMap[type].Count != 0 ) {
			typeToRenderer[type].sprite = IMG2Sprite.instance.LoadNewSprite(elementTypeMap[type][0]);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
