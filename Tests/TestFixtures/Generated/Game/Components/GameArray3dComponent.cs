//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Array3dComponent array3d { get { return (Array3dComponent)GetComponent(GameComponentsLookup.Array3d); } }
    public bool hasArray3d { get { return HasComponent(GameComponentsLookup.Array3d); } }

    public void AddArray3d(int[,,] newValue) {
        var index = GameComponentsLookup.Array3d;
        var component = (Array3dComponent)CreateComponent(index, typeof(Array3dComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceArray3d(int[,,] newValue) {
        var index = GameComponentsLookup.Array3d;
        var component = (Array3dComponent)CreateComponent(index, typeof(Array3dComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveArray3d() {
        RemoveComponent(GameComponentsLookup.Array3d);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherArray3d;

    public static Entitas.IMatcher<GameEntity> Array3d {
        get {
            if (_matcherArray3d == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Array3d);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherArray3d = matcher;
            }

            return _matcherArray3d;
        }
    }
}
