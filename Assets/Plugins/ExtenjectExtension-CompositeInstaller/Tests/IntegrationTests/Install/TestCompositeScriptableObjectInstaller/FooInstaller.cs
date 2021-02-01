using UnityEngine;
using Zenject;

namespace ExtenjectExtension.CompositeInstaller.Tests.Installers.CompositeScriptableObjectInstallers
{
    public class Foo
    {
    }

    // [CreateAssetMenu(fileName = "FooInstaller", menuName = "Installers/FooInstaller")]
    public class FooInstaller : ScriptableObjectInstaller<FooInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<Foo>().AsSingle().NonLazy();
        }
    }
}