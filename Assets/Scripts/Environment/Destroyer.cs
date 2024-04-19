using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Destroyer : MonoBehaviour
{

    public string parentName;

    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(60);
        // if (parentName == "Section(Clone)")
        // {
        //     Task.Delay(5000);
        //     Destroy(gameObject);
        // }

        while (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
            yield return new WaitForSeconds(5);
        }

    }
}