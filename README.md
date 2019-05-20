# NVJOB Sky Shader - simple and fast.

Version 1.2

Simple and fast sky shader. For the shader to work properly, a dome model with prepared UV is required. Model of the dome can be taken from the example.

![GitHub Logo](https://lh3.googleusercontent.com/FjFtU3HDS82yE2PJbN4DoyoxiZNew7MGML4JCHngUa8kBkqfRZY06PGlFckNd4ilMNrRAJh6fX9ElMFo9zogk5zmAhmjsrmzZeA_Xrzwaay7Y9v_Qfa6r5MFzUPQkaBx4PHAZ6356l-V4SFTx7gspOpq3TohDEExUsJYIfCcYdY2irxCHagMN9OW4J3Ch45siz3CKFWfDYDVOQoz5WPF9ZZf3CPE1SH7ELd8kOMgTWLBWVkkHyykSvBeKyFO_7rB9mF1jcEAiXosYtMo3hOFYvpMJWN-JFBimg__gSOFoRbbhEf4CGj_YyxjYhWqqMtW0RwM4CzjbZUB9-MX4mx068RtC0b9FfG8k74VH3Er1Y5luZUzn65rnFug3WW2xovIvmpOgn8-Gdk6W22MMwKLozVp5hMMykacq37dhzArNX_5KzQ7fSiyRsI6syrjJAJt2COFEmMoffrBavEZFA08WSKuC23pVtPfctFbUrmjX-1hxOSyJQAhYoiO4GOvfdNVUZr_juVmINJEuK_SnfecRDHvsci6l7ZM3QuwxGagFEHxmuHcfp34JrJ9rcBH3Z61GQJGihoXB_4Noqeie77uFcZpXN-vGFf6RJ4HpDALl2Hf8FGy5NJ1srm-F3BONkw7-NxBw5vk3TwVdLpZK-Ug5TMsm1Qm_28hPl1vqJTgfW9aVSrf16VEJ-diMYK38oAwGpd9mTbxu3eGxk_ZKVwybNga=w1630-h908-no)

![GitHub Logo](https://lh3.googleusercontent.com/mqzBuKqEZFv4ZP_g-rs0LGlRLC_J3ieBPcP1XjFmmhMTWgr-xMl5YQpi97YaNdRkyEZ31ZPMivYgKfQZ_qeodoW_xWwvXRb3AXAaLBqEkpAwyaFN8lGdS5ZQ3IxBBDcruEV56sRP2FtYA860oBzdMsBlWCxR3qlL2-zBL3GGLGrGKWy0qF6pDgk6rdJL-V8sRp_t-y0n1fHV-B0ABUWECcrEHzjq83EMrCi9OGNR3TJf7ihGpz3Mj6IzTnySWo91fwHj4eWCk2vw1UPgjSmKMu5elNDSiDknlfJLx195YI19gZhoymzvBuFW7DLy4EY6-CaRdAeKozQ0V14jChRWrXtswcam2XjW5jE2mCxu5nDYH_v3FuxZGKFYIArVRvw5VeXZHnVdqKcKzIgaiSfiV7f5rn5SKwKPDoPszYgVup-YSjcwK5Wh4xTYQuw6GeQ54Le-WgG1-Wy6XCw_CzUSx4EoTph1C8HUlebDYgmzOjF0OZbmvDQEidZogHglNHvS_Hu7fttonawGPyvNwN_b9GPkjbALSP83mzD_4n20xmBRWldAb0w7GrL-OTMhCXqdF-7_l4D1fgBp6rYI3ITs9v9CjCBUZaZRq4ppJezZiV3hIF5Uzl_2V6S7UdaQk0kve2zXhef9-6PLifgOY7ql-XjU0STG8U1OwRx-EqTd9Gu0hM3wTfrnIsiSu10AU_S5O7siPNcoT5vDEHeyjVhkp5RY=w1630-h908-no)

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

![GitHub Logo](https://lh3.googleusercontent.com/gUIt5znM_d9WtsvAOoYrmD03WbwcsD-4z1VybD0hgyiJgYy9WVdq8D70A5rXMXc0EjwI6u8NCtUAMxHJHsgevTbEePKPYwaPtE2meKRco5CwPJm8-2UhMRFiGq0XH3VOIORwFrQZRG6HZb2eLN5cIE4vUeqd-m8aTsK5e1R_hLHkIIkPXLgg5FHzZK9WhO8-_qSsBKpDOMP6iMb-8AwbrE07JzOjK8uQ9BDS0J8QYsQy3pma4P67NM7176ujgS2qJ-igPtKAKtuMCFmN8b0gP6ajTjOpxpOKE_9YoS731wM6riarMMcynVXu9y0hNkh58HkUgMK8Rf5_GKen4cALCZcrfRF9rh5KDwBlix8CxiuKXhYBk_Ubmwv6z4Q44X5IweIajZ2zrGBxfVPCGjgvsNM0lSVf9qYIWY6c4wIDXaRcyBbjO03YROWx1FjT1H6Kd720QiYzXpUAbZEGBgKUrRy7ZSjhTpqWdL1uzi1nJ22-SrpVASYZJBjAD2zlNsRzqJdGLvELa7tU3wUhVDwsfXjjLLdYWv5FQPo6-e0Lt7Dy0ofulTglt-_MaqM3OxrJqBgZs4DItBn36194F4Vy3YCzZcKdDKXPq_93gpuVKlNpez79omknzQ5nhkE5u9Rmc85o-qYuTn1LpufBBfNR0rOrNkP767FmQadO0QG_fMyNFYQsr_w--abDflxMXjC5Q603zyT3enwaWmI7nsz4izl5=w401-h372-no)

![GitHub Logo](https://lh3.googleusercontent.com/kOMPRm--t1Nkh9qYb22aMk28Q_xFqP1-7kG7lWCPtisVZJbSaCAUel9mdLqb2i8uecVeZBQX0KjrHTUe0lWcUVZhHb8JQTYaHk1sKzjo9tpA0qhqKSFXyEs9QOECrYIBo6m9oICQkfTrcPiEb3gGVldskaHnl-kVkDn7R4lmJiGB5Z-1aXuPNkuv_5El1WbTGwBOvP6W3Z5Olt1gK96-cF0SJanlLGTWJeaRDBepXUPqgbmu3ZRFnygL_9zV7QN1OWVkC7eQOgRtIvrungrpFM6Anv6DpQqzJFNx6cZG14rBw0_HasRm8r39TBUlJe8fLyQLB60diSOpjhXyqU0AxP5_qA1wgIew8JTmNPSjHU4uDuv00-enRYf9JF6OowOVjsuNQbG4gTMKxWT_ddOl1xbJwvQYchgADpmT6ZG9CvzNB4qpZqHbKMYZ7RWgZ_EN_ZjuDiB8q4SnErB-sitiICxPELZAw5dmSMVY9-p1cMLuYziN7kdWiRNiZU35mljaDhwVQ2djpo728-UOtgLINrNArqWXf6LEz45eu5z5VsIoUbN0Q7wgyH2bDz0HFw6QTwdysAnHRIalIzKGepf4uWhosKYsT8PZ8gzwwdqtZAbkZeCmk_qFIsd9YPR_fECFPoCFKR95U5WbCkiHMUvc2IQGSa0SvsGvXXCdLF5hXDs2PpVNGFC5bj-P8ItaCKdwQbB_BU2kK1YPTYTPh44kFD5F=w399-h195-no)

------------------------------------

### Authors
Designed by #NVJOB Nicholas Veselov | https://nvjob.pro | http://nvjob.dx.am | https://twitter.com/nvjob

### License
This project is licensed under the MIT License - see the LICENSE file for details
