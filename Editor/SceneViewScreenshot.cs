/*
 * Copyright (c) 2024, willneedit
 * 
 * Licensed by the Mozilla Public License 2.0,
 * residing in the LICENSE.md file in the project's root directory.
 */

using System;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace Arteranos.SDK.Editor
{
    public static class SceneViewScreenshot
    {
        [MenuItem("Tools/Create Scene View Screenshot", false, 1)]
        private static void CreateSveneViewScreenshot()
        {
            string name = $"Arteranos-Editor-{DateTime.Now:yyyyMMddHHmmss}.png";
            string picpath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string path = Path.Combine(picpath, name);
            using Stream fs = File.Create(path);

            EditorUtilities.TakeSceneViewPhotoStream(fs);

            Debug.Log($"Screenshot saved under {name} under your Pictures folder.");
        }
    }
}