using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���ǉ�����i�|�C���g�j
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // �^�[�Q�b�g�̈ʒu��ړI�n�ɐݒ肷��B
        agent.destination = target.transform.position;
    }
}