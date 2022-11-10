using System;
using System.Linq;
using Core.Configs;
using Entitas;
using UnityEngine;
using Random = System.Random;

public class LoadRiddleWordsSystem : IInitializeSystem
{
    private readonly GameConfig _gameConfig;

    public LoadRiddleWordsSystem(GameContext gameContext, UiContext uiContext)
    {
        _gameConfig = ConfigsCatalogsManager.GetConfig<GameConfig>();
    }

    public void Initialize()
    {
        var rnd = new Random();
        var rawText = _gameConfig.textData.text;
        var minimalSymbolSearchLenght = _gameConfig.MinimalSymbolSearchLenght;
        char[] separators = { '\n', ',', '.', '\'', '"', ' ','-',';','!','?','`',':','\t', '(', ')' };
        var words = rawText.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Where(word => word.Length >= minimalSymbolSearchLenght)
            .Distinct()
            .OrderBy(x => rnd.Next())
            .ToArray();
        Debug.Log($"total {words.Count()} was find");
        var quizEntity = Contexts.sharedInstance.game.CreateEntity();
        quizEntity.isQuizRules = true;
        quizEntity.AddRiddleWordsDatabase(words);
        quizEntity.AddRiddleWord(words.FirstOrDefault());
    }
}