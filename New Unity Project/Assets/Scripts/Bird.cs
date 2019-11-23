using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 100;
    [Header("旋轉角度"), Range(0, 100)]
    public float angle = 10;
    [Header("是否死亡"), Tooltip("用來判斷角色是否死亡，true 死亡，false 還沒死亡")]
    public bool dead;
    [Header("剛體")]
    public Rigidbody2D r2d;
    public GameManager gm;

    public GameObject goScore, goGM;
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundAdd;


    private void Jump()
    {
        //if(dead == true)
        //{
        //    return;
        //}
        // 如果 死亡 跳出此程式區塊
        // 判斷式只有一行敘述可以省略大括號
        if (dead) return; // 簡寫

        // 如果 玩家 按下 左鍵
        // 輸入.按下按鍵(按鍵列舉.滑鼠左鍵) (手機觸控)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵");
            aud.PlayOneShot(soundJump, 1.5f);
            r2d.Sleep();
            r2d.WakeUp();
            r2d.gravityScale = 1;                // 小雞剛體.重力 = 1;
            r2d.AddForce(new Vector2(0, jump));  // 小雞往上跳
            goScore.SetActive(true);
            goGM.SetActive(true);
            // 分數 顯示
            // GM 顯示
        }
        //Rigidboby2D.SetRotation(float) 設定角度(角度)
        //Rigidboby2D.velocity 加速度 (二維向量 x, y)
        r2d.SetRotation(angle * r2d.velocity.y);

    }
    private void Dead()
    {
        print("死亡!!!");
        dead = true;
        gm.GameOver(); 
    }
    // 固定楨數 0.002 ;要控制物理請寫在此事件內
    private void FixedUpdate()
    {
        Jump();
    }

    // 事件;碰撞開始 - 碰撞開始實執行一次 (Collision2D hit) (碰撞類別 名稱)存放碰撞到
    private void OnCollisionEnter2D(Collision2D hit)
    {
        print(hit.gameObject.name);

        if (hit.gameObject.name == "地板")
        {
            Dead();
        }
    }

    // 事件;處發開始 - 物件必須勾選 IsTrigger
    private void OnTriggerEnter2D(Collider2D hit)
    {
        // 如果 碰到.物件名稱 為 上 或者 下 - 死亡
        if (hit.name == "水管-上" || hit.name == "水管-下")
        {
            Dead();
        }
    }
}