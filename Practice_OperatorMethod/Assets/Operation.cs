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
        result.text = "<color=#2A352A>"+ "蝙蝠" + "</color>" + "-受到傷害：" +slime.atk + "\n" 
                    + "<color=#2A352A>"+"蝙蝠" + "</color>" + "-血量剩下：" + bat.hp;
    }

    public void batcure()
    {
        bat.hp = bat.hp + bat.heal;
        result.text = "<color=#2A352A>"+"蝙蝠"+ "</color>" +"- 受到治癒：" + bat.heal+ "\n" 
                    + "<color=#2A352A>"+"蝙蝠"+ "</color>" +"- 血量剩下：" + bat.hp;
    }

    public void slimeatk()
    {
        bathurt();
    }

    public void slimehurt()
    {
        slime.hp=slime.hp-bat.atk;
        result.text = "<color=#848D13>"+"史萊姆"+"</color>"+"-受到攻擊：" + bat.atk+ "\n" 
                    + "<color=#848D13>"+"史萊姆"+ "</color>" + "-血量剩下：" + slime.hp;
    }

    public void slimecure()
    {
        slime.hp = slime.hp +slime.heal;
        result.text = "<color=#848D13>"+"史萊姆"+ "</color>" + "-受到治癒：" + slime.heal + "\n" 
                    + "<color=#848D13>"+"史萊姆"+ "</color>" + "-血量剩下：" + slime.hp;
    }


}
