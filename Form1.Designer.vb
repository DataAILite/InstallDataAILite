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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtyoururlDataAI = New TextBox()
        txtyourwebsitetitle = New TextBox()
        txtyourfoldertouploadfiles = New TextBox()
        txtyourgooglemapkey = New TextBox()
        txtyourOpenAIkey = New TextBox()
        txtyourOpenAImodel = New TextBox()
        txtyourmaximumtokens = New TextBox()
        txtyourOpenAIorganizationcode = New TextBox()
        Label1 = New Label()
        progressBar1 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        LinkLabel1 = New LinkLabel()
        Label19 = New Label()
        Label20 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        Label37 = New Label()
        Label38 = New Label()
        Label48 = New Label()
        btnUpdateWebConfig = New Button()
        Label49 = New Label()
        btnRestoreDefault = New Button()
        btnShowSetting = New Button()
        LinkLabel2 = New LinkLabel()
        btnDownload = New Button()
        LinkLabel3 = New LinkLabel()
        Label4 = New Label()
        txtyourOpenAIURL = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        LinkLabel4 = New LinkLabel()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' txtyoururlDataAI
        ' 
        txtyoururlDataAI.BorderStyle = BorderStyle.FixedSingle
        txtyoururlDataAI.Location = New Point(344, 289)
        txtyoururlDataAI.Name = "txtyoururlDataAI"
        txtyoururlDataAI.Size = New Size(301, 23)
        txtyoururlDataAI.TabIndex = 16
        txtyoururlDataAI.Text = "http://localhost/DataAILite/"
        ' 
        ' txtyourwebsitetitle
        ' 
        txtyourwebsitetitle.Location = New Point(344, 318)
        txtyourwebsitetitle.Name = "txtyourwebsitetitle"
        txtyourwebsitetitle.Size = New Size(301, 23)
        txtyourwebsitetitle.TabIndex = 17
        txtyourwebsitetitle.Text = "DataAILite in memory"
        ' 
        ' txtyourfoldertouploadfiles
        ' 
        txtyourfoldertouploadfiles.BorderStyle = BorderStyle.FixedSingle
        txtyourfoldertouploadfiles.Location = New Point(344, 352)
        txtyourfoldertouploadfiles.Name = "txtyourfoldertouploadfiles"
        txtyourfoldertouploadfiles.Size = New Size(301, 23)
        txtyourfoldertouploadfiles.TabIndex = 19
        ' 
        ' txtyourgooglemapkey
        ' 
        txtyourgooglemapkey.BackColor = Color.WhiteSmoke
        txtyourgooglemapkey.Location = New Point(344, 383)
        txtyourgooglemapkey.Name = "txtyourgooglemapkey"
        txtyourgooglemapkey.Size = New Size(301, 23)
        txtyourgooglemapkey.TabIndex = 20
        ' 
        ' txtyourOpenAIkey
        ' 
        txtyourOpenAIkey.BackColor = Color.WhiteSmoke
        txtyourOpenAIkey.Location = New Point(344, 443)
        txtyourOpenAIkey.Name = "txtyourOpenAIkey"
        txtyourOpenAIkey.Size = New Size(301, 23)
        txtyourOpenAIkey.TabIndex = 21
        ' 
        ' txtyourOpenAImodel
        ' 
        txtyourOpenAImodel.Location = New Point(344, 533)
        txtyourOpenAImodel.Name = "txtyourOpenAImodel"
        txtyourOpenAImodel.Size = New Size(301, 23)
        txtyourOpenAImodel.TabIndex = 22
        txtyourOpenAImodel.Text = "gpt-4o-mini"
        ' 
        ' txtyourmaximumtokens
        ' 
        txtyourmaximumtokens.Location = New Point(344, 565)
        txtyourmaximumtokens.Name = "txtyourmaximumtokens"
        txtyourmaximumtokens.Size = New Size(301, 23)
        txtyourmaximumtokens.TabIndex = 23
        txtyourmaximumtokens.Text = "128000"
        ' 
        ' txtyourOpenAIorganizationcode
        ' 
        txtyourOpenAIorganizationcode.BackColor = Color.WhiteSmoke
        txtyourOpenAIorganizationcode.Location = New Point(344, 474)
        txtyourOpenAIorganizationcode.Name = "txtyourOpenAIorganizationcode"
        txtyourOpenAIorganizationcode.Size = New Size(301, 23)
        txtyourOpenAIorganizationcode.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(19, 229)
        Label1.Name = "Label1"
        Label1.Size = New Size(607, 21)
        Label1.TabIndex = 25
        Label1.Text = "Automatic installation. Enter (all optional) to cofigure the DataAILite web app:"
        ' 
        ' progressBar1
        ' 
        progressBar1.Location = New Point(53, 714)
        progressBar1.Name = "progressBar1"
        progressBar1.Size = New Size(401, 15)
        progressBar1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(468, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 30)
        Label2.TabIndex = 26
        Label2.Text = "DataAILite installation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(19, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 21)
        Label3.TabIndex = 27
        Label3.Text = "Manual installation:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.InactiveBorder
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Enabled = False
        RichTextBox1.Font = New Font("Arial", 10F, FontStyle.Bold)
        RichTextBox1.Location = New Point(188, 42)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1007, 172)
        RichTextBox1.TabIndex = 28
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel1.Location = New Point(836, 715)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(345, 15)
        LinkLabel1.TabIndex = 30
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "If you need further assistance with installation, please contact us"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(53, 292)
        Label19.Name = "Label19"
        Label19.Size = New Size(159, 15)
        Label19.TabIndex = 45
        Label19.Text = "[your web url for DataAILite]:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(53, 321)
        Label20.Name = "Label20"
        Label20.Size = New Size(111, 15)
        Label20.TabIndex = 46
        Label20.Text = "[your web site title]:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(53, 354)
        Label22.Name = "Label22"
        Label22.Size = New Size(212, 15)
        Label22.TabIndex = 48
        Label22.Text = "[your folder to upload temporary files]:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(53, 386)
        Label23.Name = "Label23"
        Label23.Size = New Size(130, 15)
        Label23.TabIndex = 49
        Label23.Text = "[your google map key]:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(53, 446)
        Label24.Name = "Label24"
        Label24.Size = New Size(106, 15)
        Label24.TabIndex = 50
        Label24.Text = "[your OpenAI key]:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(53, 536)
        Label25.Name = "Label25"
        Label25.Size = New Size(122, 15)
        Label25.TabIndex = 51
        Label25.Text = "[your OpenAI model]:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(53, 568)
        Label26.Name = "Label26"
        Label26.Size = New Size(180, 15)
        Label26.TabIndex = 52
        Label26.Text = "[OpenAI maximum tokens limit]:"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(53, 536)
        Label27.Name = "Label27"
        Label27.Size = New Size(0, 15)
        Label27.TabIndex = 53
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(33, 268)
        Label30.Name = "Label30"
        Label30.Size = New Size(85, 15)
        Label30.TabIndex = 56
        Label30.Text = "1. Web setting:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(33, 417)
        Label31.Name = "Label31"
        Label31.Size = New Size(101, 15)
        Label31.TabIndex = 57
        Label31.Text = "2. OpenAI setting:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(33, 602)
        Label32.Name = "Label32"
        Label32.Size = New Size(471, 15)
        Label32.TabIndex = 58
        Label32.Text = "3. All other settings in web.config are better to leave as they are to prevent misfunctions."
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(33, 627)
        Label33.Name = "Label33"
        Label33.Size = New Size(1174, 15)
        Label33.TabIndex = 59
        Label33.Text = resources.GetString("Label33.Text")
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Location = New Point(651, 292)
        Label35.Name = "Label35"
        Label35.Size = New Size(443, 15)
        Label35.TabIndex = 61
        Label35.Text = "as https://[your web]/DataAILite/ , it can be http://localhost/DataAILite/ as default."
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(651, 386)
        Label36.Name = "Label36"
        Label36.Size = New Size(223, 15)
        Label36.TabIndex = 62
        Label36.Text = "needed in Google Map and Earth reports:"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(651, 536)
        Label37.Name = "Label37"
        Label37.Size = New Size(213, 15)
        Label37.TabIndex = 63
        Label37.Text = "gpt-4o or gpt-4o-mini or o3 or o4 etc..."
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Location = New Point(651, 568)
        Label38.Name = "Label38"
        Label38.Size = New Size(316, 15)
        Label38.TabIndex = 64
        Label38.Text = "for now 128000 or 200000 or else depending on gpt version"
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.BorderStyle = BorderStyle.FixedSingle
        Label48.Location = New Point(651, 343)
        Label48.Name = "Label48"
        Label48.Size = New Size(468, 32)
        Label48.TabIndex = 75
        Label48.Text = "Folder and subfolders should have permisions to upload temporary files by application." & vbCrLf & "All temporary files will be deleted when Log Off is clicked. Default is Downloads."
        ' 
        ' btnUpdateWebConfig
        ' 
        btnUpdateWebConfig.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnUpdateWebConfig.Location = New Point(552, 675)
        btnUpdateWebConfig.Name = "btnUpdateWebConfig"
        btnUpdateWebConfig.Size = New Size(194, 33)
        btnUpdateWebConfig.TabIndex = 76
        btnUpdateWebConfig.Text = "Update configuration"
        btnUpdateWebConfig.UseVisualStyleBackColor = True
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(33, 642)
        Label49.Name = "Label49"
        Label49.Size = New Size(875, 15)
        Label49.TabIndex = 77
        Label49.Text = "    Clicking the button ""Update configuration"" below will update the existing DataAILite site configuration if needed and open the web page to connect to DataAILite. "
        ' 
        ' btnRestoreDefault
        ' 
        btnRestoreDefault.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnRestoreDefault.Location = New Point(979, 675)
        btnRestoreDefault.Name = "btnRestoreDefault"
        btnRestoreDefault.Size = New Size(202, 33)
        btnRestoreDefault.TabIndex = 82
        btnRestoreDefault.Text = "Restore default settings"
        btnRestoreDefault.UseVisualStyleBackColor = True
        ' 
        ' btnShowSetting
        ' 
        btnShowSetting.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnShowSetting.Location = New Point(752, 675)
        btnShowSetting.Name = "btnShowSetting"
        btnShowSetting.Size = New Size(221, 33)
        btnShowSetting.TabIndex = 87
        btnShowSetting.Text = "Show current settings"
        btnShowSetting.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel2.Location = New Point(552, 715)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(194, 15)
        LinkLabel2.TabIndex = 88
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "open your existing site default page"
        ' 
        ' btnDownload
        ' 
        btnDownload.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnDownload.Location = New Point(53, 675)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(401, 33)
        btnDownload.TabIndex = 89
        btnDownload.Text = "Download and Install/Update DataAILite"
        btnDownload.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel3.Location = New Point(820, 449)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(299, 15)
        LinkLabel3.TabIndex = 90
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "click to sign for OpenAI account if you do not have one"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 476)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 15)
        Label4.TabIndex = 53
        Label4.Text = "[your OpenAI organization code]:"
        ' 
        ' txtyourOpenAIURL
        ' 
        txtyourOpenAIURL.Location = New Point(344, 503)
        txtyourOpenAIURL.Name = "txtyourOpenAIURL"
        txtyourOpenAIURL.Size = New Size(301, 23)
        txtyourOpenAIURL.TabIndex = 24
        txtyourOpenAIURL.Text = "https://api.openai.com/v1/chat/completions"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(53, 506)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 15)
        Label5.TabIndex = 53
        Label5.Text = "[your OpenAI Base URL]:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(651, 506)
        Label6.Name = "Label6"
        Label6.Size = New Size(297, 15)
        Label6.TabIndex = 91
        Label6.Text = "Default is https://api.openai.com/v1/chat/completions"
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.LinkBehavior = LinkBehavior.HoverUnderline
        LinkLabel4.Location = New Point(885, 386)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(234, 15)
        LinkLabel4.TabIndex = 92
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "click to get a google map key if you need it"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(651, 449)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 15)
        Label7.TabIndex = 93
        Label7.Text = "needed to use AI for analytics"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(651, 476)
        Label8.Name = "Label8"
        Label8.Size = New Size(162, 15)
        Label8.TabIndex = 94
        Label8.Text = "needed to use AI for analytics"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1225, 739)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(LinkLabel4)
        Controls.Add(Label6)
        Controls.Add(LinkLabel3)
        Controls.Add(btnDownload)
        Controls.Add(LinkLabel2)
        Controls.Add(btnShowSetting)
        Controls.Add(btnRestoreDefault)
        Controls.Add(Label49)
        Controls.Add(btnUpdateWebConfig)
        Controls.Add(Label48)
        Controls.Add(Label38)
        Controls.Add(Label37)
        Controls.Add(Label36)
        Controls.Add(Label35)
        Controls.Add(Label33)
        Controls.Add(Label32)
        Controls.Add(Label31)
        Controls.Add(Label30)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label27)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(LinkLabel1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(progressBar1)
        Controls.Add(txtyoururlDataAI)
        Controls.Add(txtyourwebsitetitle)
        Controls.Add(txtyourfoldertouploadfiles)
        Controls.Add(txtyourgooglemapkey)
        Controls.Add(txtyourOpenAIkey)
        Controls.Add(txtyourOpenAImodel)
        Controls.Add(txtyourOpenAIURL)
        Controls.Add(txtyourmaximumtokens)
        Controls.Add(txtyourOpenAIorganizationcode)
        Name = "Form1"
        Text = "DataAI Installation"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtyoururlDataAI As TextBox
    Friend WithEvents txtyourwebsitetitle As TextBox
    Friend WithEvents txtyourfoldertouploadfiles As TextBox
    Friend WithEvents txtyourgooglemapkey As TextBox
    Friend WithEvents txtyourOpenAIkey As TextBox
    Friend WithEvents txtyourOpenAImodel As TextBox
    Friend WithEvents txtyourmaximumtokens As TextBox
    Friend WithEvents txtyourOpenAIorganizationcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents progressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents btnUpdateWebConfig As Button
    Friend WithEvents Label49 As Label
    Friend WithEvents btnRestoreDefault As Button
    Friend WithEvents btnShowSetting As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents btnDownload As Button
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtyourOpenAIURL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
