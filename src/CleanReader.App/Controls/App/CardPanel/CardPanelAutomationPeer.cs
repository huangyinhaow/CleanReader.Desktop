﻿// Copyright (c) Richasy. All rights reserved.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Controls;

namespace CleanReader.App.Controls
{
    /// <summary>
    /// Automated public properties of <see cref="CardPanel"/>.
    /// </summary>
    public class CardPanelAutomationPeer : ToggleButtonAutomationPeer
    {
        private readonly CardPanel _owner;

        /// <summary>
        /// Initializes a new instance of the <see cref="CardPanelAutomationPeer"/> class.
        /// </summary>
        /// <param name="owner">Owner.</param>
        public CardPanelAutomationPeer(CardPanel owner)
            : base(owner) => _owner = owner;

        /// <inheritdoc/>
        protected override AutomationControlType GetAutomationControlTypeCore()
            => AutomationControlType.ListItem;

        /// <inheritdoc/>
        protected override int GetPositionInSetCore()
        {
            var element = _owner as FrameworkElement;
            var parent = _owner.Parent;
            if (parent is not ItemsRepeater && parent != null)
            {
                parent = (parent as FrameworkElement).Parent;
                element = _owner.Parent as FrameworkElement;
            }

            return (parent as ItemsRepeater)?.GetElementIndex(element) + 1
                ?? base.GetPositionInSetCore();
        }

        /// <inheritdoc/>
        protected override int GetSizeOfSetCore()
        {
            var parent = _owner.Parent;
            if (parent is not ItemsRepeater && parent != null)
            {
                parent = (parent as FrameworkElement).Parent;
            }

            var count = (parent as ItemsRepeater)?.ItemsSourceView?.Count;
            return count ?? base.GetSizeOfSetCore();
        }
    }
}
