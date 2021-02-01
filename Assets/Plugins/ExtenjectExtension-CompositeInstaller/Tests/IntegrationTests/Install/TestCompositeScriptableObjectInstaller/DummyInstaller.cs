using UnityEngine;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller.Tests.Installers.CompositeScriptableObjectInstallers
{
    // [CreateAssetMenu(fileName = "DummyInstaller", menuName = "Installers/DummyInstaller")]
    public class DummyInstaller : ScriptableObjectInstaller<DummyInstaller>
    {
        public override void InstallBindings()
        {
        }
    }
}