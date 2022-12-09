using UnityEngine;
using CreatorKitCode;

public class SpawnerSample : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    

    void Start()
    {
        Vector3 spawnPosition = transform.position;

        LootAngle myLootAngle = new LootAngle(45);
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());
        SpawnPotion(myLootAngle.NextAngle());

        //Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //spawnPosition = transform.position + direction * radius;
        //Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //angle = 55;
        //direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //spawnPosition = transform.position + direction * radius;
        //Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //angle = 95;
        //direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //spawnPosition = transform.position + direction * radius;
        //Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);

        //angle = 135;
        //direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        //spawnPosition = transform.position + direction * radius;
        //Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
    }

    void SpawnPotion(int angle)
    {
              
        int radius = 5;
        Vector3 spawnPosition = transform.position;

        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
        spawnPosition = transform.position + direction * radius;
        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
               
    }
}

public class LootAngle
{
    int angle;
    int step;
    public LootAngle(int increment)
    {
        step = increment;
        angle = 0;
    }

    public int NextAngle()
    {
        int currentAngle = angle;
        angle = Helpers.WrapAngle(angle + step);

        return currentAngle;
    }
}

