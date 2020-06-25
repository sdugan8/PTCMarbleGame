using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    int counter;
    private Rigidbody rb;
    // private Fader fd;

    private float cd = 3f;
    private float cdt = 0f;
    private float height;
    public GameObject bar;
    public GameObject bar2;
    public GameObject bar3;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // fd = GetComponent<Fader>();

        counter = 0;


    }


    private void Update()
    {
        height = rb.transform.position.y;
        if (height < -5)
        {
            rb.MovePosition(new Vector3(0.8749752f, 1.14f, -20.86f));
        }


        if (cdt > 0)
        {
            cdt = cdt - Time.deltaTime;
        }


        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (cdt > 0)
            {

            }
            else
            {

                rb.AddForce(new Vector3(0, 10000, 0));
                cdt = cd;

            }



        }

    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);



        rb.AddForce(movement * speed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            counter = counter + 1;
            Debug.Log(counter);
            other.gameObject.SetActive(false);
        }




        if (counter == 9)
        {
            bar.gameObject.SetActive(true);
        }

        if (counter == 10)
        {
            bar2.gameObject.SetActive(false);
        }
        if (counter == 11)
        {
            SceneManager.LoadScene("HTP");

        }

    }
}
