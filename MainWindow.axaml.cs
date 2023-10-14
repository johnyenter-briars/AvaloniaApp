using Avalonia;
using Avalonia.Controls;

namespace MyApp;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

#if DEBUG
		this.AttachDevTools();
#endif
	}
}