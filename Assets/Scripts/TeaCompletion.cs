using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeaCompletion : MonoBehaviour
{
    public Image Character, CharctersRight;
    public Sprite CharactersInChinese, CharacterImage;

    public GameObject CharacterBeforeEffect, StrokesImage;
    public SphereCollider[] Box_Coll;
    public Image[] CharacterColor;
    public GameObject LoadNextCharacter, TopGameObjectOfCharacter;
    public int LastElement;
    bool OncePlayed;
    public AudioSource Music;
    public AudioClip WinningSound;
    public float[] ColliderScaleBrush;
    void OnEnable()
    {
        Character.GetComponent<Image>().sprite = CharactersInChinese;
        OncePlayed = false;
        CharctersRight.enabled = false;
        StrokesImage.SetActive(true);

        Music = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("Mute") == 1)
        {
            Music.volume = 0.0f;

        }

        else if (PlayerPrefs.GetInt("Mute") == 0)
        {
            Music.volume = 1f;

        }
        ResetCharacter();
    }

    void ColorCharacter()
    {
        if (Box_Coll[0].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[0];

        if (Box_Coll[1].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[1];

        if (Box_Coll[2].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[2];


        if (Box_Coll[3].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[3];

        if (Box_Coll[4].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[4];

        if (Box_Coll[5].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[5];

        if (Box_Coll[6].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[6];
        if (Box_Coll[7].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[7];

        if (Box_Coll[8].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[8];
        if (Box_Coll[9].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[9];

        if (Box_Coll[10].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[10];
        if (Box_Coll[11].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[11];

        if (Box_Coll[12].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[12];

        if (Box_Coll[13].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[13];

        if (Box_Coll[14].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[14];
        if (Box_Coll[15].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[15];

        if (Box_Coll[16].enabled == false)
            CharacterColor[8].fillAmount = ColliderScaleBrush[16];
        if (Box_Coll[17].enabled == false)
            CharacterColor[8].fillAmount = ColliderScaleBrush[17];

    }

    void ResetCharacter()
    {
        foreach (var boxColl in Box_Coll)
        {
            boxColl.enabled = true;
        }
        foreach (var colColl in CharacterColor)
        {
            colColl.fillAmount = 0f;
        }
        HitCollision.CCName = null;
        HitCollision.CCcount = 0;
        HitCollision.HitBrush = false;
        HitCollision.ResetColor = false;
    }

    void Update()
    {
        //if (HitCollision.ResetColor == true)
        // ResetCharacter();
        if (Box_Coll[LastElement].enabled == false && OncePlayed == false)
        {
            OncePlayed = true;
            Invoke("CharacterBeforeEffectFunc", 0.2f);
            Invoke("ShowCharacterImage", 0.7f);
        }


        if (HitCollision.HitBrush == true && Box_Coll[HitCollision.CCcount].enabled == true)
        {
            Box_Coll[HitCollision.CCcount].enabled = false;
            ColorCharacter();
            if (Box_Coll[HitCollision.CCcount].enabled == false)
            {
                HitCollision.CCcount++;
            }
        }


    }

    void CharacterBeforeEffectFunc()
    {
        GameObject clone = Instantiate(CharacterBeforeEffect, Box_Coll[13].transform.position, Quaternion.identity);
        Destroy(clone, 1f);
    }

    void ShowCharacterImage()
    {
        Character.GetComponent<Image>().sprite = CharacterImage;
        CharctersRight.enabled = true;
        //Reset
        //OncePlayed = false;
        StrokesImage.SetActive(false);
        Music.clip = WinningSound;
        Music.Play();

        print(LoadNextCharacters.LevelNameCount);
        Invoke("AfterFourSecs", 4f);
    }

    void AfterFourSecs()
    {
        HitCollision.CCcount = 0;
        LoadNextCharacter.SetActive(true);
        TopGameObjectOfCharacter.SetActive(false);
        LoadNextCharacters.LevelNameCount++;

        if (LoadNextCharacters.LevelNameCount == 5)
            LoadNextCharacters.LevelNameCount = 0;
    }
}
