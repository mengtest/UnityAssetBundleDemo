using UnityEngine;
using System.Collections;
using UnityEditor;

public class OldAssetBundleDependence : MonoBehaviour
{
    [MenuItem("AB Editor/Create Dependence AssetBunldes")]
    public static void Pack()
    {
        string path = Application.dataPath + "/StreamingAssets";
        BuildTarget target = BuildTarget.StandaloneWindows64;
        BuildAssetBundleOptions op = BuildAssetBundleOptions.CollectDependencies | BuildAssetBundleOptions.CompleteAssets | BuildAssetBundleOptions.DeterministicAssetBundle;
        // (
        BuildPipeline.PushAssetDependencies();
        // A
        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Materials/green.mat"), null, path + "/green.assetbundle", op, target);
        // (
        BuildPipeline.PushAssetDependencies();
        // B
        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Prefab/Cube1.prefab"), null, path + "/Cube1.assetbundle", op, target);
        // )
        BuildPipeline.PopAssetDependencies();
        // (
        BuildPipeline.PushAssetDependencies();
        // C
        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Prefab/Cube2.prefab"), null, path + "/Cube2.assetbundle", op, target);
        // )
        BuildPipeline.PopAssetDependencies();
        // )
        BuildPipeline.PopAssetDependencies();
    }
    
}
