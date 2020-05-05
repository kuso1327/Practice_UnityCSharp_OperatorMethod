using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    public int hp;
    public int atk;
    public int heal;

    #region 老師的作法
    /*
    [Header("顯示訊息")]
    public Text message;
    [Header("史萊姆")]
    public Slime slime;

    private float Hp = 150;
    private float Atk = 50;
    private float cure = 20;


    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        slime.Damage(Atk);
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">要接受的傷害值</param>
    
    public void Damage(float damage)
    {
        Hp -= damage;//Hp=Hp-damage
        message.text = "<color=#243224>"+gameObject.name +"</color>"+ "-受到傷害" + damage;
        message.text += "\n" + gameObject.name + "-血量剩下" + damage;
    }
    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        Hp += cure;
        message.text = gameObject.name + "-受到治癒" + cure;
        message.text += "\n" + gameObject.name + "-血量剩下" + cure;
    }
    */
    #endregion








}
