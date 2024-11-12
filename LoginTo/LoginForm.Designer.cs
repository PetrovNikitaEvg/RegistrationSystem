namespace LoginTo
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Background = new Bunifu.UI.WinForms.BunifuGradientPanel();
            RegisterButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            LoginButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            RememberMeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            RememberMeButton = new Bunifu.UI.WinForms.BunifuCheckBox();
            PasswordTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            LogoPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            LoginLabel = new Bunifu.UI.WinForms.BunifuLabel();
            UsernameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.BackgroundImageLayout = ImageLayout.Stretch;
            Background.BorderRadius = 1;
            Background.Controls.Add(RegisterButton);
            Background.Controls.Add(LoginButton);
            Background.Controls.Add(RememberMeLabel);
            Background.Controls.Add(RememberMeButton);
            Background.Controls.Add(PasswordTextBox);
            Background.Controls.Add(LogoPicture);
            Background.Controls.Add(LoginLabel);
            Background.Controls.Add(UsernameTextBox);
            Background.Dock = DockStyle.Fill;
            Background.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Background.GradientBottomLeft = Color.FromArgb(69, 104, 202);
            Background.GradientBottomRight = Color.FromArgb(208, 78, 214);
            Background.GradientTopLeft = Color.FromArgb(208, 78, 214);
            Background.GradientTopRight = Color.FromArgb(131, 77, 155);
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Quality = 10;
            Background.Size = new Size(439, 616);
            Background.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.AllowAnimations = true;
            RegisterButton.AllowMouseEffects = true;
            RegisterButton.AllowToggling = false;
            RegisterButton.AnimationSpeed = 200;
            RegisterButton.AutoGenerateColors = false;
            RegisterButton.AutoRoundBorders = false;
            RegisterButton.AutoSizeLeftIcon = true;
            RegisterButton.AutoSizeRightIcon = true;
            RegisterButton.BackColor = Color.Transparent;
            RegisterButton.BackColor1 = Color.DodgerBlue;
            RegisterButton.BackgroundImage = (Image)resources.GetObject("RegisterButton.BackgroundImage");
            RegisterButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RegisterButton.ButtonText = "Register";
            RegisterButton.ButtonTextMarginLeft = 0;
            RegisterButton.ColorContrastOnClick = 45;
            RegisterButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            RegisterButton.CustomizableEdges = borderEdges1;
            RegisterButton.DialogResult = DialogResult.None;
            RegisterButton.DisabledBorderColor = Color.Silver;
            RegisterButton.DisabledFillColor = Color.DodgerBlue;
            RegisterButton.DisabledForecolor = Color.White;
            RegisterButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            RegisterButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            RegisterButton.IconLeftCursor = Cursors.Default;
            RegisterButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            RegisterButton.IconMarginLeft = 11;
            RegisterButton.IconPadding = 10;
            RegisterButton.IconRightAlign = ContentAlignment.MiddleRight;
            RegisterButton.IconRightCursor = Cursors.Default;
            RegisterButton.IconRightPadding = new Padding(3, 3, 7, 3);
            RegisterButton.IconSize = 25;
            RegisterButton.IdleBorderColor = Color.Silver;
            RegisterButton.IdleBorderRadius = 1;
            RegisterButton.IdleBorderThickness = 1;
            RegisterButton.IdleFillColor = Color.DodgerBlue;
            RegisterButton.IdleIconLeftImage = null;
            RegisterButton.IdleIconRightImage = null;
            RegisterButton.IndicateFocus = false;
            RegisterButton.Location = new Point(57, 507);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.OnDisabledState.BorderColor = Color.Silver;
            RegisterButton.OnDisabledState.BorderRadius = 1;
            RegisterButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RegisterButton.OnDisabledState.BorderThickness = 1;
            RegisterButton.OnDisabledState.FillColor = Color.DodgerBlue;
            RegisterButton.OnDisabledState.ForeColor = Color.White;
            RegisterButton.OnDisabledState.IconLeftImage = null;
            RegisterButton.OnDisabledState.IconRightImage = null;
            RegisterButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            RegisterButton.onHoverState.BorderRadius = 1;
            RegisterButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RegisterButton.onHoverState.BorderThickness = 1;
            RegisterButton.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            RegisterButton.onHoverState.ForeColor = Color.White;
            RegisterButton.onHoverState.IconLeftImage = null;
            RegisterButton.onHoverState.IconRightImage = null;
            RegisterButton.OnIdleState.BorderColor = Color.Silver;
            RegisterButton.OnIdleState.BorderRadius = 1;
            RegisterButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RegisterButton.OnIdleState.BorderThickness = 1;
            RegisterButton.OnIdleState.FillColor = Color.DodgerBlue;
            RegisterButton.OnIdleState.ForeColor = Color.White;
            RegisterButton.OnIdleState.IconLeftImage = null;
            RegisterButton.OnIdleState.IconRightImage = null;
            RegisterButton.OnPressedState.BorderColor = Color.Silver;
            RegisterButton.OnPressedState.BorderRadius = 1;
            RegisterButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            RegisterButton.OnPressedState.BorderThickness = 1;
            RegisterButton.OnPressedState.FillColor = Color.DodgerBlue;
            RegisterButton.OnPressedState.ForeColor = Color.White;
            RegisterButton.OnPressedState.IconLeftImage = null;
            RegisterButton.OnPressedState.IconRightImage = null;
            RegisterButton.Size = new Size(325, 54);
            RegisterButton.TabIndex = 7;
            RegisterButton.TextAlign = ContentAlignment.MiddleCenter;
            RegisterButton.TextAlignment = HorizontalAlignment.Center;
            RegisterButton.TextMarginLeft = 0;
            RegisterButton.TextPadding = new Padding(0);
            RegisterButton.UseDefaultRadiusAndThickness = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AllowAnimations = true;
            LoginButton.AllowMouseEffects = true;
            LoginButton.AllowToggling = false;
            LoginButton.AnimationSpeed = 200;
            LoginButton.AutoGenerateColors = false;
            LoginButton.AutoRoundBorders = false;
            LoginButton.AutoSizeLeftIcon = true;
            LoginButton.AutoSizeRightIcon = true;
            LoginButton.BackColor = Color.Transparent;
            LoginButton.BackColor1 = Color.DodgerBlue;
            LoginButton.BackgroundImage = (Image)resources.GetObject("LoginButton.BackgroundImage");
            LoginButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LoginButton.ButtonText = "LOG IN";
            LoginButton.ButtonTextMarginLeft = 0;
            LoginButton.ColorContrastOnClick = 45;
            LoginButton.ColorContrastOnHover = 45;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            LoginButton.CustomizableEdges = borderEdges2;
            LoginButton.DialogResult = DialogResult.None;
            LoginButton.DisabledBorderColor = Color.Silver;
            LoginButton.DisabledFillColor = Color.DodgerBlue;
            LoginButton.DisabledForecolor = Color.White;
            LoginButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            LoginButton.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.ForeColor = Color.White;
            LoginButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            LoginButton.IconLeftCursor = Cursors.Default;
            LoginButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            LoginButton.IconMarginLeft = 11;
            LoginButton.IconPadding = 10;
            LoginButton.IconRightAlign = ContentAlignment.MiddleRight;
            LoginButton.IconRightCursor = Cursors.Default;
            LoginButton.IconRightPadding = new Padding(3, 3, 7, 3);
            LoginButton.IconSize = 25;
            LoginButton.IdleBorderColor = Color.Silver;
            LoginButton.IdleBorderRadius = 1;
            LoginButton.IdleBorderThickness = 1;
            LoginButton.IdleFillColor = Color.DodgerBlue;
            LoginButton.IdleIconLeftImage = null;
            LoginButton.IdleIconRightImage = null;
            LoginButton.IndicateFocus = false;
            LoginButton.Location = new Point(57, 430);
            LoginButton.Name = "LoginButton";
            LoginButton.OnDisabledState.BorderColor = Color.Silver;
            LoginButton.OnDisabledState.BorderRadius = 1;
            LoginButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LoginButton.OnDisabledState.BorderThickness = 1;
            LoginButton.OnDisabledState.FillColor = Color.DodgerBlue;
            LoginButton.OnDisabledState.ForeColor = Color.White;
            LoginButton.OnDisabledState.IconLeftImage = null;
            LoginButton.OnDisabledState.IconRightImage = null;
            LoginButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            LoginButton.onHoverState.BorderRadius = 1;
            LoginButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LoginButton.onHoverState.BorderThickness = 1;
            LoginButton.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            LoginButton.onHoverState.ForeColor = Color.White;
            LoginButton.onHoverState.IconLeftImage = null;
            LoginButton.onHoverState.IconRightImage = null;
            LoginButton.OnIdleState.BorderColor = Color.Silver;
            LoginButton.OnIdleState.BorderRadius = 1;
            LoginButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LoginButton.OnIdleState.BorderThickness = 1;
            LoginButton.OnIdleState.FillColor = Color.DodgerBlue;
            LoginButton.OnIdleState.ForeColor = Color.White;
            LoginButton.OnIdleState.IconLeftImage = null;
            LoginButton.OnIdleState.IconRightImage = null;
            LoginButton.OnPressedState.BorderColor = Color.Silver;
            LoginButton.OnPressedState.BorderRadius = 1;
            LoginButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LoginButton.OnPressedState.BorderThickness = 1;
            LoginButton.OnPressedState.FillColor = Color.DodgerBlue;
            LoginButton.OnPressedState.ForeColor = Color.White;
            LoginButton.OnPressedState.IconLeftImage = null;
            LoginButton.OnPressedState.IconRightImage = null;
            LoginButton.Size = new Size(325, 54);
            LoginButton.TabIndex = 6;
            LoginButton.TextAlign = ContentAlignment.MiddleCenter;
            LoginButton.TextAlignment = HorizontalAlignment.Center;
            LoginButton.TextMarginLeft = 0;
            LoginButton.TextPadding = new Padding(0);
            LoginButton.UseDefaultRadiusAndThickness = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RememberMeLabel
            // 
            RememberMeLabel.AllowParentOverrides = false;
            RememberMeLabel.AutoEllipsis = false;
            RememberMeLabel.CursorType = Cursors.Default;
            RememberMeLabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Italic, GraphicsUnit.Point, 204);
            RememberMeLabel.ForeColor = SystemColors.ControlText;
            RememberMeLabel.Location = new Point(120, 354);
            RememberMeLabel.Name = "RememberMeLabel";
            RememberMeLabel.RightToLeft = RightToLeft.No;
            RememberMeLabel.Size = new Size(232, 45);
            RememberMeLabel.TabIndex = 5;
            RememberMeLabel.Text = "Remember me";
            RememberMeLabel.TextAlignment = ContentAlignment.TopLeft;
            RememberMeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RememberMeButton
            // 
            RememberMeButton.AllowBindingControlAnimation = true;
            RememberMeButton.AllowBindingControlColorChanges = false;
            RememberMeButton.AllowBindingControlLocation = true;
            RememberMeButton.AllowCheckBoxAnimation = false;
            RememberMeButton.AllowCheckmarkAnimation = true;
            RememberMeButton.AllowOnHoverStates = true;
            RememberMeButton.AutoCheck = true;
            RememberMeButton.BackColor = Color.Transparent;
            RememberMeButton.BackgroundImage = (Image)resources.GetObject("RememberMeButton.BackgroundImage");
            RememberMeButton.BackgroundImageLayout = ImageLayout.Zoom;
            RememberMeButton.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            RememberMeButton.BorderRadius = 12;
            RememberMeButton.Checked = false;
            RememberMeButton.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            RememberMeButton.CustomCheckmarkImage = null;
            RememberMeButton.Location = new Point(86, 363);
            RememberMeButton.MinimumSize = new Size(17, 17);
            RememberMeButton.Name = "RememberMeButton";
            RememberMeButton.OnCheck.BorderColor = Color.DodgerBlue;
            RememberMeButton.OnCheck.BorderRadius = 12;
            RememberMeButton.OnCheck.BorderThickness = 2;
            RememberMeButton.OnCheck.CheckBoxColor = Color.DodgerBlue;
            RememberMeButton.OnCheck.CheckmarkColor = Color.White;
            RememberMeButton.OnCheck.CheckmarkThickness = 2;
            RememberMeButton.OnDisable.BorderColor = Color.LightGray;
            RememberMeButton.OnDisable.BorderRadius = 12;
            RememberMeButton.OnDisable.BorderThickness = 2;
            RememberMeButton.OnDisable.CheckBoxColor = Color.Transparent;
            RememberMeButton.OnDisable.CheckmarkColor = Color.LightGray;
            RememberMeButton.OnDisable.CheckmarkThickness = 2;
            RememberMeButton.OnHoverChecked.BorderColor = Color.FromArgb(105, 181, 255);
            RememberMeButton.OnHoverChecked.BorderRadius = 12;
            RememberMeButton.OnHoverChecked.BorderThickness = 2;
            RememberMeButton.OnHoverChecked.CheckBoxColor = Color.FromArgb(105, 181, 255);
            RememberMeButton.OnHoverChecked.CheckmarkColor = Color.White;
            RememberMeButton.OnHoverChecked.CheckmarkThickness = 2;
            RememberMeButton.OnHoverUnchecked.BorderColor = Color.FromArgb(105, 181, 255);
            RememberMeButton.OnHoverUnchecked.BorderRadius = 12;
            RememberMeButton.OnHoverUnchecked.BorderThickness = 1;
            RememberMeButton.OnHoverUnchecked.CheckBoxColor = Color.Transparent;
            RememberMeButton.OnUncheck.BorderColor = Color.DarkGray;
            RememberMeButton.OnUncheck.BorderRadius = 12;
            RememberMeButton.OnUncheck.BorderThickness = 1;
            RememberMeButton.OnUncheck.CheckBoxColor = Color.Transparent;
            RememberMeButton.Size = new Size(26, 26);
            RememberMeButton.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            RememberMeButton.TabIndex = 4;
            RememberMeButton.ThreeState = false;
            RememberMeButton.ToolTipText = null;
            RememberMeButton.CheckedChanged += RememberMeButton_CheckedChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AcceptsReturn = false;
            PasswordTextBox.AcceptsTab = false;
            PasswordTextBox.AnimationSpeed = 200;
            PasswordTextBox.AutoCompleteMode = AutoCompleteMode.None;
            PasswordTextBox.AutoCompleteSource = AutoCompleteSource.None;
            PasswordTextBox.AutoSizeHeight = true;
            PasswordTextBox.BackColor = Color.White;
            PasswordTextBox.BackgroundImage = (Image)resources.GetObject("PasswordTextBox.BackgroundImage");
            PasswordTextBox.BorderColorActive = Color.DodgerBlue;
            PasswordTextBox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            PasswordTextBox.BorderColorHover = Color.FromArgb(105, 181, 255);
            PasswordTextBox.BorderColorIdle = Color.Silver;
            PasswordTextBox.BorderRadius = 1;
            PasswordTextBox.BorderThickness = 1;
            PasswordTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            PasswordTextBox.CharacterCasing = CharacterCasing.Normal;
            PasswordTextBox.DefaultFont = new Font("Segoe UI", 9.25F);
            PasswordTextBox.DefaultText = "";
            PasswordTextBox.FillColor = Color.White;
            PasswordTextBox.HideSelection = true;
            PasswordTextBox.IconLeft = (Image)resources.GetObject("PasswordTextBox.IconLeft");
            PasswordTextBox.IconLeftCursor = Cursors.IBeam;
            PasswordTextBox.IconPadding = 10;
            PasswordTextBox.IconRight = null;
            PasswordTextBox.IconRightCursor = Cursors.IBeam;
            PasswordTextBox.Location = new Point(57, 280);
            PasswordTextBox.MaxLength = 32767;
            PasswordTextBox.MinimumSize = new Size(1, 1);
            PasswordTextBox.Modified = false;
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            PasswordTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            PasswordTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            PasswordTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            PasswordTextBox.OnIdleState = stateProperties4;
            PasswordTextBox.Padding = new Padding(3);
            PasswordTextBox.PasswordChar = '\0';
            PasswordTextBox.PlaceholderForeColor = Color.Silver;
            PasswordTextBox.PlaceholderText = "Your Password";
            PasswordTextBox.ReadOnly = false;
            PasswordTextBox.ScrollBars = ScrollBars.None;
            PasswordTextBox.SelectedText = "";
            PasswordTextBox.SelectionLength = 0;
            PasswordTextBox.SelectionStart = 0;
            PasswordTextBox.ShortcutsEnabled = true;
            PasswordTextBox.Size = new Size(325, 43);
            PasswordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.TextAlign = HorizontalAlignment.Left;
            PasswordTextBox.TextMarginBottom = 0;
            PasswordTextBox.TextMarginLeft = 3;
            PasswordTextBox.TextMarginTop = 1;
            PasswordTextBox.TextPlaceholder = "Your Password";
            PasswordTextBox.UseSystemPasswordChar = false;
            PasswordTextBox.WordWrap = true;
            PasswordTextBox.TextChanged += PasswordText_TextChanged;
            // 
            // LogoPicture
            // 
            LogoPicture.AllowFocused = false;
            LogoPicture.Anchor = AnchorStyles.None;
            LogoPicture.AutoSizeHeight = true;
            LogoPicture.BorderRadius = 80;
            LogoPicture.Image = (Image)resources.GetObject("LogoPicture.Image");
            LogoPicture.IsCircle = true;
            LogoPicture.Location = new Point(139, 0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(160, 160);
            LogoPicture.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicture.TabIndex = 2;
            LogoPicture.TabStop = false;
            LogoPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // LoginLabel
            // 
            LoginLabel.AllowParentOverrides = false;
            LoginLabel.AutoEllipsis = false;
            LoginLabel.CursorType = Cursors.Default;
            LoginLabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(78, 146);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.RightToLeft = RightToLeft.No;
            LoginLabel.Size = new Size(283, 45);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "ApplicationName";
            LoginLabel.TextAlignment = ContentAlignment.TopLeft;
            LoginLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.AcceptsReturn = false;
            UsernameTextBox.AcceptsTab = false;
            UsernameTextBox.AnimationSpeed = 200;
            UsernameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            UsernameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            UsernameTextBox.AutoSizeHeight = true;
            UsernameTextBox.BackColor = Color.White;
            UsernameTextBox.BackgroundImage = (Image)resources.GetObject("UsernameTextBox.BackgroundImage");
            UsernameTextBox.BorderColorActive = Color.DodgerBlue;
            UsernameTextBox.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            UsernameTextBox.BorderColorHover = Color.FromArgb(105, 181, 255);
            UsernameTextBox.BorderColorIdle = Color.Silver;
            UsernameTextBox.BorderRadius = 1;
            UsernameTextBox.BorderThickness = 1;
            UsernameTextBox.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            UsernameTextBox.CharacterCasing = CharacterCasing.Normal;
            UsernameTextBox.DefaultFont = new Font("Segoe UI", 9.25F);
            UsernameTextBox.DefaultText = "";
            UsernameTextBox.FillColor = Color.White;
            UsernameTextBox.HideSelection = true;
            UsernameTextBox.IconLeft = Properties.Resources.icons8_user_50;
            UsernameTextBox.IconLeftCursor = Cursors.IBeam;
            UsernameTextBox.IconPadding = 10;
            UsernameTextBox.IconRight = null;
            UsernameTextBox.IconRightCursor = Cursors.IBeam;
            UsernameTextBox.Location = new Point(57, 211);
            UsernameTextBox.MaxLength = 32767;
            UsernameTextBox.MinimumSize = new Size(1, 1);
            UsernameTextBox.Modified = false;
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            UsernameTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            UsernameTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            UsernameTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            UsernameTextBox.OnIdleState = stateProperties8;
            UsernameTextBox.Padding = new Padding(3);
            UsernameTextBox.PasswordChar = '\0';
            UsernameTextBox.PlaceholderForeColor = Color.Silver;
            UsernameTextBox.PlaceholderText = "Enter Username";
            UsernameTextBox.ReadOnly = false;
            UsernameTextBox.ScrollBars = ScrollBars.None;
            UsernameTextBox.SelectedText = "";
            UsernameTextBox.SelectionLength = 0;
            UsernameTextBox.SelectionStart = 0;
            UsernameTextBox.ShortcutsEnabled = true;
            UsernameTextBox.Size = new Size(325, 43);
            UsernameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.TextAlign = HorizontalAlignment.Left;
            UsernameTextBox.TextMarginBottom = 0;
            UsernameTextBox.TextMarginLeft = 3;
            UsernameTextBox.TextMarginTop = 1;
            UsernameTextBox.TextPlaceholder = "Enter Username";
            UsernameTextBox.UseSystemPasswordChar = false;
            UsernameTextBox.WordWrap = true;
            UsernameTextBox.TextChanged += UsernameText_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(439, 616);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel Background;
        private Bunifu.UI.WinForms.BunifuTextBox UsernameTextBox;
        private Bunifu.UI.WinForms.BunifuLabel LoginLabel;
        private Bunifu.UI.WinForms.BunifuPictureBox LogoPicture;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTextBox;
        private Bunifu.UI.WinForms.BunifuCheckBox RememberMeButton;
        private Bunifu.UI.WinForms.BunifuLabel RememberMeLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LoginButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RegisterButton;
    }
}
