﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_parameter : MonoBehaviour{
	public int enemyHp;			//enemy HP
	public int enemySpeed;		//enemy HP

	//初期移動方向select
	public enum MoveStart{
		left = 0,
		right = 1
		}
	public MoveStart moveStart;

	//動き種類select
	public enum MoveType{
		stop = 0,
		advance = 1,
		pause = 2,
		round_trip = 3
		}
	public MoveType moveType;

	//弾の種類select
	public enum BulletType{
		straight = 0,
		howitzer = 1
	}
	public BulletType bulletType;

	public GameObject objModel;	//enemy1.csをアッタチしているオブジェクト用
	private enemy1 scrEnemy1;	//enemy1.csスクリプト入れる用
	public GameObject objEnemy;	//enemy1_move.csをアッタチしているオブジェクト用
	private enemy1_move scrEnemy1Move;//enemy1_move.csスクリプト入れる用

	void Start(){
		scrEnemy1 = objModel.GetComponent<enemy1>();
		scrEnemy1.enemyHp = enemyHp;		//enemy1.csに代入
		scrEnemy1Move = objEnemy.GetComponent<enemy1_move>();
		scrEnemy1Move.speed = enemySpeed;	//enemy1_move.csに代入
	}

	void Update(){
	}
}
