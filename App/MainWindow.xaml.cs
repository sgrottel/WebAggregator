using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SG.WebAggregator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_SourceInitialized(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.MainWinWidth != 0)
			{
				WindowStartupLocation = WindowStartupLocation.Manual;
				Top = Properties.Settings.Default.MainWinTop;
				Left = Properties.Settings.Default.MainWinLeft;
				Width = Properties.Settings.Default.MainWinWidth;
				Height = Properties.Settings.Default.MainWinHeight;
				WindowState = Properties.Settings.Default.MainWinMax ? WindowState.Maximized : WindowState.Normal;
				StructureColumn.Width = new GridLength(Properties.Settings.Default.StructureColumnWidth);
			}
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (WindowState == WindowState.Maximized)
			{
				Properties.Settings.Default.MainWinTop = RestoreBounds.Top;
				Properties.Settings.Default.MainWinLeft = RestoreBounds.Left;
				Properties.Settings.Default.MainWinWidth = RestoreBounds.Width;
				Properties.Settings.Default.MainWinHeight = RestoreBounds.Height;
				Properties.Settings.Default.MainWinMax = true;
			}
			else
			{
				Properties.Settings.Default.MainWinTop = Top;
				Properties.Settings.Default.MainWinLeft = Left;
				Properties.Settings.Default.MainWinWidth = Width;
				Properties.Settings.Default.MainWinHeight = Height;
				Properties.Settings.Default.MainWinMax = false;
			}
			Properties.Settings.Default.StructureColumnWidth = StructureColumn.Width.Value;
			Properties.Settings.Default.Save();
		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			StructureColumn.MaxWidth = e.NewSize.Width - (StructureColumn.MinWidth + 5 + 2 * SystemParameters.ResizeFrameVerticalBorderWidth);
		}
	}
}
