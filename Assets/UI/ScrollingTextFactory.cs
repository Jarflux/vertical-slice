using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Factory/ScrollingText")]
public class ScrollingTextFactory : ScriptableObject 
 {
    public GameObject scrollingTextPrefab;

    public void GetScrollingTextInstance(string message) {
        var instance = (GameObject)Instantiate(scrollingTextPrefab, new Vector3(0, 330, 0), Quaternion.identity);
        instance.transform.SetParent(GameObject.FindGameObjectWithTag("HUD").transform, false);
        instance.GetComponent<ScrollingTextUI>().SetMessage("+" + message);
    }

}
