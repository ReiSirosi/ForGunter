using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerController : MonoBehaviour
{
    [SerializeField] private Collider poke;

    private bool isMoving = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isMoving)
            letsPoke();
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            float distance = 50f; // ����������, �� ������� ����� ������������ ���������
            float speed = 50f; // �������� ����������� ����������
            Vector3 startPos = poke.transform.position; // ��������� ������� ����������
            Vector3 endPos = startPos + distance * poke.transform.TransformDirection(Vector3.forward); // �������� ������� ����������

            // ������� ��������� �� ��������� ������� � �������� � �������� ���������
            float step = speed * Time.fixedDeltaTime;
            poke.transform.position = Vector3.MoveTowards(poke.transform.position, endPos, step);

            // ���� ��������� ������ �������� �������, ������ ��������� � �������� ������� �������, ����� �� ����� ��������� �����
            if (poke.transform.position == endPos)
            {
                Debug.Log("�������� ������� pokera ����������");
                Vector3 temp = endPos;
                endPos = startPos;
                startPos = temp;
            }
        }
    }

    private void letsPoke()
    {
        // ������ ������ ��� ������ �����������
        float radius = 100f;

        // ������� ������ ��� ���������� ��������� �����������
        Collider[] colliders = new Collider[10];

        // ���� ���������� � �������� ����� � ������� � ������� ������� �������, � ��������� �� � ������
        int numColliders = Physics.OverlapSphereNonAlloc(transform.position, radius, colliders, LayerMask.GetMask("Default"));

        // ���������� �� ��������� ����������� � ���� ��, � ������� ��� "poker"
        for (int i = 0; i < numColliders; i++)
        {
            Debug.Log(colliders[i].gameObject.tag);
            if (colliders[i].CompareTag("poker"))
            {
                isMoving = true;
                break;
            }
        }
    }
}