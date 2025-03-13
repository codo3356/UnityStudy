using UnityEngine;

public class Player : MonoBehaviour
{
    //스피드
    public float moveSpeed = 5f;
    Animator ani;

    public GameObject bullet; // 총알은 4종류(파워업)일테니 4개 배열로 만들것
    public Transform pos = null;

    //아이템

    private int powerlvl;
    //레이저

    void Start()
    {
        ani = GetComponent<Animator>();
        powerlvl = 0;
    }

    void Update()
    {
        //방향키에 따른 웁직임
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetAxis("Horizontal") <= -0.5f)
            ani.SetBool("left", true);
        else
            ani.SetBool("left", false);

        if (Input.GetAxis("Horizontal") >= 0.5f)
            ani.SetBool("right", true);
        else
            ani.SetBool("right", false);

        if (Input.GetAxis("Vertical") >= 0.5f)
            ani.SetBool("up", true);
        else
            ani.SetBool("up", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //스페이스바 : 총알 발사
            //Instantiate(bullet, pos.position, Quaternion.identity);
            Shoot();
        }

        transform.Translate(moveX, moveY, 0);
        //캐릭터가 밖으로 나가지 않도록
        //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//다시월드좌표로 변환
        transform.position = worldPos; //좌표를 적용한다.

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemPower"))
        {
            if(powerlvl < 4)
            powerlvl++;
            Destroy(collision.gameObject);
        }

    }

    private void Shoot()
    {
        switch (powerlvl)
        {
            case 0:
                Instantiate(bullet, pos.position, Quaternion.identity);
                break;

            case 1:
                Instantiate(bullet, new Vector3(pos.position.x-0.1f ,pos.position.y,0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.1f, pos.position.y, 0), Quaternion.identity);
                break;

            case 2:
                Instantiate(bullet, new Vector3(pos.position.x - 0.2f, pos.position.y-0.2f, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x, pos.position.y, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.2f, pos.position.y-0.2f, 0), Quaternion.identity);
                break;

            case 3:
                Instantiate(bullet, new Vector3(pos.position.x - 0.3f, pos.position.y - 0.2f, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x - 0.1f, pos.position.y, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.1f, pos.position.y, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.3f, pos.position.y - 0.2f, 0), Quaternion.identity);

                break;

            case 4:
                Instantiate(bullet, new Vector3(pos.position.x - 0.4f, pos.position.y - 0.4f, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x - 0.2f, pos.position.y - 0.2f, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x, pos.position.y, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.2f, pos.position.y - 0.2f, 0), Quaternion.identity);
                Instantiate(bullet, new Vector3(pos.position.x + 0.4f, pos.position.y - 0.4f, 0), Quaternion.identity);
                break;
        }
            
    }



}
