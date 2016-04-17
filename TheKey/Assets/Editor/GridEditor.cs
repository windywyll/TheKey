using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor (typeof(GuizmoGrid))]
public class GridEditor : Editor {

    GuizmoGrid grid;
    public GameObject prefab;

   /* public void OnEnable()
    {
        grid = (GuizmoGrid) target;
        SceneView.onSceneGUIDelegate = GridUpdate;
    }

    void GridUpdate(SceneView sceneview)
    {
        Event e = Event.current;

        Ray r = Camera.current.ScreenPointToRay(new Vector3(e.mousePosition.x, 0.0f, -e.mousePosition.y + Camera.current.pixelHeight));
        Vector3 mousePos = r.origin;

        if (e.button == 0 && e.type == EventType.MouseUp)
        {
            GameObject obj;

            if (prefab)
            {
                obj = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                Vector3 aligned = new Vector3(Mathf.Floor(mousePos.x / grid.xWidth) * grid.xWidth + grid.xWidth / 2.0f, 0.0f, Mathf.Floor(mousePos.y / grid.zWidth) * grid.zWidth + grid.zWidth / 2.0f);
                obj.transform.position = aligned;
            }
        }
    }

    public override void OnInspectorGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label(" Grid X Width ");
        grid.xWidth = EditorGUILayout.FloatField(grid.xWidth, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Grid Z Width ");
        grid.zWidth = EditorGUILayout.FloatField(grid.zWidth, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label(" Grid Height ");
        grid.height = EditorGUILayout.FloatField(grid.height, GUILayout.Width(50));
        GUILayout.EndHorizontal();

        SceneView.RepaintAll();
    }*/

}
