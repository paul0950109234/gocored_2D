using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera cam;

    public AudioSource aud;

    private void Start()
    {
        // 使用靜態成員
        print("隨機 : " + Random.value);

        //使用 數學類別.PI (Mathf)
        print("PI : " + Mathf.PI);

        // 使用靜態成員 - 方法
        print("隨機範圍 : " + Random.Range(1, 10));

        print("絕對值 : " + Mathf.Abs(-99));

        // 非靜態成員
        // 需要先給予蘭為存放時體物件
        print("物件 A 的座標 : " + transformA.position);

        transformB.position = new Vector3(-2, 0, 0);
        transformB.Rotate(0, 0, 10);
        print("物件 B 的座標 : " + transformB.position);

        cam.depth = 10;
        print("攝影機深度:" + cam.depth);
        aud.Stop();
    }

    private void Update()
    {
        // 非靜態成員 - 方法
        transformB.Rotate(0, 0, 10);
    }
}
