# #NVJOB Dynamic Sky Lite (standard render) v2.3
#### [nvjob.github.io/unity/nvjob-dynamic-sky-lite](https://nvjob.github.io/unity/nvjob-dynamic-sky-lite)

![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/221/pic/9.jpg)

Simple and fast sky shaders. The asset includes two shaders and a simple script.<br>
There is an example in the asset that allows you to quickly understand how to use the "sky" in your project.<br>
For the shader to work properly, a dome model with prepared UV is required.

**Previous Versions** - [github.com/nvjob/NVJOB-Sky-Shader-old-versions](https://github.com/nvjob/NVJOB-Sky-Shader-old-versions)

-------------------------------------------------------------------

![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/230/pic/1.gif)

### Prerequisites

To work on the project, you will need a Unity version of at least 2019.1.8 (64-bit).

### Information

The movement of clouds is carried out using global shader variables: _SkyShaderUvX, _SkyShaderUvZ.<br/>
_SkyShaderUvX, _SkyShaderUvZ - Offset main texture (Sky shader).

#### Example script:

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

![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/221/pic/3a.jpg)

#### Video manual:
https://www.youtube.com/watch?v=8xBBqnpXuRY <br>
https://www.youtube.com/watch?v=7daG2E1tNok

-------------------------------------------------------------------

![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/221/pic/4.jpg)
![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/221/pic/6.jpg)
![GitHub Logo](https://raw.githubusercontent.com/nvjob/nvjob.github.io/master/repo/unity%20assets/dynamic%20sky%20lite%20sr/221/pic/7.jpg)

-------------------------------------------------------------------

**Authors:** #NVJOB Nicholas Veselov - [nvjob.github.io](https://nvjob.github.io)

**License:** MIT License. Clarification of licenses - [nvjob.github.io/mit-license](https://nvjob.github.io/mit-license)

**Support:** [nvjob.github.io/support](https://nvjob.github.io/support)

**Report a Problem / Issue Tracker / FAQ:** [nvjob.github.io/reportaproblem](https://nvjob.github.io/reportaproblem)
