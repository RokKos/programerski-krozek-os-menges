using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Premikanje : MonoBehaviour
{
    public static void PremikGor(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.y += premik;
        telo.transform.position = pozicija;
    }

    public static void PremikDol(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.y -= premik;
        telo.transform.position = pozicija;
    }

    public static void PremikLevo(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.x -= premik;
        telo.transform.position = pozicija;
    }

    public static void PremikDesno(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.x += premik;
        telo.transform.position = pozicija;
    }

    public static void PremikNaprej(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.z += premik;
        telo.transform.position = pozicija;
    }

    public static void PremikNazaj(GameObject telo, float premik) {
        Vector3 pozicija = telo.transform.position;
        pozicija.z -= premik;
        telo.transform.position = pozicija;
    }

    public static void NastaviPozicijo(GameObject telo, Vector3 pozicija) {
        telo.transform.position = pozicija;
    }
}
