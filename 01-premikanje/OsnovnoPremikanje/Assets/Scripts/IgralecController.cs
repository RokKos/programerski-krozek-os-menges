using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgralecController : MonoBehaviour
{
    [SerializeField] float hitrost = 1.5f;
    [SerializeField] Vector3 zacetna_pozicija = new Vector3(0, -2, 0);

    // Start is called before the first frame update
    void Start()
    {
        Premikanje.NastaviPozicijo(gameObject, zacetna_pozicija);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Premikanje.PremikGor(gameObject, hitrost * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            Premikanje.PremikDol(gameObject, hitrost * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            Premikanje.PremikLevo(gameObject, hitrost * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            Premikanje.PremikDesno(gameObject, hitrost * Time.deltaTime);
        }
    }
}
