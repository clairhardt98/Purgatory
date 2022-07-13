using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public GameObject player;

    Animator ani_player;
    Rigidbody rbody;

    float timer;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        ani_player = player.GetComponent<Animator>();
    }

    bool state_dir = true;//false면 오른쪽 보고 있기, true면 반대
    bool ismove = false;
    // Update is called once per frame
    void Update()
    {
        ismove = false;

        if (Input.GetKey(KeyCode.D))
        {
            rbody.transform.Translate(Vector3.right * moveSpeed *Time.deltaTime);
            state_dir = true; ismove = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rbody.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            state_dir = false; ismove = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rbody.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            ismove = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rbody.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
            ismove = true;
        }
        if (ismove) ani_player.SetInteger("state", 2);
        else ani_player.SetInteger("state", 0);

        if (!state_dir) player.transform.localEulerAngles = new Vector3(290, 180, 0);
        else player.transform.localEulerAngles = new Vector3(70, 0, 0);

    }
}
