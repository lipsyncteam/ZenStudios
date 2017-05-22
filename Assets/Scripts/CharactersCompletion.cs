using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersCompletion : MonoBehaviour
{
    public Image Character;
    public Sprite CharactersInChinese, CharctersRight,CharacterImage;
    public Transform[] Box_Coll;
    public GameObject CharacterBeforeEffect;

    bool OncePlayed;
    void Start ()
    {
        Character.GetComponent<Image>().sprite = CharactersInChinese;
        OncePlayed = false;
    }
	
	
	void Update ()
    {

        Box_Coll = gameObject.GetComponentsInChildren<Transform>();
        if (Box_Coll.Length == 1 && OncePlayed == false)
        {
            OncePlayed = true;
            Character.GetComponent<Image>().sprite = CharctersRight;
            Invoke("CharacterBeforeEffectFunc", 0.5f);
            Invoke("ShowCharacterImage", 1f);
        }

        Debug.Log(Box_Coll.Length);
    }

    void CharacterBeforeEffectFunc()
    {
        var clone = Instantiate(CharacterBeforeEffect, transform.position, Quaternion.identity);
        Destroy(clone, 1f);
    }

    void ShowCharacterImage()
    {
        Character.GetComponent<Image>().sprite = CharacterImage;

    }
}
