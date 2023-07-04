
using UnityEngine;

public class Ground_Tile : MonoBehaviour
{
    Ground_spaner groundspawner;
    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject dec_Coinprefab;
    [SerializeField] GameObject higherJumpPrefab;
    [SerializeField] GameObject fiveCoinsPrefab;
    [SerializeField] GameObject slowDownPrefab;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstacleChance = 0.2f;
    private void Start()
    {
        groundspawner = GameObject.FindObjectOfType<Ground_spaner>();
    }

    private void OnTriggerExit()
    {
        groundspawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }



    public void SpawnObstacle()
    {
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f, 1f);

        if(random < tallObstacleChance)
        {
            obstacleToSpawn = tallObstaclePrefab;
        }
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
    }



    public void SpawnObjects()
    {
        int coinsToSpawn = 7;
        int dec_coinsToSpawn = 2;
        GameObject randomPowerUp;
        int randomNumber;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());   
        }
        for (int i = 0; i < dec_coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(dec_Coinprefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
        randomNumber = Random.Range(0, 3);
        switch (randomNumber)
        {
            case 0:
                randomPowerUp = Instantiate(higherJumpPrefab, transform);
                randomPowerUp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
                break;
            case 1:
                randomPowerUp = Instantiate(slowDownPrefab, transform);
                randomPowerUp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
                break;
            case 2:
                randomPowerUp = Instantiate(fiveCoinsPrefab, transform);
                randomPowerUp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
                break;
            default:
                break;
        }
    }

    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
