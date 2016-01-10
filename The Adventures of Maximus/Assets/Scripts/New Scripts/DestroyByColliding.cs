using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Xml;

public class DestroyByColliding : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
