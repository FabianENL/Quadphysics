using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quad : MonoBehaviour
{
    public Rigidbody rigidody;

    public GameObject rt;
    public GameObject rb;
    public GameObject lt;
    public GameObject lb;

    public bool enable_all = false;
    public bool rt_enable;
    public bool rb_enable;
    public bool lt_enable;
    public bool lb_enable;

    public float rt_thrust = 1f;
    public float rb_thrust = 1f;
    public float lt_thrust = 1f;
    public float lb_thrust = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enable_all)
        {
            rt_enable = true;
            rb_enable = true;
            lt_enable = true;
            lb_enable = true;
            enable_all = false;
        }
        if (rt_enable)
        {
            rigidody.AddForceAtPosition((rt.transform.up * rt_thrust), rt.transform.position);
        }
        if (rb_enable)
        {
            rigidody.AddForceAtPosition((rb.transform.up * rb_thrust), rb.transform.position);
        }
        if (lt_enable)
        {
            rigidody.AddForceAtPosition((lt.transform.up * lt_thrust), lt.transform.position);
        }
        if (rb_enable)
        {
            rigidody.AddForceAtPosition((lb.transform.up * lb_thrust), lb.transform.position);
        }
    }
}
