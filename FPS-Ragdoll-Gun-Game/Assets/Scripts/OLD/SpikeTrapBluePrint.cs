using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrapBluePrint : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    public GameObject prefab;

    void Update()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100.0f, layerMask))
        {
            transform.position = hit.point;

        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.transform.rotation *= Quaternion.Euler(0, 1, 0);
        }
    }
}
