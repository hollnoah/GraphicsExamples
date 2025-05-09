﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphicsExamplesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawingToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.WaveButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(791, 28)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorTopMenuItem, Me.BackgroundColorTopMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ForegroundColorTopMenuItem
        '
        Me.ForegroundColorTopMenuItem.Name = "ForegroundColorTopMenuItem"
        Me.ForegroundColorTopMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ForegroundColorTopMenuItem.Text = "&Foreground  Color"
        '
        'BackgroundColorTopMenuItem
        '
        Me.BackgroundColorTopMenuItem.Name = "BackgroundColorTopMenuItem"
        Me.BackgroundColorTopMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.BackgroundColorTopMenuItem.Text = "&Background Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorContextMenuItem, Me.BackgroundColorContextMenuItem, Me.FontContextMenuItem, Me.ClearContextMenuItem, Me.WidthToolStripMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(198, 124)
        '
        'ForegroundColorContextMenuItem
        '
        Me.ForegroundColorContextMenuItem.Name = "ForegroundColorContextMenuItem"
        Me.ForegroundColorContextMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ForegroundColorContextMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorContextMenuItem
        '
        Me.BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem"
        Me.BackgroundColorContextMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.BackgroundColorContextMenuItem.Text = "Background Color"
        '
        'FontContextMenuItem
        '
        Me.FontContextMenuItem.Name = "FontContextMenuItem"
        Me.FontContextMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.FontContextMenuItem.Text = "Font"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'WidthToolStripMenuItem
        '
        Me.WidthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.WidthToolStripMenuItem.Name = "WidthToolStripMenuItem"
        Me.WidthToolStripMenuItem.Size = New System.Drawing.Size(197, 24)
        Me.WidthToolStripMenuItem.Text = "Width"
        '
        'PickToolStripMenuItem
        '
        Me.PickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FjToolStripMenuItem, Me.ErToolStripMenuItem})
        Me.PickToolStripMenuItem.Name = "PickToolStripMenuItem"
        Me.PickToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.PickToolStripMenuItem.Text = "Pick"
        '
        'FjToolStripMenuItem
        '
        Me.FjToolStripMenuItem.Name = "FjToolStripMenuItem"
        Me.FjToolStripMenuItem.Size = New System.Drawing.Size(105, 26)
        '
        'ErToolStripMenuItem
        '
        Me.ErToolStripMenuItem.Name = "ErToolStripMenuItem"
        Me.ErToolStripMenuItem.Size = New System.Drawing.Size(105, 26)
        Me.ErToolStripMenuItem.Text = "er"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 31)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(767, 327)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        Me.DrawingToolTip.SetToolTip(Me.DrawingPictureBox, "Right Click For More Options")
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.WaveButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(3, 377)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(776, 121)
        Me.ButtonGroupBox.TabIndex = 2
        Me.ButtonGroupBox.TabStop = False
        '
        'WaveButton
        '
        Me.WaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WaveButton.Location = New System.Drawing.Point(639, 30)
        Me.WaveButton.Name = "WaveButton"
        Me.WaveButton.Size = New System.Drawing.Size(123, 66)
        Me.WaveButton.TabIndex = 0
        Me.WaveButton.Text = "&Wave"
        Me.WaveButton.UseVisualStyleBackColor = True
        '
        'GraphicsExamplesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 508)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "GraphicsExamplesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.DrawingToolTip.SetToolTip(Me, "This is the form")
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForegroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ForegroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents FontContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents BackgroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents WidthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FjToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingToolTip As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents WaveButton As Button
End Class
