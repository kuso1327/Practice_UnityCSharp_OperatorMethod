using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
{
    public Bat bat;
    public Bat slime;
    public Text result;

    public void batatk()
    {
        slimehurt();
    }

    public void bathurt()
    {
        bat.hp=bat.hp-slime.atk;
        result.text = "蝙蝠-受到傷害：" +slime.atk + "\n" 
                    + "蝙蝠-血量剩下：" + bat.hp;
    }

    public void batcure()
    {
        bat.hp = bat.hp + bat.heal;
        result.text = "蝙蝠-受到治癒：" + bat.heal+ "\n" 
                    + "蝙蝠-血量剩下：" + bat.hp;
    }

    public void slimeatk()
    {
        bathurt();
    }

    public void slimehurt()
    {
        slime.hp=slime.hp-bat.atk;
        result.text = "史萊姆-受到攻擊：" + bat.atk+ "\n" 
                    + "史萊姆-血量剩下：" + slime.hp;
    }

    public void slimecure()
    {
        slime.hp = slime.hp +slime.heal;
        result.text = "史萊姆-受到治癒：" + slime.heal + "\n" 
                    + "史萊姆-血量剩下：" + slime.hp;
    }


}
