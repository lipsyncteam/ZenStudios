using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersCompletion : MonoBehaviour
{
    public Image Character, CharctersRight;
    public Sprite CharactersInChinese,CharacterImage;
    
    public GameObject CharacterBeforeEffect,StrokesImage;
    public SphereCollider[] Box_Coll;
    public Image[] CharacterColor;
    public GameObject LoadNextCharacter;
    public int LastElement;
    bool OncePlayed;
    public AudioSource Music;
    public AudioClip WinningSound;

    void Start ()
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

    }

    void ColorCharacter()
    {
        if(Box_Coll[0].enabled == false)
            CharacterColor[0].fillAmount = 0.239f;

         if (Box_Coll[1].enabled == false)
            CharacterColor[0].fillAmount = 0.391f;

         if (Box_Coll[2].enabled == false)
            CharacterColor[0].fillAmount = 0.535f;
         

         if (Box_Coll[3].enabled == false)
            CharacterColor[0].fillAmount = 0.661f;

         if (Box_Coll[4].enabled == false)
            CharacterColor[0].fillAmount = 0.787f;

         if (Box_Coll[5].enabled == false)
            CharacterColor[0].fillAmount = 0.871f;

         if (Box_Coll[6].enabled == false)
            CharacterColor[0].fillAmount = 1f;
         ///
         if (Box_Coll[7].enabled == false)
            CharacterColor[1].fillAmount = 0.078f;
        if (Box_Coll[8].enabled == false)
            CharacterColor[1].fillAmount = 0.165f;
        if (Box_Coll[9].enabled == false)
            CharacterColor[1].fillAmount = 0.225f;
        if (Box_Coll[10].enabled == false)
            CharacterColor[1].fillAmount = 0.285f;
        if (Box_Coll[11].enabled == false)
            CharacterColor[1].fillAmount = 0.357f;
        if (Box_Coll[12].enabled == false)
            CharacterColor[1].fillAmount = 0.435f;
        if (Box_Coll[13].enabled == false)
            CharacterColor[1].fillAmount = 0.518f;
        if (Box_Coll[14].enabled == false)
            CharacterColor[1].fillAmount = 0.596f;
        if (Box_Coll[15].enabled == false)
            CharacterColor[1].fillAmount = 0.668f;
        if (Box_Coll[16].enabled == false)
            CharacterColor[1].fillAmount = 0.746f;
        if (Box_Coll[17].enabled == false)
            CharacterColor[1].fillAmount = 0.818f;
        if (Box_Coll[18].enabled == false)
            CharacterColor[1].fillAmount = 0.896f;
        if (Box_Coll[19].enabled == false)
            CharacterColor[1].fillAmount = 0.914f;
        if (Box_Coll[20].enabled == false)
            CharacterColor[1].fillAmount = 1f;

        ////////
        if (Box_Coll[21].enabled == false)
            CharacterColor[2].fillAmount = 0.371f;
        if (Box_Coll[22].enabled == false)
            CharacterColor[2].fillAmount = 0.532f;
        if (Box_Coll[23].enabled == false)
            CharacterColor[2].fillAmount = 0.657f;
        if (Box_Coll[24].enabled == false)
            CharacterColor[2].fillAmount = 0.77f;
        if (Box_Coll[25].enabled == false)
            CharacterColor[2].fillAmount = 0.898f;
        if (Box_Coll[26].enabled == false)
            CharacterColor[2].fillAmount = 1f;
        /////
        if (Box_Coll[27].enabled == false)
            CharacterColor[3].fillAmount = 0.245f;
        if (Box_Coll[28].enabled == false)
            CharacterColor[3].fillAmount = 0.388f;
        if (Box_Coll[29].enabled == false)
            CharacterColor[3].fillAmount = 0.525f;
        if (Box_Coll[30].enabled == false)
            CharacterColor[3].fillAmount = 0.65f;
        if (Box_Coll[31].enabled == false)
            CharacterColor[3].fillAmount = 0.775f;
        if (Box_Coll[32].enabled == false)
            CharacterColor[3].fillAmount = 0.9f;
        
        if (Box_Coll[33].enabled == false)
            CharacterColor[3].fillAmount = 1f;
        /////

        if (Box_Coll[34].enabled == false)
            CharacterColor[4].fillAmount = 0.221f;
        if (Box_Coll[35].enabled == false)
            CharacterColor[4].fillAmount = 0.323f;
        if (Box_Coll[36].enabled == false)
            CharacterColor[4].fillAmount = 0.377f;
        if (Box_Coll[37].enabled == false)
            CharacterColor[4].fillAmount = 0.479f;
        //
        if (Box_Coll[38].enabled == false)
            CharacterColor[4].fillAmount = 0.497f;
        if (Box_Coll[39].enabled == false)
            CharacterColor[4].fillAmount = 0.628f;
        
        if (Box_Coll[40].enabled == false)
            CharacterColor[4].fillAmount = 0.767f;
        if (Box_Coll[41].enabled == false)
            CharacterColor[4].fillAmount = 0.863f;
        if (Box_Coll[42].enabled == false)
            CharacterColor[4].fillAmount = 1f;
        ////////

        if (Box_Coll[43].enabled == false)
            CharacterColor[5].fillAmount = 0.173f;
        if (Box_Coll[44].enabled == false)
            CharacterColor[5].fillAmount = 0.239f;
        if (Box_Coll[45].enabled == false)
            CharacterColor[5].fillAmount = 0.335f;
        if (Box_Coll[46].enabled == false)
            CharacterColor[5].fillAmount = 0.437f;
        if (Box_Coll[47].enabled == false)
            CharacterColor[5].fillAmount = 0.521f;
        if (Box_Coll[48].enabled == false)
            CharacterColor[5].fillAmount = 0.617f;
        if (Box_Coll[49].enabled == false)
            CharacterColor[5].fillAmount = 0.766f;
        if (Box_Coll[50].enabled == false)
            CharacterColor[5].fillAmount = 1f;
        //////////////////////////////////////////////
        if (Box_Coll[51].enabled == false)
            CharacterColor[6].fillAmount = 0.472f;
        if (Box_Coll[52].enabled == false)
            CharacterColor[6].fillAmount = 0.699f;
        if (Box_Coll[53].enabled == false)
            CharacterColor[6].fillAmount = 1f;
        //////////////////
        if (Box_Coll[54].enabled == false)
            CharacterColor[7].fillAmount = 0.412f;
        if (Box_Coll[55].enabled == false)
            CharacterColor[7].fillAmount = 0.675f;
        if (Box_Coll[56].enabled == false)
            CharacterColor[7].fillAmount = 0.767f;
        if (Box_Coll[57].enabled == false)
            CharacterColor[7].fillAmount = 0.857f;
        if (Box_Coll[58].enabled == false)
            CharacterColor[7].fillAmount = 1f;
        ////////

        if (Box_Coll[59].enabled == false)
            CharacterColor[8].fillAmount = 0.275f;
        if (Box_Coll[60].enabled == false)
            CharacterColor[8].fillAmount = 1f;
    }

    void ResetCharacter()
    {
        foreach(var boxColl in Box_Coll)
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

    void Update ()
    {
        if (HitCollision.ResetColor == true)
           ResetCharacter();
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
       // LoadNextCharacter.SetActive(true);

    }

  
}
