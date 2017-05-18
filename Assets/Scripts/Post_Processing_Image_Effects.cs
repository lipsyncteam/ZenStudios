using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Post_Processing_Image_Effects : MonoBehaviour {

	public PostProcessingProfile ImageEffects_Profile;
	VignetteModel.Settings Copy_of_Vignette;

	bool VignetteEffect_On = true;
	void OnEnable()
	{
		PostProcessingBehaviour ImageEffects_Profile_Behavior = GetComponent<PostProcessingBehaviour>();
        

        if (ImageEffects_Profile_Behavior.profile == null)
		{
			enabled = false;
			return;
		}

		ImageEffects_Profile_Behavior.profile = ImageEffects_Profile;

	}

	void Start()
	{
		Copy_of_Vignette.intensity = 0.415f;
		Copy_of_Vignette.center = new Vector2(0.5f,0.5f);
		Copy_of_Vignette.roundness = 1f;
		Copy_of_Vignette.smoothness = 0.55f;
		ImageEffects_Profile.vignette.settings = Copy_of_Vignette;

		Invoke ("InvokeVignette_Intensity", 3f);
	}

	void Update()
	{
		if (VignetteEffect_On == false)
			return;
		Copy_of_Vignette = ImageEffects_Profile.vignette.settings;
		Copy_of_Vignette.smoothness = Mathf.Abs(Mathf.Sin(Time.timeSinceLevelLoad)  * 0.99f) + 0.01f;

		ImageEffects_Profile.vignette.settings = Copy_of_Vignette;
	
	}

	void InvokeVignette_Intensity()
	{
		
		Copy_of_Vignette.intensity = 0.0f;
		Copy_of_Vignette.smoothness = 0.0f;
		ImageEffects_Profile.vignette.settings = Copy_of_Vignette;
		VignetteEffect_On = false;
	}
}
