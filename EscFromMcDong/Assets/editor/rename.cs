using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Rename : EditorWindow
{
    [SerializeField] private GameObject prefab;

    [MenuItem("Tools/Rename")]
    static void CreateRename()
    {
        EditorWindow.GetWindow<Rename>();
    }

    private void OnGUI()
    {

        if (GUILayout.Button("Replace"))
        {
            var selection = Selection.gameObjects;

            for (var i = selection.Length - 1; i >= 0; --i)
            {
                var selected = selection[i];

                Undo.RegisterCompleteObjectUndo(selected, "Rename");
                string prefix;
                string coords;
                string prefixGet = "SL";
                prefix = "SL";
                prefixGet = selected.name.Substring(0,9);
                Debug.Log(prefixGet);
                if (prefixGet.Equals("1DoRoFix "))
                    prefix = "R1";
                if (prefixGet.Equals("2DoRoFix2"))
                    prefix = "R2";
                if (prefixGet.Equals("3DoRoFix2"))
                    prefix = "R3";
                if (prefixGet.Equals("4DoRoFix2"))
                    prefix = "R4";
                if (prefixGet.Equals("AngTubeFi"))
                    prefix = "TA";
                if (prefixGet.Equals("ConnectLa"))
                    prefix = "CL";
                if (prefixGet.Equals("glassdome"))
                    prefix = "GD";
                if (prefixGet.Equals("StrtTube2"))
                    prefix = "T2";
                if (prefixGet.Equals("StrtTube4"))
                    prefix = "T4";
                coords = ((selected.transform.localPosition.z+160)/40).ToString();
                coords = coords + ((char)(((selected.transform.localPosition.x + 320) / 40) + 65)).ToString();
                if (selected.transform.localPosition.y > 40)
                    coords = coords + "+";
                if (selected.transform.localPosition.y < 40)
                    coords = coords + "-";
                selected.name = prefix+"("+coords+")";


               

                
          
                
            }
        }

        GUI.enabled = false;
        EditorGUILayout.LabelField("Selection count: " + Selection.objects.Length);
    }
}