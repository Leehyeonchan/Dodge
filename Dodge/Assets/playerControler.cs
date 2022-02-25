using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    //�̵��� ���� ������ٵ� ������Ʈ
     public Rigidbody playerRigidbody;
    // �̵�  �ӷ�
    public float speed = 4f;

    public GameObject my;

    // Start is called before the first frame update
    void Start()
    {
        //  ���� ������Ʈ����  Righidbody ������Ʈ�� ã��
        // playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }


   
    // Update is called once per frame
    void Update()
    {
        // ������� �������� �Է°��� �����ؼ� ����
        float xInput = Input.GetAxis("Horizontal");
        //  Ű���� : 'A', < - : ���� ���� : -1 0f
        //  Ű���� : 'D'  , ->: ���� ���� : +1 0f
        float zInput = Input.GetAxis("Vertical");
        // Ű���� "W" , : ^ ���� ���� : +1 , 0f
        // Ű���� : 'S' : (�Ʒ�Ű) : ���� ���� : -1 , 0f

        // ���� �̵� �ӵ��� �Է°���
        // �̵� �ӷ��� ����� ����
        float xSpeed = xInput = speed;
        float zSpeed = zInput = speed;

        // Vector 3 �ӵ��� (xSpeed,0f,zSpeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        // ������ٵ��� �ӵ��� newvelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }




    // dd
    void Directinput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)

        {
            //  ���� ����Ű ������ ���
            playerRigidbody.AddForce(0f, 0f, speed); // x, y,z  �� ����
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)

        {//  �Ʒ��� �Է� ����Ű ������ ���
            //  z �������� ���ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed); // x, y,z  �� ����
        }


        if (Input.GetKey(KeyCode.LeftArrow) == true)

        {
            //  ���� ����Ű ������ ���
            playerRigidbody.AddForce(-speed, 0f, 0f); // x, y,z  �� ����
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)

        {//  ������ ����Ű ������ ���
            // x ���� ���ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f); // x, y,z  �� ����
        }
    }
    
    



    public void Die()
    {
        my.SetActive(false);
        gameObject.SetActive(false);
    }
}
