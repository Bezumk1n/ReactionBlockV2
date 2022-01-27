using ReactionBlockV2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReactionBlockV2.CustomControls
{
    public partial class ReactionBlock
    {
        /// <summary>
        /// Метки для строк планшета
        /// </summary>
        public ObservableCollection<string> RowHeaders { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> ColumnsHeaders { get; set; } = new ObservableCollection<string>();

        // Reaction plate
        #region _RowsCount
        public static readonly DependencyProperty _RowsCountProperty =
            DependencyProperty.Register(
                "_RowsCount", 
                typeof(int), 
                typeof(ReactionBlock), 
                new FrameworkPropertyMetadata(0, new PropertyChangedCallback(On_RowsCountChanged)));

        public int _RowsCount
        {
            get { return (int)GetValue(_RowsCountProperty); }
            set { SetValue(_RowsCountProperty, value); }
        }

        private static void On_RowsCountChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            ReactionBlock UserControlControl = d as ReactionBlock;
            UserControlControl.On_RowsCountChanged(e);
        }

        private void On_RowsCountChanged(DependencyPropertyChangedEventArgs e)
        {
            RowHeaders = new ObservableCollection<string>(
                Enumerable.Range(0, _RowsCount)
                    .Select(x => $"{Convert.ToChar(65 + x)}").ToList());

            //OnPropertyChanged(nameof(RowHeaders));
        }
        #endregion
        #region _ColumnsCount
        public static readonly DependencyProperty _ColumnsCountProperty =
            DependencyProperty.Register(
                "_ColumnsCount",
                typeof(int),
                typeof(ReactionBlock),
                new FrameworkPropertyMetadata(0, new PropertyChangedCallback(On_ColumnsCountChanged)));
        public int _ColumnsCount
        {
            get { return (int)GetValue(_ColumnsCountProperty); }
            set { SetValue(_ColumnsCountProperty, value); }
        }

        private static void On_ColumnsCountChanged(DependencyObject d,
           DependencyPropertyChangedEventArgs e)
        {
            ReactionBlock UserControlControl = d as ReactionBlock;
            UserControlControl.On_ColumnsCountChanged(e);
        }

        private void On_ColumnsCountChanged(DependencyPropertyChangedEventArgs e)
        {
            ColumnsHeaders = new ObservableCollection<string>(
                Enumerable.Range(1, _ColumnsCount)
                    .Select(x => x.ToString("00")).ToList());

            //OnPropertyChanged(nameof(ColumnsHeaders));
        }
        #endregion

        #region _Items
        /// <summary>
        /// Коллекция образцов (wrapper for <see cref="FrameworkElement.DataContext"/>)
        /// </summary>
        public static readonly DependencyProperty _ItemsProperty =
            DependencyProperty.Register(
                "_Items",
                typeof(object),
                typeof(ReactionBlock),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Коллекция образцов (аналог <see cref="FrameworkElement.DataContext"/> Property)
        /// </summary>
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Localizability(LocalizationCategory.NeverLocalize)]
        public object _Items
        {
            get => GetValue(_ItemsProperty);
            set => SetValue(_ItemsProperty, value);
        }
        #endregion
    }
}
