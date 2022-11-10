using Core.Configs;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/Game/GameConfig")]
public sealed class GameConfig : Config
{
    public const string PlayerDataKey = "playerData";
    [field: SerializeField] public UI.LetterBox LetterBoxPrefab { get; private set; }
    [field: SerializeField] public int PlayerTryCount { get; private set;}
    [field: SerializeField] public int MinimalSymbolSearchLenght {get; private set;}
    [field: SerializeField] public TextAsset textData { get; private set;}
}