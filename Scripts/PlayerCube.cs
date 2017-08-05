using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCube : MonoBehaviour {
    public GameObject obj;
    public float speed;
    private bool Ismove;
    Vector3 moven = new Vector3();

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Ismove = true;
            moven = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Ismove = true;
            moven = Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Ismove = true;
            moven = Vector3.right;
        }
        if (Ismove) move(moven);
    }
    private void FixedUpdate()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter" + other.name);
        Time.timeScale = 0;
    }
    void move(Vector3 move) {
        gameObject.transform.Translate(move * Time.deltaTime * speed, Space.Self);
        Vector3 gamepost = gameObject.transform.position;

        GameObject.Instantiate(obj, gamepost, Quaternion.identity);
    }
}
