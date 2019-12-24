using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace TriviaMaze.ViewModels
{
    public class CustomizeViewModel : ViewModelBase
    {
        public ICommand MapBtn { get; }
        private Action<GameViewAction> NavigateAction { get; }

        public CustomizeViewModel(Action<GameViewAction> navigateBtn)
        {
            MapBtn = new RelayCommand(OnMap);
            NavigateAction = navigateBtn;
        }

        private void OnMap()
        {
            NavigateAction.Invoke(GameViewAction.Map);
        }

        private Brush _UiBrushSelected = Brushes.Yellow;
        private Brush _UiBrushUnSelected = Brushes.Orange;

        private Color _UiColorSelected = Colors.Yellow;
        private Color _UiColorUnSelected = Colors.Orange;

        public Brush UiBrushSelected
        {
            get => _UiBrushSelected;
            set => Set(ref _UiBrushSelected, value);
        }

        public Brush UiBrushUnSelected
        {
            get => _UiBrushUnSelected;
            set => Set(ref _UiBrushUnSelected, value);
        }

        public Color UiColorSelected
        {
            get => _UiColorSelected;
            set
            {
                Set(ref _UiColorSelected, value);
                UiBrushSelected = new SolidColorBrush(value);
            }
        }

        public Color UiColorUnSelected
        {
            get => _UiColorUnSelected;
            set
            {
                Set(ref _UiColorUnSelected, value);
                UiBrushUnSelected = new SolidColorBrush(value);
            }
        }

        private Brush _DoorBrushSelected = Brushes.Yellow;
        private Brush _DoorBrushUnSelected = Brushes.Orange;

        private Color _DoorColorSelected = Colors.Yellow;
        private Color _DoorColorUnSelected = Colors.Orange;

        public Brush DoorBrushSelected
        {
            get => _DoorBrushSelected;
            set => Set(ref _DoorBrushSelected, value);
        }

        public Brush DoorBrushUnSelected
        {
            get => _DoorBrushUnSelected;
            set => Set(ref _DoorBrushUnSelected, value);
        }

        public Color DoorColorSelected
        {
            get => _DoorColorSelected;
            set
            {
                Set(ref _DoorColorSelected, value);
                DoorBrushSelected = new SolidColorBrush(value);
            }
        }

        public Color DoorColorUnSelected
        {
            get => _DoorColorUnSelected;
            set
            {
                Set(ref _DoorColorUnSelected, value);
                DoorBrushUnSelected = new SolidColorBrush(value);
            }
        }
    }
}
