using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfield : MonoBehaviour
{
    public GameObject[] StarfieldFabs;
    public GameObject[] AsteroidFabs;
    [SerializeField] List<GameObject> CelestialBodies = new List<GameObject>();

    public int numberOfBodies = 24;
    public float frequencyOfAsteroids = 2.0f;

    int fabsSize;

    // Start is called before the first frame update
    void Start()
    {
        fabsSize = StarfieldFabs.Length;
        for(int i = 0; i < numberOfBodies; i++)
        {
            Vector3 tempLoc = LocationRandom();
            GameObject tempObj = Instantiate(StarfieldFabs[(int)Random.Range(0,(StarfieldFabs.Length-1))], tempLoc, Quaternion.identity);
            tempObj.GetComponent<CelestialBodies>().startingPoint.x = tempLoc.x;
            tempObj.GetComponent<CelestialBodies>().startingPoint.y = tempLoc.y;

            CelestialBodies.Add(tempObj);
        }

        InvokeRepeating("SpawnAsteroid", 0.0f, frequencyOfAsteroids);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.position = LocationRandom();
    }

    Vector3 LocationRandom()
    {
        Vector3 location = Vector3.zero;
        location.x = Random.Range(-PSBoundariesOrthographic.screenBounds.x, PSBoundariesOrthographic.screenBounds.x);
        location.y = Random.Range(PSBoundariesOrthographic.screenBounds.y, (PSBoundariesOrthographic.screenBounds.y * 2));

        return location;
    }

    void SpawnAsteroid()
    {
        GameObject temp = Instantiate(AsteroidFabs[(int)Random.Range(0f, (AsteroidFabs.Length-1))], LocationRandom(), Quaternion.identity);
    }
}
