using UnityEngine;


public class CameraRig : MonoBehaviour
{
    public float rot = 1;
    public Transform ConditionalPlayer;

    Transform tr;
    float mouseV, mouseH;
    Vector3 startRot;

    void Awake()
    {
        tr = transform;
        startRot = ConditionalPlayer.localEulerAngles;
    }

    void Update()
    {
        tr.Rotate(Vector3.up, rot * Time.deltaTime);

        if (Mathf.Abs(Input.GetAxis("Mouse X")) + Mathf.Abs(Input.GetAxis("Mouse Y")) > 0.5f)
        {
            mouseH += 0.4f * Input.GetAxis("Mouse X");
            mouseV -= 0.4f * Input.GetAxis("Mouse Y");
        }
        ConditionalPlayer.localEulerAngles = startRot + new Vector3(Mathf.Clamp(mouseV, -20, 20), mouseH, 0);
    }
}
