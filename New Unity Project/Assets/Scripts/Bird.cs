using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("用來判斷角色是否死亡，true 死亡，false 還沒死亡")]
    public bool dead;

    /// <summary>
    /// 小雞跳躍方法。
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡方法。
    /// </summary>
    private void Dead()
    {

    }
}
