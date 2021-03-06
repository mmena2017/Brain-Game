﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Slot))]
public class SlotViewer : Editor
{
    public override void OnInspectorGUI()
    {
        Slot slot = (Slot)target;

        EditorGUILayout.LabelField("My Block's Value = " + slot.getValue());

        Repaint();

        base.OnInspectorGUI();
    }
}
