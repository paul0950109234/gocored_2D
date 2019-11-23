using UnityEngine;
using UnityEngine.UI;     // 引用 介面 API


public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最高分數")]
    public int scoreHeight;
    [Header("水管")]
    // GameObjet 可以存放場景上的遊戲物件與專案內的預置物
    public GameObject pipe;
    [Header("遊戲結束畫面")]
    public GameObject goFinal;
    [Header("遊戲結束")]
    public static bool gameOver;
    [Header("分數介面")]
    public Text textScroe;

    // 修飾詞權限：
    // private 其他類別無法使用
    // public 其他類別可以使用

    /// <summary>
    /// 加分。
    /// </summary>
    public void AddScore()
    {
        score++;
        // 分數介面.文字內容 = 分數.轉為字串()
        // To
        textScroe.text = score.ToString();
    }
    
    /// <summary>
    /// 最高分數判定。
    /// </summary>
    private void HeightScore()
    {

    }

    /// <summary>
    /// 生成水管。
    /// </summary>
    private void SpawnPipe()
    {
        print("生水管~");
        // 生成(物件);
        //Instantiate(pipe);

        // 生成(物件,座標,角度)
        float y = Random.Range(-1.2f, 1.2f);
        // 區域欄位(不需要修飾詞)
        Vector3 pos = new Vector3(10, y, 0);

        // Quaternion.identity 代表零角度
        Instantiate(pipe, pos, Quaternion.identity);

    }

    /// <summary>
    /// 遊戲失敗。
    /// </summary>
    public void GameOver() 
    {
        goFinal.SetActive(true);     // 顯示結算畫面
        gameOver = true;             // 遊戲結束 = 是
        CancelInvoke("SpawnpPipe");  // 停止 InvokeRpeating' Invoke 的方法
    }

    private void Start()
    {
        // 重複調用("方法名稱",開始時間,間隔時間)
        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}
