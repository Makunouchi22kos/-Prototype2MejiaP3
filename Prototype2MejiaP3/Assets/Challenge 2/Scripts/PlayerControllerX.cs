using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool _isTriger = true;
    private float _interval = 3f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isTriger)
            {

                _isTriger = false;

                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                Invoke("GoGetIt", _interval);
            }

        }
    }

    private void GoGetIt()
    {
        _isTriger = true;
        CancelInvoke();
    }

}
