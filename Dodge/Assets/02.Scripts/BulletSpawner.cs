using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // 생성할 탄알의 원본 프리팹
    public GameObject bulletPrefab;
    // 최소 생성 주기
    public float spawnRateMin = 0.5f;

    // 최대 생성 주기
    public float spawnRateMax = 3f;

    // 실제 생성 주기
    private float spawnRate;

    private float timeAfterSpawn;


    // 최근 생성 시점에서 지난 시간
    private float timeAfternoonspawn;

    // 발사할 대상
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // 최근 생성 이후의 누적 시간을 0 으로 초기화
        timeAfternoonspawn = 0;
        // 탄알 생성 간격을 spawnRateMin과 Max 사이에서 랜덤 값 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);



        // playerControler 컴포넌트를 가진 게임
        // 오브젝트를 찾아서 그 오브젝트의 위치값을 
        // 가져와
        target = FindObjectOfType<playerControler>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        // TimeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if(timeAfterSpawn >= spawnRate)
        { 

        // bulletPrefab의 복제본을 transform.position
        // 위치와 transform.retation 회전으로 생성
            GameObject bullet =  Instantiate(bulletPrefab,transform.position,transform.rotation);
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            timeAfterSpawn = 0f;
            // 생성된  bullet 게임 오브젝트의 정면 방향이
            // target을 정하도록 회전

            // bullet.transform.LookAt(target);

            // float time = Time.deltaTime;
        }
    }
}
