using System.ComponentModel;

namespace WRMapOverlay;

public partial class Form1 : Form, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private Settings Settings { get; } = new();
    private GameManager GameManager { get; } = new();
    private GameSave? CurrentSave { get; set; }

    public Form1()
    {
        InitializeComponent();
    }

    public bool IsOverlayPanelEnabled
    {
        get => CurrentSave is not null && !string.IsNullOrWhiteSpace(GameManager.GameDirectoryRoot);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        OverlaySettingsPanel.DataBindings.Add(
            new Binding(
                nameof(OverlaySettingsPanel.Enabled),
                this,
                nameof(IsOverlayPanelEnabled)));

        GameExecutablePathTextBox.Validated += (sender, args) =>
        {
            try
            {
                GameManager.SetGameDirectoryRoot(GameExecutablePathTextBox.Text);
                PropertyChanged?.Invoke(this, new(nameof(IsOverlayPanelEnabled)));
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
        };

        GameSavePathTextBox.SelectedValueChanged += (sender, args) =>
        {
            if (GameSavePathTextBox.SelectedItem is GameSave gameSave)
            {
                CurrentSave = gameSave;
                UpdateOverlayPicture();
                PropertyChanged?.Invoke(this, new(nameof(IsOverlayPanelEnabled)));
            }
        };

        GameManager.GameDirectoryChanged += (directory) =>
        {
            Settings.GameDirectory = directory;
            ReloadGameSaveList();
            UpdateTerrainDepthWarning();
        };

        Settings.Load();
        if (!string.IsNullOrWhiteSpace(Settings.GameDirectory))
        {
            GameManager.SetGameDirectoryRoot(Settings.GameDirectory);
            GameExecutablePathTextBox.Text = Settings.GameDirectory;
        }
    }

    protected override void OnActivated(EventArgs e)
    {
        base.OnActivated(e);
        UpdateTerrainDepthWarning();
    }

    private void BrowseGameLocation_Click(object sender, EventArgs e)
    {
        var openFolderDialog = new FolderBrowserDialog();

        if (openFolderDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                GameManager.SetGameDirectoryRoot(openFolderDialog.SelectedPath);
                GameExecutablePathTextBox.Text = openFolderDialog.SelectedPath;
                PropertyChanged?.Invoke(this, new(nameof(IsOverlayPanelEnabled)));
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
        }
    }

    private void BrowseSaveButton_Click(object sender, EventArgs e)
    {
        var openFolderDialog = new FolderBrowserDialog();
        if (openFolderDialog.ShowDialog() == DialogResult.OK)
        {
            string savePath = openFolderDialog.SelectedPath;

            if (GameSave.IsValidGameSave(savePath))
            {
                var item = new GameSave(savePath);

                if (!GameSavePathTextBox.Items.Contains(item))
                    GameSavePathTextBox.Items.Add(item);
                GameSavePathTextBox.SelectedItem = item;
            }
        }
    }

    private void SetOverlayButton_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog()
        {
            Filter = "PNG|*.png"
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            SetOverlay(openFileDialog.FileName);
            UpdateOverlayPicture();
        }
    }

    private void RemoveOverlayButton_Click(object sender, EventArgs e)
    {
        RemoveOverlay();
        UpdateOverlayPicture();
    }

    private void ReloadGameSaveList()
    {
        var gameSaves = GameManager.GetGameSaves().ToArray();
        if (gameSaves.Length > 0)
        {
            GameSavePathTextBox.Items.Clear();
            GameSavePathTextBox.Items.AddRange(gameSaves);
            GameSavePathTextBox.SelectedIndex = 0;
        }
    }

    private void SetOverlay(string path)
    {
        const string OverlayDirectoryName = "overlays";

        if (CurrentSave is null)
        {
            throw new InvalidOperationException("Current save is null.");
        }

        string overlaysDirectory = GameManager.GetOrCreateSubdirectory(OverlayDirectoryName);
        string overlayFileName = $"{Guid.NewGuid():N}.png";

        try
        {
            File.Copy(path, Path.Combine(overlaysDirectory, overlayFileName));
        }
        catch
        {
            ShowError("Failed to copy overlay.");
        }

        CurrentSave.SetOverlay(Path.Combine(OverlayDirectoryName, overlayFileName));
    }

    private void RemoveOverlay()
    {
        if (CurrentSave?.GetOverlay() is not null)
        {
            CurrentSave.RemoveOverlay();
        }
    }

    private void UpdateOverlayPicture()
    {
        var overlayPath = CurrentSave?.GetOverlay();
        if (overlayPath is not null)
        {
            OverlayBox.ImageLocation = Path.Combine(
                GameManager.GetOrCreateSubdirectory(""),
                overlayPath);
        }
        else
        {
            OverlayBox.ImageLocation = null;
        }
    }

    private void UpdateTerrainDepthWarning()
    {
        if (!string.IsNullOrEmpty(GameManager.GameDirectoryRoot))
        {
            TerrainDepthWarning.Visible = GameManager.GetTerrainDepthSetting() != 0;
        }
    }

    private void ShowError(string message)
    {
        MessageBox.Show(
            message,
            Text,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
