using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace AvaloniaDock
{
    public class DockTarget : TemplatedControl
    {
        private Grid _topIndicator;
        private Grid _bottomIndicator;
        private Grid _leftIndicator;
        private Grid _rightIndicator;
        private Grid _centerIndicator;

        private Control _topSelector;
        private Control _bottomSelector;
        private Control _leftSelector;
        private Control _rightSelector;
        private Control _centerSelector;


        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            _topIndicator = e.NameScope.Find<Grid>("PART_TopIndicator");
            _bottomIndicator = e.NameScope.Find<Grid>("PART_BottomIndicator");
            _leftIndicator = e.NameScope.Find<Grid>("PART_LeftIndicator");
            _rightIndicator = e.NameScope.Find<Grid>("PART_RightIndicator");
            _centerIndicator = e.NameScope.Find<Grid>("PART_CenterIndicator");

            _topSelector = e.NameScope.Find<Control>("PART_TopSelector");
            _bottomSelector = e.NameScope.Find<Control>("PART_BottomSelector");
            _leftSelector = e.NameScope.Find<Control>("PART_LeftSelector");
            _rightSelector = e.NameScope.Find<Control>("PART_RightSelector");
            _centerSelector = e.NameScope.Find<Control>("PART_CenterSelector");

            _leftIndicator.Bind(OpacityProperty, _leftSelector.GetObservable(IsPointerOverProperty).Select(p => p ? 0.5 : 0));
            _rightIndicator.Bind(OpacityProperty, _rightSelector.GetObservable(IsPointerOverProperty).Select(p => p ? 0.5 : 0));
            _topIndicator.Bind(OpacityProperty, _topSelector.GetObservable(IsPointerOverProperty).Select(p => p ? 0.5 : 0));
            _bottomIndicator.Bind(OpacityProperty, _bottomSelector.GetObservable(IsPointerOverProperty).Select(p => p ? 0.5 : 0));
            _centerIndicator.Bind(OpacityProperty, _centerSelector.GetObservable(IsPointerOverProperty).Select(p => p ? 0.5 : 0));
        }
    }
}
