using UnityEngine;
using System.Collections;

public class Boss{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    //攻撃の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage; 
    }

    //魔法攻撃の関数
    public void Magic()
    {
        if(this.mp <5)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        } else
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
    }
}

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = { 4, 5, 6, 7, 8 };

        // 配列arrayの要素の値を順番に表示する
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列arrayの要素の値を逆順に表示する
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //魔法攻撃関数の使用
        Boss boss = new Boss();
        for(int i = 1; i <= 11; i++)
        {
            boss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
