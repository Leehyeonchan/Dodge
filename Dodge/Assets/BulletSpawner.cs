using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    // ������ ź���� ���� ������
    public GameObject bulletPrefab;
    // �ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;

    // �ִ� ���� �ֱ�
    public float spawnRateMax = 3f;

    // ���� ���� �ֱ�
    private float spawnRate;


    // �ֱ� ���� �������� ���� �ð�
    private float timeAfternoonspawn;

    // �߻��� ���
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0 ���� �ʱ�ȭ
        timeAfternoonspawn = 0;
        // ź�� ���� ������ spawnRateMin�� Max ���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);



        // playerControler ������Ʈ�� ���� ����
        // ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� 
        // ������
        target = FindObjectOfType<playerControler>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(bulletPrefab);
    }
}
