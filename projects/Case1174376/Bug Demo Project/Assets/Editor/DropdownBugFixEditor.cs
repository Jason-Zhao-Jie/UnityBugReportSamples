using UnityEditor;

[CustomEditor(typeof(BugFixedDropDown))]
public class DropDownBugFixEditor : UnityEditor.UI.DropdownEditor {
    BugFixedDropDown self;
    SerializedProperty prop;
    protected override void OnEnable() {
        base.OnEnable();
        self = target as BugFixedDropDown;
        prop = serializedObject.FindProperty("SortingLayer");
    }

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        EditorGUILayout.BeginVertical();
        EditorGUILayout.Space();
        EditorGUILayout.PropertyField(prop, new UnityEngine.GUIContent("Canvas Sorting Layer"));
        Undo.RecordObject(self, "listview change");
        EditorGUILayout.EndVertical();
    }
}