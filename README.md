# NVJOB Sky Shader - simple and fast.

Version 2.1

Simple and fast sky shader. For the shader to work properly, a dome model with prepared UV is required. Model of the dome can be taken from the example.

![GitHub Logo](https://lh3.googleusercontent.com/9rqrcitu-xxI-fDvsGkD-ZV0Re8nWvIdt9eRyhvSGccTbCMEYQlzfsj2V14DDVJlX6XYVuRNTTSw6Pse3Bse-vG9_Y3lvKDjUXU5QYuvx8Dp3pms7kC_2aqXGRSKGwXsT6QPReXgFnE-EW0OZ5_gZiHOkvBnoXhYSANzJSVcrPbtrSU3LiI2co7WaIyFbyilEhzjennF9cIT_Z8hfuKQnIGACCz0qjEMLve2tmMiLLr4meuYQaHb4kaM5vsmsEkNa83b8RFAoseQhDFyPDCtJ7zooV4lw9nZhEXK3LpvTsfXT1iO6BgEL1Rvk1IpyldzFogfvPMCI023XFVjlLtkQg7q5HiJInB2Oghgck4qtqmkJrP7YA4VZ5VF499eg05zE-lxSE6TaRVoJLj0Lqp9MY6aanXFsZY2beLlRAv6mwhXpnZ6yx1zSuNRXx81HQNxHL2O_DyI_qb34mbqbWkxOjxdWpwZM1_LrBzpxjvTP-RyB4r6OjrtUQ5PPX5EYK5PFRoKbVAO7x5jR9zKBedKdF0XRwAyWqek9_J3u8TKxEg6E1e2RtSU29fZ0hBByQAQe16tIaXb5l-q3owuR51oJ_8QM1EfAb-GaOU7RklHNW-weK8jrQmceRk63OYgiMXy0lYxtRkrze2DuTK1NabhckVI6rtNZjDLs03tivAImXx--IGb5oSFYJxmTuJPuE-cGeyIDhIjXjmR_Z-GrgvL7FZ-=w1637-h919-no)

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

![GitHub Logo](https://lh3.googleusercontent.com/I5OHqQjTd10XAz7p0rk_LyiG40BG2lQR0vqpEn8V9vk6R9Gp0blkm0LBqyYi4ipA4sRwukbE1PzRapcFiE-s-3PPpzog8zvSwJC64hD0-y-60yr7W-gKrhLYSnnhs6xepiWC4E7GPoBmy26IBBzy5izt8u2EO5GtYepHDDKrD1W5mGF1vZdscWDYDl775Aorat2KdZuK-QIudoX-hCqBKOYykt1e00C0bEt1BnEbwv7L2pO-4qu9htfaEIGW9ewtMS6rp-2yrg8JO3WVaR4QKVIbyr8GDp9wpl0a0wcnEscW9_1kDm9LgnqxNY3rrme_vi_xcSvY2AUZ7Ogp5xgV_LO9RJPdamgwbh2bHelh038-YDtYTV8u3ztGRiSWAJbsDcHRlpO1M2HiRY7axo_SabdrRaTtjtqJ4SWVrStjWjb4dRhl3QsM5ii9NqXwv4wt_IphPd2HgYYBafSFCIda2oXurO2zh42Id2SdsvqDrWpo76lu3cuvhziGmpCcWUJrSoFX6V2jSmSOY5Ln_J6ZRivMdzCWzSz9I5Y9p40kGu-_0cL-qzCgMEqGAuw27GvtnMlTaDL0JWSwLn-sMHAcxIjWmWgr6Cprr5_wS-rw4O4Esdu7RmEDtUj_in0iaUUr7cnC6wWIzDzpX5ksgr01GpatlNxWCV3_2Do22umVnMP9w001U50v2FtF6MkOlCAQl3H48pqIeNqBQ8Kja639Mdr2=w424-h551-no)

![GitHub Logo](https://lh3.googleusercontent.com/kOMPRm--t1Nkh9qYb22aMk28Q_xFqP1-7kG7lWCPtisVZJbSaCAUel9mdLqb2i8uecVeZBQX0KjrHTUe0lWcUVZhHb8JQTYaHk1sKzjo9tpA0qhqKSFXyEs9QOECrYIBo6m9oICQkfTrcPiEb3gGVldskaHnl-kVkDn7R4lmJiGB5Z-1aXuPNkuv_5El1WbTGwBOvP6W3Z5Olt1gK96-cF0SJanlLGTWJeaRDBepXUPqgbmu3ZRFnygL_9zV7QN1OWVkC7eQOgRtIvrungrpFM6Anv6DpQqzJFNx6cZG14rBw0_HasRm8r39TBUlJe8fLyQLB60diSOpjhXyqU0AxP5_qA1wgIew8JTmNPSjHU4uDuv00-enRYf9JF6OowOVjsuNQbG4gTMKxWT_ddOl1xbJwvQYchgADpmT6ZG9CvzNB4qpZqHbKMYZ7RWgZ_EN_ZjuDiB8q4SnErB-sitiICxPELZAw5dmSMVY9-p1cMLuYziN7kdWiRNiZU35mljaDhwVQ2djpo728-UOtgLINrNArqWXf6LEz45eu5z5VsIoUbN0Q7wgyH2bDz0HFw6QTwdysAnHRIalIzKGepf4uWhosKYsT8PZ8gzwwdqtZAbkZeCmk_qFIsd9YPR_fECFPoCFKR95U5WbCkiHMUvc2IQGSa0SvsGvXXCdLF5hXDs2PpVNGFC5bj-P8ItaCKdwQbB_BU2kK1YPTYTPh44kFD5F=w399-h195-no)

------------------------------------

### Authors
Designed by #NVJOB Nicholas Veselov | https://nvjob.pro | http://nvjob.dx.am | https://twitter.com/nvjob

### License
This project is licensed under the MIT License - see the LICENSE file for details
