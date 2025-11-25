using UnityEngine;

public class FiringObjects : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject objectPrefab;
    float timeUntilFire;    
    private void Update()
    {
        if (timeUntilFire < Time.time)
        {
            Shoot();
            timeUntilFire = Time.time + fireRate;
        }
    }
    void Shoot()
    {
        float angle = 0f;
        // random position in x axis for the fired object
        int randomNumber = Random.Range(0, 10);
        Vector3 randomPosition = firingPoint.position;
        randomPosition.x +=  randomNumber;

        Instantiate(objectPrefab, randomPosition, Quaternion.Euler(new Vector3(0f, 0f, angle)));

    }
}
