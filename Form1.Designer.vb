<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BlankBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MhjkjhkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebControl3 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.WebControl2 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog3 = New System.Windows.Forms.SaveFileDialog()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 981)
        Me.SplitContainer1.SplitterDistance = 48
        Me.SplitContainer1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(194, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 37)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(255, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 37)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(1155, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = ""
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(316, 8)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(772, 37)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(1094, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlankBrowserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 48)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BlankBrowserToolStripMenuItem
        '
        Me.BlankBrowserToolStripMenuItem.AutoSize = False
        Me.BlankBrowserToolStripMenuItem.BackgroundImage = CType(resources.GetObject("BlankBrowserToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.BlankBrowserToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BlankBrowserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MhjkjhkToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.BlankBrowserToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BlankBrowserToolStripMenuItem.Name = "BlankBrowserToolStripMenuItem"
        Me.BlankBrowserToolStripMenuItem.Size = New System.Drawing.Size(94, 44)
        Me.BlankBrowserToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MhjkjhkToolStripMenuItem
        '
        Me.MhjkjhkToolStripMenuItem.Image = CType(resources.GetObject("MhjkjhkToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MhjkjhkToolStripMenuItem.Name = "MhjkjhkToolStripMenuItem"
        Me.MhjkjhkToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MhjkjhkToolStripMenuItem.Text = "Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WebControl3
        '
        Me.WebControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl3.Location = New System.Drawing.Point(0, 0)
        Me.WebControl3.Size = New System.Drawing.Size(1264, 929)
        Me.WebControl3.Source = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        Me.WebControl3.TabIndex = 0
        '
        'WebControl2
        '
        Me.WebControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl2.Location = New System.Drawing.Point(0, 0)
        Me.WebControl2.Size = New System.Drawing.Size(1264, 929)
        Me.WebControl2.Source = New System.Uri("https://www.google.com", System.UriKind.Absolute)
        Me.WebControl2.TabIndex = 0
        '
        'WebControl1
        '
        Me.WebControl1.AccessibleDescription = ""
        Me.WebControl1.AccessibleName = ""
        Me.WebControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl1.Location = New System.Drawing.Point(0, 0)
        Me.WebControl1.Size = New System.Drawing.Size(1264, 929)
        Me.WebControl1.Source = New System.Uri("https://www.google.com", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 0
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Image = CType(resources.GetObject("AboutUsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 981)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "WaterFox"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BlankBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MhjkjhkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents SaveFileDialog3 As SaveFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Private WithEvents WebControl2 As Awesomium.Windows.Forms.WebControl
    Private WithEvents WebControl3 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
End Class
