using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersCompletion : MonoBehaviour
{
    public Image Character, CharctersRight;
    public Sprite CharactersInChinese,CharacterImage;
    
    public GameObject CharacterBeforeEffect,StrokesImage;
    public BoxCollider[] Box_Coll;
    public Image[] CharacterColor;

   
    bool OncePlayed;
    void Start ()
    {
        Character.GetComponent<Image>().sprite = CharactersInChinese;
        OncePlayed = false;
        CharctersRight.enabled = false;
        StrokesImage.SetActive(true);
    }

    void ColorCharacter()
    {
        if(Box_Coll[0].enabled == false)
            CharacterColor[0].fillAmount = 0.32f;

         if (Box_Coll[1].enabled == false)
            CharacterColor[0].fillAmount = 0.599f;

         if (Box_Coll[2].enabled == false)
            CharacterColor[0].fillAmount = 1f;
         ///

         if (Box_Coll[3].enabled == false)
            CharacterColor[1].fillAmount = 0.099f;

         if (Box_Coll[4].enabled == false)
            CharacterColor[1].fillAmount = 0.204f;

         if (Box_Coll[5].enabled == false)
            CharacterColor[1].fillAmount = 0.437f;

         if (Box_Coll[6].enabled == false)
            CharacterColor[1].fillAmount = 0.676f;

         if (Box_Coll[7].enabled == false)
            CharacterColor[1].fillAmount = 1f;

        ///
        if (Box_Coll[8].enabled == false)
            CharacterColor[2].fillAmount = 0.355f;
        if (Box_Coll[9].enabled == false)
            CharacterColor[2].fillAmount = 0.623f;
        if (Box_Coll[10].enabled == false)
            CharacterColor[2].fillAmount = 1f;

        ///

        if (Box_Coll[11].enabled == false)
            CharacterColor[3].fillAmount = 0.262f;
        if (Box_Coll[12].enabled == false)
            CharacterColor[3].fillAmount = 0.559f;
        if (Box_Coll[13].enabled == false)
            CharacterColor[3].fillAmount = 1f;
        //

        ///

        if (Box_Coll[14].enabled == false)
            CharacterColor[4].fillAmount = 0.262f;
        if (Box_Coll[15].enabled == false)
            CharacterColor[4].fillAmount = 0.5f;
        if (Box_Coll[16].enabled == false)
            CharacterColor[4].fillAmount = 0.756f;
        if (Box_Coll[17].enabled == false)
            CharacterColor[4].fillAmount = 1f;
        //

        if (Box_Coll[18].enabled == false)
            CharacterColor[5].fillAmount = 0.4f;
        if (Box_Coll[19].enabled == false)
            CharacterColor[5].fillAmount = 1f;
        //
        if (Box_Coll[20].enabled == false)
            CharacterColor[6].fillAmount = 0.4f;
        if (Box_Coll[21].enabled == false)
            CharacterColor[6].fillAmount = 1f;
        //

        if (Box_Coll[22].enabled == false)
            CharacterColor[7].fillAmount = 0.3f;
        if (Box_Coll[23].enabled == false)
            CharacterColor[7].fillAmount = 0.6f;
        if (Box_Coll[24].enabled == false)
            CharacterColor[7].fillAmount = 1f;
        //

        if (Box_Coll[25].enabled == false)
            CharacterColor[8].fillAmount = 0.5f;
        if (Box_Coll[26].enabled == false)
            CharacterColor[8].fillAmount = 1f;
        //
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


        if (Box_Coll[26].enabled == false && OncePlayed == false)
        {
            OncePlayed = true;
            Invoke("CharacterBeforeEffectFunc", 0.2f);
            Invoke("ShowCharacterImage", 1f);
        }

       if(HitCollision.HitBrush == true)
        {
            if (Box_Coll[HitCollision.CCcount].enabled == true)
            {
                Box_Coll[HitCollision.CCcount].enabled = false;
                ColorCharacter();
                if (Box_Coll[HitCollision.CCcount].enabled == false)
                {
                    HitCollision.CCcount++;

                }
            }
        }

        //Debug.Log(Box_Coll.Length);
        Debug.Log(HitCollision.CCcount);
    }

    void CharacterBeforeEffectFunc()
    {
        var clone = Instantiate(CharacterBeforeEffect, transform.position, Quaternion.identity);
        Destroy(clone, 1f);
    }

    void ShowCharacterImage()
    {
        Character.GetComponent<Image>().sprite = CharacterImage;
        CharctersRight.enabled = true;

        //Reset
        OncePlayed = false;

        StrokesImage.SetActive(false);
    }
}
