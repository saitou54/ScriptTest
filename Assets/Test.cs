using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int mp = 53;	// 魔力

	// 魔法攻撃用の関数
	public void Magic()
	{
		if (this.mp >= 5)
		{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
		else
		{
			Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// int型配列arrayの宣言と初期化
		int[] array = {10, 20, 30, 50, 80 };

		// arrayの各要素を順番に表示する
		for (int i = 0; i < array.Length; i++)
		{
			Debug.Log(array[i]);
		}
		// arrayの各要素を逆順に表示する
		for (int i = array.Length - 1; i >= 0; i--)
		{
			Debug.Log(array[i]);
		}


		// 発展課題
		// Bossクラス変数の宣言とインスタンスの代入
		Boss boss = new Boss();
		// 攻撃用の関数を11回呼び出す
		for (int i = 0; i <= 10; i++)
		{
			boss.Magic();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
