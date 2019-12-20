using GalaSoft.MvvmLight;
using System.Windows.Media;

namespace TriviaMaze
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Color _UiColor = Colors.Yellow;
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
    }
}