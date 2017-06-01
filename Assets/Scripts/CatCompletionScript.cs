using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatCompletionScript : MonoBehaviour
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
            CharacterColor[0].fillAmount = ColliderScaleBrush[2];


        if (Box_Coll[3].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[3];

        if (Box_Coll[4].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[4];

        if (Box_Coll[5].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[5];

        if (Box_Coll[6].enabled == false)
            CharacterColor[0].fillAmount = ColliderScaleBrush[6];
        ///
        if (Box_Coll[7].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[7];
        if (Box_Coll[8].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[8];
        if (Box_Coll[9].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[9];
        if (Box_Coll[10].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[10];
        if (Box_Coll[11].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[11];
        if (Box_Coll[12].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[12];
        if (Box_Coll[13].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[13];
        if (Box_Coll[14].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[14];
        if (Box_Coll[15].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[15];
        if (Box_Coll[16].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[16];
        if (Box_Coll[17].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[17];
        if (Box_Coll[18].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[18];
        if (Box_Coll[19].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[19];
        if (Box_Coll[20].enabled == false)
            CharacterColor[1].fillAmount = ColliderScaleBrush[20];

        ////////
        if (Box_Coll[21].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[21];
        if (Box_Coll[22].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[22];
        if (Box_Coll[23].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[23];
        if (Box_Coll[24].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[24];
        if (Box_Coll[25].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[25];
        if (Box_Coll[26].enabled == false)
            CharacterColor[2].fillAmount = ColliderScaleBrush[26];
        /////
        if (Box_Coll[27].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[27];
        if (Box_Coll[28].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[28];
        if (Box_Coll[29].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[29];
        if (Box_Coll[30].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[30];
        if (Box_Coll[31].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[31];
        if (Box_Coll[32].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[32];

        if (Box_Coll[33].enabled == false)
            CharacterColor[3].fillAmount = ColliderScaleBrush[33];
        /////

        if (Box_Coll[34].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[34];
        if (Box_Coll[35].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[35];
        if (Box_Coll[36].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[36];
        if (Box_Coll[37].enabled == false)
            CharacterColor[4].fillAmount = ColliderScaleBrush[37];
        /////////////////////
        if (Box_Coll[38].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[38];
        if (Box_Coll[39].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[39];

        if (Box_Coll[40].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[40];
        if (Box_Coll[41].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[41];
        if (Box_Coll[42].enabled == false)
            CharacterColor[5].fillAmount = ColliderScaleBrush[42];
        ////////

        if (Box_Coll[43].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[43];
        if (Box_Coll[44].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[44];
        if (Box_Coll[45].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[45];
        if (Box_Coll[46].enabled == false)
            CharacterColor[6].fillAmount = ColliderScaleBrush[46];
        //////////////////
        if (Box_Coll[47].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[47];
        if (Box_Coll[48].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[48];
        if (Box_Coll[49].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[49];
        if (Box_Coll[50].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[50];
        
        if (Box_Coll[51].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[51];
        if (Box_Coll[52].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[52];
        if (Box_Coll[53].enabled == false)
            CharacterColor[7].fillAmount = ColliderScaleBrush[53];
        //////////////////
        if (Box_Coll[54].enabled == false)
            CharacterColor[8].fillAmount = ColliderScaleBrush[54];
        if (Box_Coll[55].enabled == false)
            CharacterColor[8].fillAmount = ColliderScaleBrush[55];
        ////////////////
        if (Box_Coll[56].enabled == false)
            CharacterColor[9].fillAmount = ColliderScaleBrush[56];
        if (Box_Coll[57].enabled == false)
            CharacterColor[9].fillAmount = ColliderScaleBrush[57];
        if (Box_Coll[58].enabled == false)
            CharacterColor[9].fillAmount = ColliderScaleBrush[58];
        ////////

        if (Box_Coll[59].enabled == false)
            CharacterColor[10].fillAmount = ColliderScaleBrush[59];
        if (Box_Coll[60].enabled == false)
            CharacterColor[10].fillAmount = ColliderScaleBrush[60];
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
        if (LoadNextCharacters.LevelNameCount == 2)
            LoadNextCharacters.LevelNameCount = 0;
    }
}
