
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;


    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    // frame will differ from computers
    void FixedUpdate()
    {//处理物理系统的时候使用fixed

        // 加上一个前置力
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);
       

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(rb.position.y < -0f)
        {
            this.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
