using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateSuspension : MonoBehaviour
{

    public Button prefabButton;
    public GameObject objPrefab;

    // Use this for initialization
    void Start()
    {
        Button prefabBtn = prefabButton.GetComponent<Button>();

        prefabBtn.onClick.AddListener(InstantiateMethod);
    }

    void InstantiateMethod()
    {
        var objClass = (GameObject)Instantiate(objPrefab, new Vector3(-8.5F, 6.5F, 7), Quaternion.identity);
        objClass.transform.Rotate(0, 180, 0);
        objClass.transform.localScale += new Vector3(5, 5, 5);

    }
}
