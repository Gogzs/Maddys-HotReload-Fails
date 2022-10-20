namespace MaddysHotReloadFails.Control;

public partial class InputTextField : Frame
{
    #region Private fields
    private readonly Color _colorPrimary = Colors.Black;
    private readonly Color _colorSecondary = Colors.CornflowerBlue;
    #endregion

    #region Bindable properties
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(InputTextField));
    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(InputTextField));
    public static readonly BindableProperty IconProperty = BindableProperty.Create(nameof(Icon), typeof(ImageSource), typeof(InputTextField));
    public static readonly BindableProperty IsInputEnabledProperty = BindableProperty.Create(nameof(IsInputEnabled), typeof(bool), typeof(InputTextField));
    public static readonly BindableProperty KeyboardTypeProperty = BindableProperty.Create(nameof(KeyboardType), typeof(Keyboard), typeof(InputTextField));
    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(InputTextField));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public ImageSource Icon
    {
        get => (ImageSource)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public bool IsInputEnabled
    {
        get => (bool)GetValue(IsInputEnabledProperty);
        set => SetValue(IsInputEnabledProperty, value);
    }

    public Keyboard KeyboardType
    {
        get => (Keyboard)GetValue(KeyboardTypeProperty);
        set => SetValue(KeyboardTypeProperty, value);
    }

    public bool IsPassword
    {
        get => (bool)GetValue(IsPasswordProperty);
        set => SetValue(IsPasswordProperty, value);
    }
    #endregion

    public InputTextField()
    {
        InitializeComponent();

        BorderBottomStroke.BackgroundColor = _colorSecondary;
        BorderBottomStroke.Stroke = _colorSecondary;

        IsInputEnabled = true;
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        BorderBottomStroke.BackgroundColor = _colorPrimary;
        BorderBottomStroke.Stroke = _colorPrimary;
        BorderBottomStroke.TranslateTo(0, 0, 100);

        LabelPlaceholder.TranslateTo(-(LabelPlaceholder.Width / 4), -20);
        LabelPlaceholder.ScaleTo(0.5);
        LabelPlaceholder.TextColor = _colorPrimary;
    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        BorderBottomStroke.BackgroundColor = _colorSecondary;
        BorderBottomStroke.Stroke = _colorSecondary;
        BorderBottomStroke.TranslateTo(0, 1, 100);

        if (string.IsNullOrEmpty(EntryField.Text))
        {
            LabelPlaceholder.TranslateTo(0, 0);
            LabelPlaceholder.ScaleTo(1);
            LabelPlaceholder.TextColor = _colorSecondary;
        }
    }
}