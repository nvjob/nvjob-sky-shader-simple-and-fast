# NVJOB Sky Shader - simple and fast.

Version 2.1

Simple and fast sky shader. For the shader to work properly, a dome model with prepared UV is required. Model of the dome can be taken from the example.

https://www.youtube.com/watch?v=5PywefSMZpk

![GitHub Logo](https://lh3.googleusercontent.com/hrWXHfBo4Kg9pduvIY_kJA3ywlIhz6lTxEbSzCANLwZLqaVTWZG3zMPri9jW88y31mCWU5x8wMiAlQwau4kPbOgX0fSr2E3dXPB6yue7lJFnSarWxNlK7LvXTkWT1cjDmiaECRRKN3UO63H2dlhP87lV6oCvpR5syn7-ZVC47xOSDPci2cEQ0Ocn007L2E95vCGDQ_PoRkthwePYOMbn2_7iO_wq7ARNq90CqdfJucB0ZVsXX924sWGA11pVjMpmznvt2WNmgRF7akFyhwLhyaeS8sB78uxmkcQXxuaYHt2jCc0aYi3qRwQX7C7tYwAgwQ20KaUnF3QbZex9AJueD5ji_G5fs9Are3MiOIpyZ0zSHNbFUo-qoRb6hdRR_SpdenNPG4ptommknrzExNPkQq1QM0HEcr-3B5p72IVQqAqXxz_sMz4wzaAHblmuo2dZq-p_U8MsjkqOxeiKV71Z82Ez5DPsSxAxSLIDSqX1GbY_EE7Yjmkjc9nte0yQKfbTCf-XKo5PkUPIhJ9aBCoO_2JGvBlnmbn6ElNsjHs1MqA4ulGQvU0UYz8aqfxbHcO71knwcH4co3Iowt4DtxCvxvhV4u84qZwjmEHhIxnDs1MlPTAkeMcSYLW6syBU48LKEvmP5eJG_8vPp51sRtJu90s8OnpZHP4=w1741-h979-no)

![GitHub Logo](https://lh3.googleusercontent.com/Reo2Jm92pLDVUTul7kdhU9yY1-zrBguqdIR2nQDaQmwObAQ3RDGfUn_nv--gIh-Gl-zbF6gXUwu_2-5busReqjm2kOTx8Td5Hygnf_F-K71Oc1bVPUetbvN3jA5_ov7sxDlAfsFhu-sy5FCy6WaqT46zgj3DIdcMTVsxhmlbv-MZjf8WMh78eSlolFxMeknXtgy4jaId_LvGlGRTpiBA3YWDMM64MSYSZUUBb0qp0dbtqc2AYTd8pA-lANw9K-RL2Y9i2f-LViDgPpcYlf7kPkOaKNZQaW5oDG8EYlGlfvOoTqXrk7Gkp3MPgghtT64l8tiK-06dXZvT8d81Jbml8mJ2ZCOaUNHigBeX3oneBqCJRF1oddaeznckfyOvM0UWpASga9tGozHc09-D0utme1OQbQ2DZKtkROybsVU6kAcSNzVeaBkxoe1z4ojdz8nyMpYg9ZRX4fUX5gVaToZuDgcGlv5pARrR3DtzqDURl5cTsLfrs-_kow8p1xkDtiWJhUfFbeSg51NldKkk1z0qoz1qjE_3SeSHg4DpSceAgH2uWCUFW2kOHIxk8x1gfx6sExH2cUdKOU5VYX5Pfe3g6yxLr3puINaPCiY2eayLWnVU2g4GUI7B9Gv-mDfyTYS2O9uJXZ0P42VsuFD6UIUQMzGChwt4XAI=w1741-h979-no)

![GitHub Logo](https://lh3.googleusercontent.com/sF5r7fJ4aOstepqzLx50epmCbXaYcmNRYIcxPqFbkKzxLTo2pSFnualOz6HIikbVJpKposZKBp2xdW8I6wYlgKkVfw-khDslu0urc8wL67QMwpxnuKKC_3HbgSYbITrZXXDWyw9I-J6X6BooEYxS3Xlc-ryqx9dYNE09XStarQGONMpamNn-DLvJm8AHd34FCdLCzW6eS7k9fCobLb9iBG7__uYsYLT8Y2tCAt93qpE-E_A2iafXQgzC1Til1SmYC-iuvccCFz0D0ljmaRKWsp_tVWr9xoGnsSg5pyE9GvpD9eT1U1uK2fJM8v8SmiVEBPvWSeglX42OifU5n7WTDsnwYemLQi7wwt2_TcyafE_9DrI3DKYI5Gvz1kDpdruyG0uZHl3xS6WPlq8EnyFG9mHDH7I9-N4vu-1HUX48YSERff-wVqXZfCjmh9wVsknZ9EbdlYzfZ-zAbEw681xlkWkRsl-B-zdYIfjqW0Kj4V5AsmwZ58cEBsDgc_Eo9c49X20SCP4Amk7TfEa_e3nq8Ntj7WG1DKGu7EtDOeibYFwJi7f8KG4IQljxZhE1y0q3DGvODdAx3cnmiQmNohtSgr2U49yktj2oTRfjAw0PugCPjlDxx46DIR64KNdcPDnzA4x-yDtRtdsj1UN8WH6OJQsd6Yp1yIg=w1741-h979-no)

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

### Donate
You can thank me by a voluntary donation. https://nvjob.pro/donations.html
