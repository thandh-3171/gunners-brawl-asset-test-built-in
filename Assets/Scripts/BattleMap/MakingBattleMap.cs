using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MakingBattleMap : MonoBehaviour
{
    #region serialized
    #endregion

    #region private vars    
    #endregion

    #region mono
    /// <summary>
    /// Awake is called first when runtime starts.
    /// </summary>
    private void Awake() { SetComponents(); }

    /// <summary>
    /// OnEnable is called when this script's enable-status is on.
    /// </summary>
    private void OnEnable() { SubscribeCallbacks(); }

    /// <summary>
    /// Start is called before the first frame update.
    /// Leave it (not removing) to enable manually pre-runtime.
    /// </summary>
    private void Start() { }

    /// <summary>
    /// Update is called once per frame. Must remove if empty.
    /// </summary>
    /// private void Update() { }

    /// <summary>
    /// OnDisable is called when this script's enable-status is off.
    /// </summary>
    private void OnDisable() { UnsubscribeCallbacks(); }

    /// <summary>
    /// OnDestroy is called when this script or the gameobject carries this script is destroyed.
    /// </summary>
    private void OnDestroy() { UnsubscribeCallbacks(); }
    #endregion

    #region private methods
    /// <summary>
    /// Components that need to be set by code.
    /// These components should not be in the #serialized section.
    /// </summary>
    private void SetComponents() { }

    /// <summary>
    /// Callbacks set here.
    /// </summary>
    private void SubscribeCallbacks() { }

    /// <summary>
    /// Callbacks removing here.
    /// </summary>
    private void UnsubscribeCallbacks()
    {
        try { }
        catch { }
    }

    [ContextMenu("DeleteAllMeshVision")]
    private void DeleteAllMeshVision()
    {
        List<MeshFilter> meshFills = GetComponentsInChildren<MeshFilter>().ToList();
        for (int i = 0; i < meshFills.Count; i++) DestroyImmediate(meshFills[i]);
        meshFills.Clear();
        List<Renderer> renders = GetComponentsInChildren<Renderer>().ToList();
        for (int i = 0; i < renders.Count; i++) DestroyImmediate(renders[i]);
        renders.Clear();
        List<Light> lights = GetComponentsInChildren<Light>().ToList();
        for (int i = 0; i < lights.Count; i++) DestroyImmediate(lights[i]);
        lights.Clear();
    }
    [ContextMenu("ShowAllMeshVision")]
    private void ShowAllMeshVision()
    {        
        List<Renderer> renders = GetComponentsInChildren<Renderer>().ToList();
        for (int i = 0; i < renders.Count; i++) renders[i].enabled = true;
    }
    [ContextMenu("HideAllMeshVision")]
    private void HideAllMeshVision()
    {
        List<Renderer> renders = GetComponentsInChildren<Renderer>().ToList();
        for (int i = 0; i < renders.Count; i++) renders[i].enabled = false;
    }
    #endregion

    #region public methods
    #endregion
}