using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab del enemigo a spawnear
    public float spawnTime; // Tiempo entre cada spawn
    public float startingSpawnTime = 3f;
    public float spawnTimeDecrease = 0.05f;
    private float timer; // Contador para el tiempo transcurrido

    public Transform[] spawns;

    // Método que se ejecuta en cada frame
    private void Update()
    {
        int num = Random.Range(1,100);

        int resultado = num % spawns.Length;

        // Decrementamos el tiempo de spawn de forma gradual a medida que pasa el tiempo
        spawnTime = Mathf.Max(startingSpawnTime - (spawnTimeDecrease * Time.time), 0.5f);

        // Incrementamos el contador
        timer += Time.deltaTime;

        // Si el contador supera el tiempo de spawn, creamos un nuevo enemigo y reseteamos el contador
        if (timer >= spawnTime)
        {
            Instantiate(enemyPrefab, spawns[resultado].position, Quaternion.identity);
            timer = 0f;
        }
    }

}
