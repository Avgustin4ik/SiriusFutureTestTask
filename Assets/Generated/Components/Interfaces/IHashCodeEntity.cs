//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IHashCodeEntity {

    Core.Common.HashCodeComponent hashCode { get; }
    bool hasHashCode { get; }

    void AddHashCode(int newValue);
    void ReplaceHashCode(int newValue);
    void RemoveHashCode();
}
