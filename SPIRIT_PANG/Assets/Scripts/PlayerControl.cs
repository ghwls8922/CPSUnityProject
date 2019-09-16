using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float speed = 300.0f;

    float h; //좌, 우
    float v; //위, 아래

    public GameObject fire;
    public GameObject skillShot;
    public Transform fireSpawn;
    public float fireRate;
    public float skillRate;

    private float nextFire;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(fire, fireSpawn.position, fireSpawn.rotation);
        }

        else if (Input.GetButton("Fire2") && Time.time > nextFire)
        {
            nextFire = Time.time + skillRate;
            GameObject clone = Instantiate(skillShot, fireSpawn.position, fireSpawn.rotation);
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        
        //이동
        Vector2 direction = new Vector2(h, v);
        rigidbody.velocity = direction * speed * Time.deltaTime;

        //화면 밖으로 못나가게
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position); //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos); //다시 월드 좌표로 변환한다.
        transform.position = worldPos; //좌표를 적용한다.
    }
}
