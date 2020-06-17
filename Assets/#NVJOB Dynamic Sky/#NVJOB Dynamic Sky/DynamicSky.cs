// Copyright (c) 2016 Unity Technologies. MIT license - license_unity.txt
// #NVJOB Dynamic Sky. MIT license - license_nvjob.txt
// #NVJOB Dynamic Sky v2.5.1 - https://nvjob.github.io/unity/nvjob-dynamic-sky-lite
// #NVJOB Nicholas Veselov - https://nvjob.github.io


using UnityEngine;

[HelpURL("https://nvjob.github.io/unity/nvjob-dynamic-sky-lite")]
[AddComponentMenu("#NVJOB/Dynamic Sky")]


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


[ExecuteInEditMode]
public class DynamicSky : MonoBehaviour
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    public float ssgUvRotateSpeed = 1;
    public float ssgUvRotateDistance = 1;
    public Transform player;
    public bool sky2d;

    //--------------

    Vector2 ssgVector;
    Transform tr;


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    private void Awake()
    {
        //--------------

        ssgVector = Vector2.zero;
        tr = transform;

        //--------------
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void Update()
    {
        //--------------

        if (sky2d == false)
        {
            ssgVector = Quaternion.AngleAxis(Time.time * ssgUvRotateSpeed, Vector3.forward) * Vector2.one * ssgUvRotateDistance;
            Shader.SetGlobalFloat("_SkyShaderUvX", ssgVector.x);
            Shader.SetGlobalFloat("_SkyShaderUvZ", ssgVector.y);
        }
        else
        {
            float speed = Time.time * 0.01f * ssgUvRotateSpeed;
            Shader.SetGlobalFloat("_SkyShaderUvZ", speed);
        }

        //--------------

        if (player != null) tr.position = new Vector3(player.position.x, tr.position.y, player.position.z);

        //--------------
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
