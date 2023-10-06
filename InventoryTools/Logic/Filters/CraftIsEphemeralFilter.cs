﻿using CriticalCommonLib.Models;
using CriticalCommonLib.Sheets;
using InventoryTools.Logic.Filters.Abstract;

namespace InventoryTools.Logic.Filters;

public class CraftIsEphemeralFilter : BooleanFilter
{
    public override string Key { get; set; } = "CraftIsEphemeral";
    public override string Name { get; set; } = "Ephemeral?";

    public override string HelpText { get; set; } =
        "Is this craft list ephemeral? If checked, once all the items in the craft list are deleted, the list will delete itself. This is only checked as each craft is completed.";

    public override FilterCategory FilterCategory { get; set; } = FilterCategory.Basic;
    public override FilterType AvailableIn { get; set; } = FilterType.CraftFilter;
    public override bool? FilterItem(FilterConfiguration configuration, InventoryItem item)
    {
        return null;
    }

    public override bool? FilterItem(FilterConfiguration configuration, ItemEx item)
    {
        return null;
    }

    public override bool? CurrentValue(FilterConfiguration configuration)
    {
        return configuration.IsEphemeralCraftList;
    }

    public override void UpdateFilterConfiguration(FilterConfiguration configuration, bool? newValue)
    {
        configuration.IsEphemeralCraftList = newValue ?? false;
    }
    
    private readonly string[] _choices = new []{"Yes", "No"};

    public override string[] GetChoices()
    {
        return _choices;
    }

    public override bool? DefaultValue { get; set; } = false;
}