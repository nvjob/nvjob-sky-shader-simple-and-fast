# #NVJOB Dynamic Sky Lite (standard render)

Version 2.2.1

Simple and fast sky shader. The asset includes two shaders and a simple script.
There is an example in the asset that allows you to quickly understand how to use the "sky" in your project.
For the shader to work properly, a dome model with prepared UV is required.

Unity Asset Store - https://assetstore.unity.com/packages/vfx/particles/environment/nvjob-dynamic-sky-simple-and-fast-152747

Previous Versions - https://github.com/nvjob/NVJOB-Sky-Shader-old-versions

https://www.youtube.com/watch?v=ALo3AYyVWcY

https://www.youtube.com/watch?v=8xBBqnpXuRY

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%203.png)

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%202.png)

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%201.png)

------------------------------------

### Prerequisites

To work on the project, you will need a Unity version of at least 2019.1.8 (64-bit).

### Information

The movement of clouds is carried out using global shader variables: _SkyShaderUvX, _SkyShaderUvZ.

_SkyShaderUvX, _SkyShaderUvZ - Offset main texture (Sky shader).

#### Example script.

```
using UnityEngine;

public class DynamicSkyLite : MonoBehaviour
{
    public float ssgUvRotateSpeed = 1;
    public float ssgUvRotateDistance = 1;
    public Transform player;
    Vector2 ssgVector;
    Transform tr;

    private void Awake()
    { 
        ssgVector = Vector2.zero;
        tr = transform;
    }

    void Update()
    {
        ssgVector = Quaternion.AngleAxis(Time.time * ssgUvRotateSpeed, Vector3.forward) * Vector2.one * ssgUvRotateDistance;
        Shader.SetGlobalFloat("_SkyShaderUvX", ssgVector.x);
        Shader.SetGlobalFloat("_SkyShaderUvZ", ssgVector.y);
        tr.position = new Vector3(player.position.x, tr.position.y, player.position.z);
    }
}
```

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%206.png)

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%204.png)

![GitHub Logo](https://github.com/nvjob/NVJOB-Sky-Shader-simple-and-fast/blob/master/Images/Dynamic%20Sky%205.png)

------------------------------------

### Authors
Designed by #NVJOB Nicholas Veselov | https://nvjob.pro | http://nvjob.dx.am | https://twitter.com/nvjob

### License
This project is licensed under the MIT License - see the LICENSE file for details

### Donate
You can thank me by a voluntary donation. https://nvjob.pro/donations.html
