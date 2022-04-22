using System;

namespace UnityEditor.TestTools.TestRunner.GUI.TestAssets
{
    /// <inheritdoc />
    class ActiveFolderTemplateAssetCreator : IActiveFolderTemplateAssetCreator
    {
        /// <inheritdoc />
        public string GetActiveFolderPath()
        {
            return ProjectWindowUtil.GetActiveFolderPath();
        }

        /// <inheritdoc />
        public void CreateFolderWithTemplates(string defaultName, params string[] templateNames)
        {
            ProjectWindowUtil.CreateFolderWithTemplates(defaultName, templateNames);
        }

        /// <inheritdoc />
        public void CreateScriptAssetFromTemplateFile(string defaultName, string templatePath)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, defaultName);
        }
    }
}
