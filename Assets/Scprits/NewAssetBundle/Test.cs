using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Instantiate(NewAssetBundleLoad.LoadGameObject("npc/demon/jushiguai/jushiguai_01"), Vector3.zero, Quaternion.identity);

	}
	
}
