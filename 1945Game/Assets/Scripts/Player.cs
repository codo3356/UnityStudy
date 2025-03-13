using UnityEngine;

public class Player : MonoBehaviour
{
    //���ǵ�
    public float moveSpeed = 5f;
    Animator ani;

    public GameObject bullet; // �Ѿ��� 4����(�Ŀ���)���״� 4�� �迭�� �����
    public Transform pos = null;

    //������

    private int powerlvl;
    //������

    void Start()
    {
        ani = GetComponent<Animator>();
        powerlvl = 0;
    }

    void Update()
    {
        //����Ű�� ���� ������
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
            //�����̽��� : �Ѿ� �߻�
            //Instantiate(bullet, pos.position, Quaternion.identity);
            Shoot();
        }

        transform.Translate(moveX, moveY, 0);
        //ĳ���Ͱ� ������ ������ �ʵ���
        //ĳ������ ���� ��ǥ�� ����Ʈ ��ǥ��� ��ȯ���ش�.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//�ٽÿ�����ǥ�� ��ȯ
        transform.position = worldPos; //��ǥ�� �����Ѵ�.

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
