using Content.Server.Store.Systems;
using Content.Shared.FixedPoint;
using Content.Shared.Store;
using Robust.Shared.Prototypes;

namespace Content.Server.Store.Components;

// TODO: Refund on a per-item/action level.
//   Requires a refund button next to each purchase (disabled/invis by default)
//   Interactions with ActionUpgrades would need to be modified to reset all upgrade progress and return the original action purchase to the store.

/// <summary>
///     Keeps track of entities bought from stores for refunds, especially useful if entities get deleted before they can be refunded.
/// </summary>
[RegisterComponent, Access(typeof(StoreSystem))]
public sealed partial class StoreRefundComponent : Component
{
    /// <summary>
    ///     The store this entity was bought from
    /// </summary>
    [DataField]
    public EntityUid? StoreEntity;

    // Goobstation start
    [ViewVariables, DataField]
    public ListingData? Data;

    [ViewVariables, DataField]
    public Dictionary<ProtoId<CurrencyPrototype>, FixedPoint2> BalanceSpent = new();
    // Goobstation end
}
