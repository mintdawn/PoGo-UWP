﻿using POGOProtos.Enums;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using PokemonGo_UWP.Entities;

namespace PokemonGo_UWP.Utils
{
    public class PokedexEntryDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PokemonCaptured { get; set; }
        public DataTemplate PokemonSeen { get; set; }
        public DataTemplate PokemonUnseen { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            PokemonId id = (PokemonId)item;
            var pokedexEntry = GameClient.PokedexInventory.FirstOrDefault(x => x.PokemonId == id);
            if (pokedexEntry == null)
                return PokemonUnseen;
            else if (pokedexEntry.TimesEncountered > 0 && pokedexEntry.TimesCaptured == 0)
                return PokemonSeen;
            else
                return PokemonCaptured;
        }
    }

    public class PokedexItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PokemonCaptured { get; set; }
        public DataTemplate PokemonSeen { get; set; }
        public DataTemplate PokemonUnseen { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            DataTemplate template = null;
            PokemonModel pokemon = item as PokemonModel;
            if (pokemon != null)
            {
                if (pokemon.TimesEncountered > 0)
                {
                    template = pokemon.TimesCaptured == 0 ? PokemonSeen : PokemonCaptured;
                }
                else
                {
                    template = PokemonUnseen;
                }
            }
            else
            {
                template = PokemonUnseen;
            }

            return template;
        }
    }

    public class SelectedItemsTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultStateTemplate { get; set; }
        public DataTemplate SelectedStateTemplate { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            GridViewItem gvi = container as GridViewItem;
            if (gvi != null)
            {
                if (gvi.IsSelected)
                    return SelectedStateTemplate;
                else
                    return DefaultStateTemplate;
            }
            return base.SelectTemplateCore(item, container);
        }
    }
}
