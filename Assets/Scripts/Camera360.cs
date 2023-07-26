using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera360 : MonoBehaviour
{
    public Camera Camera;
    
    public RenderTexture EyeCubemap;
    public RenderTexture EquirectTexture;

    void Update ()
    {
        Camera.RenderToCubemap(EyeCubemap, 63, Camera.MonoOrStereoscopicEye.Mono);
        EyeCubemap.ConvertToEquirect(EquirectTexture, Camera.MonoOrStereoscopicEye.Mono);
    }
}
