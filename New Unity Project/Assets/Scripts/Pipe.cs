using UnityEngine;
//繼承:可以享有繼承欸別的成員
public class Pipe : Ground
{
    private void Start()
    {
        // gameObject 指的是彼此欸別的遊戲物件
        // 刪除(物驗,延遲時間)
        //Destroy(gameObject, 2f);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 1f);
    }

    // 在攝影機面內的時候會執行一次
    private void OnBecameVisible()
    {
        
    }

}
