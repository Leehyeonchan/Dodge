using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    //이동에 사용될 리지드바디 컴포넌트
     public Rigidbody playerRigidbody;
    // 이동  속력
    public float speed = 4f;

    public GameObject my;

    // Start is called before the first frame update
    void Start()
    {
        //  게임 오프젝트에서  Righidbody 컴포넌트를 찾아
        // playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }


   
    // Update is called once per frame
    void Update()
    {
        // 수평축과 수직축의 입력값을 감지해서 저장
        float xInput = Input.GetAxis("Horizontel");
        //  키보드 : 'A', < - : 음의 방향 : -1 0f
        //  키보드 : 'D'  , ->: 양의 방향 : +1 0f
        float zInput = Input.GetAxis("vertical");
        // 키보드 "W" , : ^ 양의 방향 : +1 , 0f
        // 키보드 : 'S' : (아래키) : 음의 방향 : -1 , 0f

    }




    // dd
    void Directinput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)

        {
            //  위쪽 방향키 감지된 경우
            playerRigidbody.AddForce(0f, 0f, speed); // x, y,z  를 뜻함
        }


        if (Input.GetKey(KeyCode.DownArrow) == true)

        {//  아랫쪽 입력 방향키 감지된 경우
            //  z 방향으로 힘주기
            playerRigidbody.AddForce(0f, 0f, -speed); // x, y,z  를 뜻함
        }


        if (Input.GetKey(KeyCode.LeftArrow) == true)

        {
            //  왼쪽 방향키 감지된 경우
            playerRigidbody.AddForce(-speed, 0f, 0f); // x, y,z  를 뜻함
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)

        {//  오른쪽 방향키 감지된 경우
            // x 방향 힘주기
            playerRigidbody.AddForce(speed, 0f, 0f); // x, y,z  를 뜻함
        }
    }





    void Die()
    {
        my.SetActive(false);
        gameObject.SetActive(false);
    }
}
