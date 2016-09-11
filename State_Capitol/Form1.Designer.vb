<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.rdoAlabama = New System.Windows.Forms.RadioButton()
        Me.rdoAlaska = New System.Windows.Forms.RadioButton()
        Me.rdoArizona = New System.Windows.Forms.RadioButton()
        Me.rdoCalifornia = New System.Windows.Forms.RadioButton()
        Me.rdoColorado = New System.Windows.Forms.RadioButton()
        Me.rdoConnecticut = New System.Windows.Forms.RadioButton()
        Me.rdoDelaware = New System.Windows.Forms.RadioButton()
        Me.rdoFlorida = New System.Windows.Forms.RadioButton()
        Me.rdoGeorgia = New System.Windows.Forms.RadioButton()
        Me.rdoPhoenix = New System.Windows.Forms.RadioButton()
        Me.rdoDenver = New System.Windows.Forms.RadioButton()
        Me.rdoDover = New System.Windows.Forms.RadioButton()
        Me.rdoAtlanta = New System.Windows.Forms.RadioButton()
        Me.rdoMontgomery = New System.Windows.Forms.RadioButton()
        Me.rdoSacramento = New System.Windows.Forms.RadioButton()
        Me.rdoTallahassee = New System.Windows.Forms.RadioButton()
        Me.rdoLittleRock = New System.Windows.Forms.RadioButton()
        Me.rdoHartford = New System.Windows.Forms.RadioButton()
        Me.rdoJuneau = New System.Windows.Forms.RadioButton()
        Me.rdoArkansas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoArkansas)
        Me.GroupBox1.Controls.Add(Me.rdoGeorgia)
        Me.GroupBox1.Controls.Add(Me.rdoFlorida)
        Me.GroupBox1.Controls.Add(Me.rdoDelaware)
        Me.GroupBox1.Controls.Add(Me.rdoConnecticut)
        Me.GroupBox1.Controls.Add(Me.rdoColorado)
        Me.GroupBox1.Controls.Add(Me.rdoCalifornia)
        Me.GroupBox1.Controls.Add(Me.rdoArizona)
        Me.GroupBox1.Controls.Add(Me.rdoAlaska)
        Me.GroupBox1.Controls.Add(Me.rdoAlabama)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 337)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoJuneau)
        Me.GroupBox2.Controls.Add(Me.rdoHartford)
        Me.GroupBox2.Controls.Add(Me.rdoLittleRock)
        Me.GroupBox2.Controls.Add(Me.rdoTallahassee)
        Me.GroupBox2.Controls.Add(Me.rdoSacramento)
        Me.GroupBox2.Controls.Add(Me.rdoMontgomery)
        Me.GroupBox2.Controls.Add(Me.rdoAtlanta)
        Me.GroupBox2.Controls.Add(Me.rdoDover)
        Me.GroupBox2.Controls.Add(Me.rdoDenver)
        Me.GroupBox2.Controls.Add(Me.rdoPhoenix)
        Me.GroupBox2.Location = New System.Drawing.Point(209, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 337)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Capitol:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(63, 374)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = " "
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(209, 343)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(91, 76)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&am I right?"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(318, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 76)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rdoAlabama
        '
        Me.rdoAlabama.AutoSize = True
        Me.rdoAlabama.Location = New System.Drawing.Point(52, 47)
        Me.rdoAlabama.Name = "rdoAlabama"
        Me.rdoAlabama.Size = New System.Drawing.Size(66, 17)
        Me.rdoAlabama.TabIndex = 5
        Me.rdoAlabama.TabStop = True
        Me.rdoAlabama.Text = "Ala&bama"
        Me.rdoAlabama.UseVisualStyleBackColor = True
        '
        'rdoAlaska
        '
        Me.rdoAlaska.AutoSize = True
        Me.rdoAlaska.Location = New System.Drawing.Point(52, 72)
        Me.rdoAlaska.Name = "rdoAlaska"
        Me.rdoAlaska.Size = New System.Drawing.Size(57, 17)
        Me.rdoAlaska.TabIndex = 6
        Me.rdoAlaska.TabStop = True
        Me.rdoAlaska.Text = "Alas&ka"
        Me.rdoAlaska.UseVisualStyleBackColor = True
        '
        'rdoArizona
        '
        Me.rdoArizona.AutoSize = True
        Me.rdoArizona.Location = New System.Drawing.Point(52, 97)
        Me.rdoArizona.Name = "rdoArizona"
        Me.rdoArizona.Size = New System.Drawing.Size(60, 17)
        Me.rdoArizona.TabIndex = 7
        Me.rdoArizona.TabStop = True
        Me.rdoArizona.Text = "Ari&zona"
        Me.rdoArizona.UseVisualStyleBackColor = True
        '
        'rdoCalifornia
        '
        Me.rdoCalifornia.AutoSize = True
        Me.rdoCalifornia.Location = New System.Drawing.Point(52, 147)
        Me.rdoCalifornia.Name = "rdoCalifornia"
        Me.rdoCalifornia.Size = New System.Drawing.Size(68, 17)
        Me.rdoCalifornia.TabIndex = 8
        Me.rdoCalifornia.TabStop = True
        Me.rdoCalifornia.Text = "&California"
        Me.rdoCalifornia.UseVisualStyleBackColor = True
        '
        'rdoColorado
        '
        Me.rdoColorado.AutoSize = True
        Me.rdoColorado.Location = New System.Drawing.Point(52, 172)
        Me.rdoColorado.Name = "rdoColorado"
        Me.rdoColorado.Size = New System.Drawing.Size(67, 17)
        Me.rdoColorado.TabIndex = 9
        Me.rdoColorado.TabStop = True
        Me.rdoColorado.Text = "Co&lorado"
        Me.rdoColorado.UseVisualStyleBackColor = True
        '
        'rdoConnecticut
        '
        Me.rdoConnecticut.AutoSize = True
        Me.rdoConnecticut.Location = New System.Drawing.Point(52, 197)
        Me.rdoConnecticut.Name = "rdoConnecticut"
        Me.rdoConnecticut.Size = New System.Drawing.Size(82, 17)
        Me.rdoConnecticut.TabIndex = 10
        Me.rdoConnecticut.TabStop = True
        Me.rdoConnecticut.Text = "Co&nnecticut"
        Me.rdoConnecticut.UseVisualStyleBackColor = True
        '
        'rdoDelaware
        '
        Me.rdoDelaware.AutoSize = True
        Me.rdoDelaware.Location = New System.Drawing.Point(52, 222)
        Me.rdoDelaware.Name = "rdoDelaware"
        Me.rdoDelaware.Size = New System.Drawing.Size(70, 17)
        Me.rdoDelaware.TabIndex = 11
        Me.rdoDelaware.TabStop = True
        Me.rdoDelaware.Text = "&Delaware"
        Me.rdoDelaware.UseVisualStyleBackColor = True
        '
        'rdoFlorida
        '
        Me.rdoFlorida.AutoSize = True
        Me.rdoFlorida.Location = New System.Drawing.Point(52, 247)
        Me.rdoFlorida.Name = "rdoFlorida"
        Me.rdoFlorida.Size = New System.Drawing.Size(56, 17)
        Me.rdoFlorida.TabIndex = 12
        Me.rdoFlorida.TabStop = True
        Me.rdoFlorida.Text = "&Florida"
        Me.rdoFlorida.UseVisualStyleBackColor = True
        '
        'rdoGeorgia
        '
        Me.rdoGeorgia.AutoSize = True
        Me.rdoGeorgia.Location = New System.Drawing.Point(52, 272)
        Me.rdoGeorgia.Name = "rdoGeorgia"
        Me.rdoGeorgia.Size = New System.Drawing.Size(62, 17)
        Me.rdoGeorgia.TabIndex = 13
        Me.rdoGeorgia.TabStop = True
        Me.rdoGeorgia.Text = "&Georgia"
        Me.rdoGeorgia.UseVisualStyleBackColor = True
        '
        'rdoPhoenix
        '
        Me.rdoPhoenix.AutoSize = True
        Me.rdoPhoenix.Location = New System.Drawing.Point(52, 47)
        Me.rdoPhoenix.Name = "rdoPhoenix"
        Me.rdoPhoenix.Size = New System.Drawing.Size(63, 17)
        Me.rdoPhoenix.TabIndex = 0
        Me.rdoPhoenix.TabStop = True
        Me.rdoPhoenix.Text = "&Phoenix"
        Me.rdoPhoenix.UseVisualStyleBackColor = True
        '
        'rdoDenver
        '
        Me.rdoDenver.AutoSize = True
        Me.rdoDenver.Location = New System.Drawing.Point(52, 72)
        Me.rdoDenver.Name = "rdoDenver"
        Me.rdoDenver.Size = New System.Drawing.Size(60, 17)
        Me.rdoDenver.TabIndex = 1
        Me.rdoDenver.TabStop = True
        Me.rdoDenver.Text = "Den&ver"
        Me.rdoDenver.UseVisualStyleBackColor = True
        '
        'rdoDover
        '
        Me.rdoDover.AutoSize = True
        Me.rdoDover.Location = New System.Drawing.Point(52, 97)
        Me.rdoDover.Name = "rdoDover"
        Me.rdoDover.Size = New System.Drawing.Size(54, 17)
        Me.rdoDover.TabIndex = 2
        Me.rdoDover.TabStop = True
        Me.rdoDover.Text = "D&over"
        Me.rdoDover.UseVisualStyleBackColor = True
        '
        'rdoAtlanta
        '
        Me.rdoAtlanta.AutoSize = True
        Me.rdoAtlanta.Location = New System.Drawing.Point(52, 122)
        Me.rdoAtlanta.Name = "rdoAtlanta"
        Me.rdoAtlanta.Size = New System.Drawing.Size(58, 17)
        Me.rdoAtlanta.TabIndex = 3
        Me.rdoAtlanta.TabStop = True
        Me.rdoAtlanta.Text = "At&lanta"
        Me.rdoAtlanta.UseVisualStyleBackColor = True
        '
        'rdoMontgomery
        '
        Me.rdoMontgomery.AutoSize = True
        Me.rdoMontgomery.Location = New System.Drawing.Point(52, 147)
        Me.rdoMontgomery.Name = "rdoMontgomery"
        Me.rdoMontgomery.Size = New System.Drawing.Size(83, 17)
        Me.rdoMontgomery.TabIndex = 4
        Me.rdoMontgomery.TabStop = True
        Me.rdoMontgomery.Text = "&Montgomery"
        Me.rdoMontgomery.UseVisualStyleBackColor = True
        '
        'rdoSacramento
        '
        Me.rdoSacramento.AutoSize = True
        Me.rdoSacramento.Location = New System.Drawing.Point(52, 172)
        Me.rdoSacramento.Name = "rdoSacramento"
        Me.rdoSacramento.Size = New System.Drawing.Size(82, 17)
        Me.rdoSacramento.TabIndex = 5
        Me.rdoSacramento.TabStop = True
        Me.rdoSacramento.Text = "&Sacramento"
        Me.rdoSacramento.UseVisualStyleBackColor = True
        '
        'rdoTallahassee
        '
        Me.rdoTallahassee.AutoSize = True
        Me.rdoTallahassee.Location = New System.Drawing.Point(52, 197)
        Me.rdoTallahassee.Name = "rdoTallahassee"
        Me.rdoTallahassee.Size = New System.Drawing.Size(82, 17)
        Me.rdoTallahassee.TabIndex = 6
        Me.rdoTallahassee.TabStop = True
        Me.rdoTallahassee.Text = "Tallahass&ee"
        Me.rdoTallahassee.UseVisualStyleBackColor = True
        '
        'rdoLittleRock
        '
        Me.rdoLittleRock.AutoSize = True
        Me.rdoLittleRock.Location = New System.Drawing.Point(52, 222)
        Me.rdoLittleRock.Name = "rdoLittleRock"
        Me.rdoLittleRock.Size = New System.Drawing.Size(76, 17)
        Me.rdoLittleRock.TabIndex = 7
        Me.rdoLittleRock.TabStop = True
        Me.rdoLittleRock.Text = "L&ittle Rock"
        Me.rdoLittleRock.UseVisualStyleBackColor = True
        '
        'rdoHartford
        '
        Me.rdoHartford.AutoSize = True
        Me.rdoHartford.Location = New System.Drawing.Point(52, 247)
        Me.rdoHartford.Name = "rdoHartford"
        Me.rdoHartford.Size = New System.Drawing.Size(63, 17)
        Me.rdoHartford.TabIndex = 8
        Me.rdoHartford.TabStop = True
        Me.rdoHartford.Text = "&Hartford"
        Me.rdoHartford.UseVisualStyleBackColor = True
        '
        'rdoJuneau
        '
        Me.rdoJuneau.AutoSize = True
        Me.rdoJuneau.Location = New System.Drawing.Point(52, 272)
        Me.rdoJuneau.Name = "rdoJuneau"
        Me.rdoJuneau.Size = New System.Drawing.Size(60, 17)
        Me.rdoJuneau.TabIndex = 9
        Me.rdoJuneau.TabStop = True
        Me.rdoJuneau.Text = "&Juneau"
        Me.rdoJuneau.UseVisualStyleBackColor = True
        '
        'rdoArkansas
        '
        Me.rdoArkansas.AutoSize = True
        Me.rdoArkansas.Location = New System.Drawing.Point(52, 122)
        Me.rdoArkansas.Name = "rdoArkansas"
        Me.rdoArkansas.Size = New System.Drawing.Size(69, 17)
        Me.rdoArkansas.TabIndex = 15
        Me.rdoArkansas.TabStop = True
        Me.rdoArkansas.Text = "A&rkansas"
        Me.rdoArkansas.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 426)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "State Capitols"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rdoGeorgia As RadioButton
    Friend WithEvents rdoFlorida As RadioButton
    Friend WithEvents rdoDelaware As RadioButton
    Friend WithEvents rdoConnecticut As RadioButton
    Friend WithEvents rdoColorado As RadioButton
    Friend WithEvents rdoCalifornia As RadioButton
    Friend WithEvents rdoArizona As RadioButton
    Friend WithEvents rdoAlaska As RadioButton
    Friend WithEvents rdoAlabama As RadioButton
    Friend WithEvents rdoJuneau As RadioButton
    Friend WithEvents rdoHartford As RadioButton
    Friend WithEvents rdoLittleRock As RadioButton
    Friend WithEvents rdoTallahassee As RadioButton
    Friend WithEvents rdoSacramento As RadioButton
    Friend WithEvents rdoMontgomery As RadioButton
    Friend WithEvents rdoAtlanta As RadioButton
    Friend WithEvents rdoDover As RadioButton
    Friend WithEvents rdoDenver As RadioButton
    Friend WithEvents rdoPhoenix As RadioButton
    Friend WithEvents rdoArkansas As RadioButton
End Class
