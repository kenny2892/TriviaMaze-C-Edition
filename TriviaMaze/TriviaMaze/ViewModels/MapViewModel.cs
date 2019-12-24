using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TriviaMaze.ViewModels
{
    public class MapViewModel : ViewModelBase
    {
        public ICommand CustomizeBtn { get; }
        private Action<GameViewAction> NavigateAction { get; }

        public MapViewModel(Action<GameViewAction> navigateBtn)
        {
            CustomizeBtn = new RelayCommand(OnCustomize);
            AddDoorway = new RelayCommand(OnAddDoorway);

            DoorwayCollection = new ObservableCollection<ImageItem>
            {
                new ImageItem
                {
                    Height = 28,
                    Width = 40,
                    X = 12.5,
                    Y = 2.2,
                    Source = "",
                    AnimatedSource = "/Images/Maze.gif"
                }
            };

            NavigateAction = navigateBtn;
        }

        private void OnCustomize()
        {
            NavigateAction.Invoke(GameViewAction.Customize);
        }

        private Brush _UiBrushSelected = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f7fe40"));
        private Brush _UiBrushUnSelected = (SolidColorBrush) (new BrushConverter().ConvertFrom("#ee793c"));

        private Color _UiColorSelected = (Color)ColorConverter.ConvertFromString("#f7fe40");
        private Color _UiColorUnSelected = (Color)ColorConverter.ConvertFromString("#ee793c");

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

        private Brush _DoorBrushSelected = (SolidColorBrush)(new BrushConverter().ConvertFrom("#f7fe40"));
        private Brush _DoorBrushUnSelected = Brushes.White;

        private Color _DoorColorSelected = (Color)ColorConverter.ConvertFromString("#f7fe40");
        private Color _DoorColorUnSelected = Colors.White;

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

        public ObservableCollection<ImageItem> DoorwayCollection { get; }

        public RelayCommand AddDoorway { get; }

        private int _DoorwayNum = 0;

        private void OnAddDoorway()
        {
            double[][] horizontalDoorways = new double[][]
            {
                new double[] { 22.8, 6.8 }, new double[] { 25.5, 5 }, new double[] { 31.3, 5 }, new double[] { 37.1, 5 }, new double[] { 42.9, 5 },
                new double[] { 19.3, 10 }, new double[] { 25.2, 10 }, new double[] { 31.3, 10 }, new double[] { 37.3, 10 }, new double[] { 43.4, 10 },
                new double[] { 18.7, 15.3 }, new double[] { 25, 15.3 }, new double[] { 31.3, 15.3 }, new double[] { 37.8, 15.3 }, new double[] { 44.5, 15.3 },
                new double[] { 17.8, 21.4 }, new double[] { 24.6, 21.4 }, new double[] { 31.3, 21.4 }, new double[] { 38.3, 21.4 }, new double[] { 45.4, 21.4 },
            };

            double[] coords = horizontalDoorways[_DoorwayNum];

            ImageItem toAdd = new ImageItem
            {
                Height = 4,
                Width = 4,
                X = coords[0],
                Y = coords[1],
                Source = "/Images/Checkmark.png",
                AnimatedSource = ""
            };

            _DoorwayNum++;
            DoorwayCollection.Add(toAdd);
        }
    }
}
