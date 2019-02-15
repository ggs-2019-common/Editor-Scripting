using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(base_class))]
class MinMaxSlider : Editor
{

    public override void OnInspectorGUI()
    {
        base_class avatar = (base_class)target;
        base.OnInspectorGUI();
        
        GUILayout.Label("Angles",EditorStyles.boldLabel);
        EditorGUILayout.LabelField("Min Val:", avatar._minSlope.ToString());
        EditorGUILayout.LabelField("Max Val:", avatar._maxSlope.ToString());
        EditorGUILayout.MinMaxSlider("SteepAscent",ref avatar._minSlope, ref avatar._maxSlope, 0.0f, 90.0f);

    }

}