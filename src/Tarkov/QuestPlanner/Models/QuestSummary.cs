namespace eft_dma_radar.Tarkov.QuestPlanner.Models;

/// <summary>
/// Root DTO returned by QuestService.GetSummary().
/// Contains the ordered session plan with maps, quest/objective counts.
/// </summary>
public sealed class QuestSummary
{
    /// <summary>
    /// Ordered maps in the session plan, highest priority first.
    /// </summary>
    public IReadOnlyList<MapPlan> Maps { get; init; } = [];

    /// <summary>
    /// Active quests whose completable objectives have no map attribution (e.g. Gunsmith series).
    /// Always populated — shown as an "All Maps" section at the bottom of the Quest Planner.
    /// </summary>
    public IReadOnlyList<QuestPlan> AllMapsQuests { get; init; } = [];

    /// <summary>
    /// Count of active quests from memory (Status=Started).
    /// </summary>
    public int TotalActiveQuests { get; init; }

    /// <summary>
    /// Count of completable objectives across all maps.
    /// </summary>
    public int TotalCompletableObjectives { get; init; }

    /// <summary>
    /// Distinct trader names that have quests ready to start (AvailableForStart status).
    /// </summary>
    public IReadOnlyList<string> AvailableForStartTraders { get; init; } = [];

    /// <summary>
    /// Distinct trader names that have quests ready to turn in (AvailableForFinish status).
    /// </summary>
    public IReadOnlyList<string> AvailableForFinishTraders { get; init; } = [];

    /// <summary>
    /// Find-in-raid item pairs collapsed into progress rows for the "Find in raid" category in All Maps.
    /// Each entry represents a findItem+giveItem pair (same item.Id, foundInRaid=true) from a Started quest.
    /// </summary>
    public IReadOnlyList<FirItemInfo> FirItems { get; init; } = [];

    /// <summary>
    /// Quests where ALL remaining incomplete objectives are of type giveQuestItem.
    /// The player has the quest item but hasn't handed it to the trader yet.
    /// </summary>
    public IReadOnlyList<HandOverItemInfo> HandOverItems { get; init; } = [];

    /// <summary>
    /// UTC timestamp when this summary was computed.
    /// </summary>
    public DateTime ComputedAt { get; init; } = DateTime.UtcNow;
}
