<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameStartForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameStartForm))
        Me.AstralBackground = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TierSelect = New System.Windows.Forms.ListBox()
        Me.WeatherSelect = New System.Windows.Forms.ListBox()
        Me.SelectIonParameterLabel = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.AstralBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AstralBackground
        '
        Me.AstralBackground.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AstralBackground.BackgroundImage = CType(resources.GetObject("AstralBackground.BackgroundImage"), System.Drawing.Image)
        Me.AstralBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AstralBackground.Location = New System.Drawing.Point(80, -31)
        Me.AstralBackground.Name = "AstralBackground"
        Me.AstralBackground.Size = New System.Drawing.Size(600, 600)
        Me.AstralBackground.TabIndex = 0
        Me.AstralBackground.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("AniMe Matrix - MB_EN", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.Image = Global.VB_game.My.Resources.Resources.TrigStartv2
        Me.Button1.Location = New System.Drawing.Point(300, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TierSelect
        '
        Me.TierSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TierSelect.Font = New System.Drawing.Font("AniMe Matrix - MB_EN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TierSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TierSelect.FormattingEnabled = True
        Me.TierSelect.ItemHeight = 19
        Me.TierSelect.Items.AddRange(New Object() {"T0", "T1", "T2", "T3", "T4", "T5", "T6"})
        Me.TierSelect.Location = New System.Drawing.Point(728, 24)
        Me.TierSelect.Name = "TierSelect"
        Me.TierSelect.Size = New System.Drawing.Size(49, 137)
        Me.TierSelect.TabIndex = 2
        '
        'WeatherSelect
        '
        Me.WeatherSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.WeatherSelect.Font = New System.Drawing.Font("AniMe Matrix - MB_EN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeatherSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WeatherSelect.FormattingEnabled = True
        Me.WeatherSelect.ItemHeight = 19
        Me.WeatherSelect.Items.AddRange(New Object() {"Electrical", "Exotic", "Firestorm", "Gamma", "Dark"})
        Me.WeatherSelect.Location = New System.Drawing.Point(587, 24)
        Me.WeatherSelect.Name = "WeatherSelect"
        Me.WeatherSelect.Size = New System.Drawing.Size(135, 99)
        Me.WeatherSelect.TabIndex = 3
        '
        'SelectIonParameterLabel
        '
        Me.SelectIonParameterLabel.AutoSize = True
        Me.SelectIonParameterLabel.Font = New System.Drawing.Font("AniMe Matrix - MB_EN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectIonParameterLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectIonParameterLabel.Location = New System.Drawing.Point(441, 2)
        Me.SelectIonParameterLabel.Name = "SelectIonParameterLabel"
        Me.SelectIonParameterLabel.Size = New System.Drawing.Size(341, 19)
        Me.SelectIonParameterLabel.TabIndex = 4
        Me.SelectIonParameterLabel.Text = "Type                 Weather       Tier"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("AniMe Matrix - MB_EN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"Frigate", "Destroyer", "Cruiser"})
        Me.ListBox1.Location = New System.Drawing.Point(443, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(138, 61)
        Me.ListBox1.TabIndex = 5
        '
        'GameStartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SelectIonParameterLabel)
        Me.Controls.Add(Me.WeatherSelect)
        Me.Controls.Add(Me.TierSelect)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AstralBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "GameStartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB game"
        CType(Me.AstralBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AstralBackground As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TierSelect As ListBox
    Friend WithEvents WeatherSelect As ListBox
    Friend WithEvents SelectIonParameterLabel As Label
    Friend WithEvents ListBox1 As ListBox
End Class
