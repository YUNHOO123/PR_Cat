using JongWoo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JongWoo
{
    public class Weapon_Shoot : Weapon
    {
        //�ѱ�: �Ѿ��� �߻�Ǵ� ��ġ�� �ν����Ϳ��� ���������!
        [SerializeField] protected GameObject shotPoint;
        //�η��ǳ� �����츮 ����
        public float range;

        public GameObject bullet;



        public override void SetStatus() { }

        public override void Use()
        {
            Debug.Log("�л� ��� ���� ������");
        }

    }

}
