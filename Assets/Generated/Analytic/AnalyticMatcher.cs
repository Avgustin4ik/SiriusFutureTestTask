//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class AnalyticMatcher {

    public static Entitas.IAllOfMatcher<AnalyticEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<AnalyticEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<AnalyticEntity> AllOf(params Entitas.IMatcher<AnalyticEntity>[] matchers) {
          return Entitas.Matcher<AnalyticEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<AnalyticEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<AnalyticEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<AnalyticEntity> AnyOf(params Entitas.IMatcher<AnalyticEntity>[] matchers) {
          return Entitas.Matcher<AnalyticEntity>.AnyOf(matchers);
    }
}