
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JongWoo;

/*
namespace OHYEOM
{
    public class PlayerWeapon : IActiveable
    {
        public AttackStrategy AttackStrategy
        {
            get => attackStrategy;
            set
            {
                attackStrategy = value;
            }
        }
        private AttackStrategy attackStrategy;
    }


    public class Player : MonoBehaviour, IHitable
    {
        public Transform weaponSpot;
        bool isGrab;
        public bool IsStun
        {
            get => isStun;
            set
            {
                isStun = value;
            }
        }
        //public PlayerWeaponTest playerWeaponTest;

        [SerializeField]
        private bool isStun;


        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //playerWeaponTest.AttackStrategy.Attack(this);
            }
        }

        public void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out IActiveable activeable))
            {
                //playerWeaponTest.AttackStrategy = activeable.AttackStrategy;
            }
        }
        //WeaponController weapon;
        // AttackStrategy curStrategy;

        //private void OnTriggerStay(Collider other)
        //{
        //    if (other.TryGetComponent(out IGribable weapon))
        //    {
        //        if (weapon != null)
        //        {
        //            curStrategy = other.transform.GetComponent<Weapon>().strategy;
        //            other.transform.SetParent(weaponSpot);
        //            other.transform.position = weaponSpot.position;
        //        }
        //    }
        //}

        //private void Update()
        //{        

        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        GetComponent<Rigidbody>().AddForce(Vector3.forward * 100f, ForceMode.Impulse);            
        //    }
        //}

        //public void Attack()
        //{
        //    if (curStrategy != null)
        //        curStrategy.Attack();
        //    else
        //        Debug.Log("�ָ�");
        //}

        private void OnTriggerEnter(Collider other)
        {
            //if (other.gameObject.TryGetComponent(out Monster monster))
            //{
            //    // ���������� ����� AttackState ���� ������ ����
            //    // �ٵ����� ���������� Monster�� ������ �ִٸ�
            //    TakeDamaged(monster.attackStrategy);
            //}

            //if (other.gameObject.TryGetComponent(out Player player))
            //{
            //    // TakeDamaged()
            //}

            if (other.gameObject.TryGetComponent(out IActiveable activeable))
            {
                activeable.AttackStrategy.Attack(this);
                // Hit(activeable);            
            }
        }

        public void Hit(IActiveable activeable)
        {
            // activeable.AttackStrategy.Attack(this);
        }

        //public void TakeDamaged(MonsterAttackStrategy strategy) 
        //{
        //    strategy.Attack(this); // �Ű������� Player
        //}

        //public void Die()
        //{
        //    //animator.SetTrigger("DieTrigger");
        //    Debug.Log("������ ����");
        //    // ������� ó�� �����۾�
        //}    
    }
}


*/