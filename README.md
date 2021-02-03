# ExtenjectExtension-CompositeInstaller
Extenject extension for composite pattern installers

## Dependencies
- [Extenject](https://github.com/svermeulen/Extenject)
  - Version 9.2.0 or later


## Installation
- All installations require "Extenject"

### Unity Package Manager
- Use `Assets/Plugins/ExtenjectExtension-CompositeInstaller/package.json`

### unitypackage
- Use `ExtenjectExtension-CompositeInstaller.unitypackage` from [Release Page](https://github.com/tsgcpp/ExtenjectExtension-CompositeInstaller/releases)


## Introduction

### CompositeMonoInstaller
- Add "CompositeMonoInstaller" component to GameObject
- Set some "MonoInstaller"s (including "CompositeMonoInstaller")
- Set "CompositeMonoInstaller" to a Context

![](./Documents/images/CompositeMonoInstaller_inspector.jpg)

### CompositeScriptableObjectInstaller
- Create "CompositeScriptableObjectInstaller" in the same way as other "ScriptableObjectInstaller"s

![](./Documents/images/CompositeScriptableObjectInstaller_create_asset.jpg)

- Set some "ScriptableObjectInstaller"s (including "CompositeScriptableObjectInstaller")

![](./Documents/images/CompositeScriptableObjectInstaller_inspector.jpg)

- Set "CompositeScriptableObjectInstaller" to a Context

![](./Documents/images/CompositeScriptableObjectInstaller_install.jpg)

### FYI
- If any circular references are found in a composite installer, the property on the inspector will get red as a warning

![](./Documents/images/CompositeMonoInstaller_circular_reference.jpg)
![](./Documents/images/CompositeScriptableObjectInstaller_circular_reference.jpg)


## License
- See [here](./LICENSE)