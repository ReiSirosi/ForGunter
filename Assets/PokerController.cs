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
            float distance = 50f; // расстояние, на которое будет перемещаться коллайдер
            float speed = 50f; // скорость перемещения коллайдера
            Vector3 startPos = poke.transform.position; // начальная позиция коллайдера
            Vector3 endPos = startPos + distance * poke.transform.TransformDirection(Vector3.forward); // конечная позиция коллайдера

            // двигаем коллайдер от начальной позиции к конечной с заданной скоростью
            float step = speed * Time.fixedDeltaTime;
            poke.transform.position = Vector3.MoveTowards(poke.transform.position, endPos, step);

            // если коллайдер достиг конечной позиции, меняем начальную и конечную позиции местами, чтобы он начал двигаться назад
            if (poke.transform.position == endPos)
            {
                Debug.Log("Конечная позиция pokera достигнута");
                Vector3 temp = endPos;
                endPos = startPos;
                startPos = temp;
            }
        }
    }

    private void letsPoke()
    {
        // задаем радиус для поиска коллайдеров
        float radius = 100f;

        // создаем массив для сохранения найденных коллайдеров
        Collider[] colliders = new Collider[10];

        // ищем коллайдеры в заданной сфере с центром в текущей позиции объекта, и сохраняем их в массив
        int numColliders = Physics.OverlapSphereNonAlloc(transform.position, radius, colliders, LayerMask.GetMask("Default"));

        // проходимся по найденным коллайдерам и ищем те, у которых тег "poker"
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