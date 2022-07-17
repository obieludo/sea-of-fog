using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arms : MonoBehaviour
{
    int speed = 300;
    public Rigidbody2D rb;
    public Camera cam;
    public KeyCode mousebutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = new Vector3(cam.ScreenToWorldPoint(Input.mousePosition).x, cam.ScreenToWorldPoint(Input.mousePosition).y, 0);
        Vector3 difference = playerpos - transform.position;
        float rotation2 = Mathf.Atan2(difference.x, -difference.y) * Mathf.Rad2Deg;
            if (Input.GetKey(mousebutton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, rotation2, speed * Time.fixedDeltaTime));
        }
    }
}
