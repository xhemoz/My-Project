using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float screenX;
    private float screenY;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        screenX = Screen.width / 2;
        screenY = Screen.height / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var lookTarget = new Vector3(screenX, screenY, 10f);
        lookTarget = cam.ScreenToWorldPoint(lookTarget);
        transform.LookAt(lookTarget);
        transform.rotation.SetLookRotation(lookTarget);
    }
}
