using UnityEditor;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CompositeScriptableObjectInstaller))]
    [NoReflectionBaking]
    public class CompositeScriptableObjectInstallerEditor : BaseCompositetInstallerEditor<CompositeScriptableObjectInstaller, ScriptableObjectInstallerBase>
    {
    }
}