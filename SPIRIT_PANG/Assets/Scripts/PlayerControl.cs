using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Slider manaPoint_Slider;
    private Rigidbody2D rigidbody;
    public float speed = 300.0f;

    float h; //좌, 우
    float v; //위, 아래

    public GameObject fire;
    public GameObject skillShot;
    public Transform fireSpawn;

    public float fireRate;

    private float nextFire;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Debug.Log(manaPoint_Slider.value.ToString());
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(fire, fireSpawn.position, fireSpawn.rotation);
        }

        if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            if (manaPoint_Slider.value >= 100.0f)
            {
                nextFire = Time.time + fireRate;
                GameObject clone = Instantiate(skillShot, fireSpawn.position, fireSpawn.rotation);
                manaPoint_Slider.value -= 100.0f;
            }
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //이동
        Vector2 direction = new Vector2(h, v);
        rigidbody.velocity = direction * speed * Time.deltaTime;

        //플레이어 이동제한
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < -0.2f) pos.y = -0.2f;
        if (pos.y > 0.8f) pos.y = 0.8f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
