using UnityEditor;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(CompositeMonoInstaller))]
    [NoReflectionBaking]
    public class CompositeMonoInstallerEditor : BaseCompositetInstallerEditor<CompositeMonoInstaller, MonoInstallerBase>
    {
    }
}