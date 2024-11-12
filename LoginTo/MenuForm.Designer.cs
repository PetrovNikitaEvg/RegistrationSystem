namespace LoginTo
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Background = new Bunifu.UI.WinForms.BunifuGradientPanel();
            UserDBView = new Bunifu.UI.WinForms.BunifuDataGridView();
            LogoutButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            LogoPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            LoginLabel = new Bunifu.UI.WinForms.BunifuLabel();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDBView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).BeginInit();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.Transparent;
            Background.BackgroundImage = (Image)resources.GetObject("Background.BackgroundImage");
            Background.BackgroundImageLayout = ImageLayout.Stretch;
            Background.BorderRadius = 1;
            Background.Controls.Add(UserDBView);
            Background.Controls.Add(LogoutButton);
            Background.Controls.Add(LogoPicture);
            Background.Controls.Add(LoginLabel);
            Background.Dock = DockStyle.Fill;
            Background.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Background.GradientBottomLeft = Color.FromArgb(69, 104, 202);
            Background.GradientBottomRight = Color.FromArgb(208, 78, 214);
            Background.GradientTopLeft = Color.FromArgb(208, 78, 214);
            Background.GradientTopRight = Color.FromArgb(131, 77, 155);
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Quality = 10;
            Background.Size = new Size(403, 522);
            Background.TabIndex = 2;
            // 
            // UserDBView
            // 
            UserDBView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 251, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            UserDBView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UserDBView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UserDBView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UserDBView.BackgroundColor = Color.Snow;
            UserDBView.BorderStyle = BorderStyle.Fixed3D;
            UserDBView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            UserDBView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 4.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 115, 204);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDBView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDBView.ColumnHeadersHeight = 20;
            UserDBView.CurrentTheme.AlternatingRowsStyle.BackColor = Color.FromArgb(248, 251, 255);
            UserDBView.CurrentTheme.AlternatingRowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            UserDBView.CurrentTheme.AlternatingRowsStyle.ForeColor = Color.Black;
            UserDBView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            UserDBView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = Color.Black;
            UserDBView.CurrentTheme.BackColor = Color.White;
            UserDBView.CurrentTheme.GridColor = Color.FromArgb(221, 238, 255);
            UserDBView.CurrentTheme.HeaderStyle.BackColor = Color.DodgerBlue;
            UserDBView.CurrentTheme.HeaderStyle.Font = new Font("Segoe UI Semibold", 11.75F, FontStyle.Bold);
            UserDBView.CurrentTheme.HeaderStyle.ForeColor = Color.White;
            UserDBView.CurrentTheme.HeaderStyle.SelectionBackColor = Color.FromArgb(24, 115, 204);
            UserDBView.CurrentTheme.HeaderStyle.SelectionForeColor = Color.White;
            UserDBView.CurrentTheme.Name = null;
            UserDBView.CurrentTheme.RowsStyle.BackColor = Color.White;
            UserDBView.CurrentTheme.RowsStyle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            UserDBView.CurrentTheme.RowsStyle.ForeColor = Color.Black;
            UserDBView.CurrentTheme.RowsStyle.SelectionBackColor = Color.FromArgb(210, 232, 255);
            UserDBView.CurrentTheme.RowsStyle.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 232, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDBView.DefaultCellStyle = dataGridViewCellStyle3;
            UserDBView.GridColor = Color.FromArgb(221, 238, 255);
            UserDBView.HeaderBackColor = Color.DodgerBlue;
            UserDBView.HeaderBgColor = Color.Empty;
            UserDBView.HeaderForeColor = Color.White;
            UserDBView.Location = new Point(39, 171);
            UserDBView.Name = "UserDBView";
            UserDBView.ReadOnly = true;
            UserDBView.RowHeadersVisible = false;
            UserDBView.RowHeadersWidth = 51;
            UserDBView.RowTemplate.Height = 40;
            UserDBView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserDBView.Size = new Size(325, 220);
            UserDBView.TabIndex = 8;
            UserDBView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // LogoutButton
            // 
            LogoutButton.AllowAnimations = true;
            LogoutButton.AllowMouseEffects = true;
            LogoutButton.AllowToggling = false;
            LogoutButton.AnimationSpeed = 200;
            LogoutButton.AutoGenerateColors = false;
            LogoutButton.AutoRoundBorders = false;
            LogoutButton.AutoSizeLeftIcon = true;
            LogoutButton.AutoSizeRightIcon = true;
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.BackColor1 = Color.DodgerBlue;
            LogoutButton.BackgroundImage = (Image)resources.GetObject("LogoutButton.BackgroundImage");
            LogoutButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LogoutButton.ButtonText = "LOGOUT";
            LogoutButton.ButtonTextMarginLeft = 0;
            LogoutButton.ColorContrastOnClick = 45;
            LogoutButton.ColorContrastOnHover = 45;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            LogoutButton.CustomizableEdges = borderEdges1;
            LogoutButton.DialogResult = DialogResult.None;
            LogoutButton.DisabledBorderColor = Color.Silver;
            LogoutButton.DisabledFillColor = Color.DodgerBlue;
            LogoutButton.DisabledForecolor = Color.White;
            LogoutButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            LogoutButton.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.IconLeftAlign = ContentAlignment.MiddleLeft;
            LogoutButton.IconLeftCursor = Cursors.Default;
            LogoutButton.IconLeftPadding = new Padding(11, 3, 3, 3);
            LogoutButton.IconMarginLeft = 11;
            LogoutButton.IconPadding = 10;
            LogoutButton.IconRightAlign = ContentAlignment.MiddleRight;
            LogoutButton.IconRightCursor = Cursors.Default;
            LogoutButton.IconRightPadding = new Padding(3, 3, 7, 3);
            LogoutButton.IconSize = 25;
            LogoutButton.IdleBorderColor = Color.Silver;
            LogoutButton.IdleBorderRadius = 1;
            LogoutButton.IdleBorderThickness = 1;
            LogoutButton.IdleFillColor = Color.DodgerBlue;
            LogoutButton.IdleIconLeftImage = null;
            LogoutButton.IdleIconRightImage = null;
            LogoutButton.IndicateFocus = false;
            LogoutButton.Location = new Point(39, 415);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.OnDisabledState.BorderColor = Color.Silver;
            LogoutButton.OnDisabledState.BorderRadius = 1;
            LogoutButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LogoutButton.OnDisabledState.BorderThickness = 1;
            LogoutButton.OnDisabledState.FillColor = Color.DodgerBlue;
            LogoutButton.OnDisabledState.ForeColor = Color.White;
            LogoutButton.OnDisabledState.IconLeftImage = null;
            LogoutButton.OnDisabledState.IconRightImage = null;
            LogoutButton.onHoverState.BorderColor = Color.FromArgb(105, 181, 255);
            LogoutButton.onHoverState.BorderRadius = 1;
            LogoutButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LogoutButton.onHoverState.BorderThickness = 1;
            LogoutButton.onHoverState.FillColor = Color.FromArgb(105, 181, 255);
            LogoutButton.onHoverState.ForeColor = Color.White;
            LogoutButton.onHoverState.IconLeftImage = null;
            LogoutButton.onHoverState.IconRightImage = null;
            LogoutButton.OnIdleState.BorderColor = Color.Silver;
            LogoutButton.OnIdleState.BorderRadius = 1;
            LogoutButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LogoutButton.OnIdleState.BorderThickness = 1;
            LogoutButton.OnIdleState.FillColor = Color.DodgerBlue;
            LogoutButton.OnIdleState.ForeColor = Color.White;
            LogoutButton.OnIdleState.IconLeftImage = null;
            LogoutButton.OnIdleState.IconRightImage = null;
            LogoutButton.OnPressedState.BorderColor = Color.Silver;
            LogoutButton.OnPressedState.BorderRadius = 1;
            LogoutButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            LogoutButton.OnPressedState.BorderThickness = 1;
            LogoutButton.OnPressedState.FillColor = Color.DodgerBlue;
            LogoutButton.OnPressedState.ForeColor = Color.White;
            LogoutButton.OnPressedState.IconLeftImage = null;
            LogoutButton.OnPressedState.IconRightImage = null;
            LogoutButton.Size = new Size(325, 54);
            LogoutButton.TabIndex = 7;
            LogoutButton.TextAlign = ContentAlignment.MiddleCenter;
            LogoutButton.TextAlignment = HorizontalAlignment.Center;
            LogoutButton.TextMarginLeft = 0;
            LogoutButton.TextPadding = new Padding(0);
            LogoutButton.UseDefaultRadiusAndThickness = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // LogoPicture
            // 
            LogoPicture.AllowFocused = false;
            LogoPicture.Anchor = AnchorStyles.None;
            LogoPicture.AutoSizeHeight = true;
            LogoPicture.BorderRadius = 61;
            LogoPicture.Image = (Image)resources.GetObject("LogoPicture.Image");
            LogoPicture.IsCircle = true;
            LogoPicture.Location = new Point(140, 0);
            LogoPicture.Name = "LogoPicture";
            LogoPicture.Size = new Size(122, 122);
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
            LoginLabel.Location = new Point(106, 111);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.RightToLeft = RightToLeft.No;
            LoginLabel.Size = new Size(190, 45);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "User Profile";
            LoginLabel.TextAlignment = ContentAlignment.TopLeft;
            LoginLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 522);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            Load += MenuForm_Load;
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDBView).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel Background;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 LogoutButton;
        private Bunifu.UI.WinForms.BunifuPictureBox LogoPicture;
        private Bunifu.UI.WinForms.BunifuLabel LoginLabel;
        private Bunifu.UI.WinForms.BunifuDataGridView UserDBView;
    }
}