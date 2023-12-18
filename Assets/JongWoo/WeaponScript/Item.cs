using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Temp
{        
    public class Item : MonoBehaviour
    {        
        public Transform grabPoint;
        public enum WEAPON_TYPE
        {
            DEFAULT,
            GUN,
            BAT,
            SWORD
        }
        
        //public WEAPON_TYPE WeaponType
        //{
        //    get => weaponType;
        //    set
        //    {
        //        Debug.Log("�ٲ�");
        //        weaponType = value;
        //        strategy = weaponDic[value];
        //    }
        //}
        //[SerializeField] private WEAPON_TYPE weaponType;

        public WEAPON_TYPE WeaponType;        
        public static Dictionary<WEAPON_TYPE, AttackStrategy> weaponDic;
        public AttackStrategy strategy;        
        public Weapon weapon;
        // �÷��̾ �ֿ��� �� weapon�� �÷��̾��� weapon���� �־��ش�.        

        private void Start()
        {            
            weaponDic = new Dictionary<WEAPON_TYPE, AttackStrategy>();
            weaponDic.Add(WEAPON_TYPE.DEFAULT, new DefaultStrategy());
            weaponDic.Add(WEAPON_TYPE.BAT, new BatStrategy());
            weaponDic.Add(WEAPON_TYPE.SWORD, new SwordStrategy());
            weaponDic.Add(WEAPON_TYPE.GUN, new GunStrategy());
            strategy = weaponDic[WeaponType];            
        }        
    }
}



