using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostGlobalControler : MonoBehaviour
{
    private PostProcessVolume globalVolume;
    private void Awake()
    {
        globalVolume = GetComponent<PostProcessVolume>();
    }
    // Start is called before the first frame update
    void Start()
    {
        statusColorEffect(false);
    }
    private void statusColorEffect(bool status)
    {
        ColorGrading colorFX;
        globalVolume.profile.TryGetSettings(out colorFX);
        colorFX.active = status;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
