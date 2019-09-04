# NVJOB Dynamic Sky (simple and fast)

Version 2.1

Simple and fast sky shader. The asset includes two shaders and a simple script.
There is an example in the asset that allows you to quickly understand how to use the "sky" in your project.
For the shader to work properly, a dome model with prepared UV is required. Model of the dome can be taken from the example.

Unity Asset Store - https://assetstore.unity.com/packages/vfx/particles/environment/nvjob-dynamic-sky-simple-and-fast-152747

Previous Versions - https://github.com/nvjob/NVJOB-Sky-Shader-old-versions

https://www.youtube.com/watch?v=7daG2E1tNok
https://www.youtube.com/watch?v=8xBBqnpXuRY

![GitHub Logo](https://raw.githubusercontent.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/master/Images/Dynamic%20Sky%20(3).png)

![GitHub Logo](https://raw.githubusercontent.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/master/Images/Dynamic%20Sky%20(1).png)

------------------------------------

### Prerequisites

To work on the project, you will need a Unity version of at least 2019.1.0f2 (64-bit).

### Information

The movement of clouds is carried out using global shader variables: _SkyShaderUvX, _SkyShaderUvZ.

_SkyShaderUvX, _SkyShaderUvZ - Offset main texture (Sky shader).

#### Example script.

```
using UnityEngine;

public class Sky : MonoBehaviour
{
    public float ssgUvRotateSpeed = 1;
    public float ssgUvRotateDistance = 1;
    Vector2 ssgVector;

    private void Awake()
    {
        ssgVector = Vector2.zero;        
    }

    void Update()
    {
        ssgVector = Quaternion.AngleAxis(Time.time * ssgUvRotateSpeed, Vector3.forward) * Vector2.one * ssgUvRotateDistance;
        Shader.SetGlobalFloat("_SkyShaderUvX", ssgVector.x);
        Shader.SetGlobalFloat("_SkyShaderUvZ", ssgVector.y);
    }
}
```

![GitHub Logo](https://raw.githubusercontent.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/master/Images/Dynamic%20Sky%20(2).png)

------------------------------------

### Authors
Designed by #NVJOB Nicholas Veselov | https://nvjob.pro | http://nvjob.dx.am | https://twitter.com/nvjob

### License
This project is licensed under the MIT License - see the LICENSE file for details

### Donate
You can thank me by a voluntary donation. https://nvjob.pro/donations.html
