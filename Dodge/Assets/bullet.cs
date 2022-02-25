using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{

    // �̵��� ����� ������ٵ� �����ͤ���
    private Rigidbody bulletRigidbody;
    //ź�� �̵� �ӷ�
    public float speed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ��
        // ã�� bulletRigidbody�� �Ҵ�

        bulletRigidbody = GetComponent < Rigidbody>();

        // ������ٵ��� �ӵ� = ���� ���� = �̵� �ӷ� ; 
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject,3f);

     

}
    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� player �±׸� ��������?

        if(other.tag=="Player")
        {
            // ����(�浹��) ���� ������Ʈ����
            // playerController ������Ʈ ��������
            playerControler playerController =
                other.GetComponent<playerControler>();

            // �������κ��� playerController ������Ʈ��
            // �������µ� �����ߴٸ�

            if(playerController != null)
            {
                // playerController ������Ʈ��
                // Die() �޼��� ����
                playerController.Die();
            }


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
