namespace MordhauDess
{
    partial class CheatMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MetroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.MeleePage = new MetroFramework.Controls.MetroTabPage();
            this.breakanimbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.turncapytrack = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.turncapxtrack = new MetroFramework.Controls.MetroTrackBar();
            this.turncapcheck = new MetroFramework.Controls.MetroCheckBox();
            this.Feintcheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Ripostetrack = new MetroFramework.Controls.MetroTrackBar();
            this.Ripostecheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ParryTrack = new MetroFramework.Controls.MetroTrackBar();
            this.Parrycheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.FOVtrackbar = new MetroFramework.Controls.MetroTrackBar();
            this.FOVcheck = new MetroFramework.Controls.MetroCheckBox();
            this.RangedPage = new MetroFramework.Controls.MetroTabPage();
            this.rangedreloadcheck = new MetroFramework.Controls.MetroCheckBox();
            this.rangeddcheck = new MetroFramework.Controls.MetroCheckBox();
            this.rangedrcheck = new MetroFramework.Controls.MetroCheckBox();
            this.MovementPage = new MetroFramework.Controls.MetroTabPage();
            this.slowbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dodgedurationtrack = new MetroFramework.Controls.MetroTrackBar();
            this.dodgedurationbox = new MetroFramework.Controls.MetroCheckBox();
            this.dodgecdbox = new MetroFramework.Controls.MetroCheckBox();
            this.dodgebox = new MetroFramework.Controls.MetroCheckBox();
            this.chasebox = new MetroFramework.Controls.MetroCheckBox();
            this.supersprintbox = new MetroFramework.Controls.MetroCheckBox();
            this.MiscPage = new MetroFramework.Controls.MetroTabPage();
            this.mmrstatuslabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.removemmrcheckbutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pIDLabel = new MetroFramework.Controls.MetroLabel();
            this.MeleeTimer = new System.Windows.Forms.Timer(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.visualMMRtextbox = new MetroFramework.Controls.MetroTextBox();
            this.visualMMRbutton = new MetroFramework.Controls.MetroButton();
            this.realMMRtextbox = new MetroFramework.Controls.MetroTextBox();
            this.realMMRbutton = new MetroFramework.Controls.MetroButton();
            this.removexpcheckbutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.xpstatuslabel = new MetroFramework.Controls.MetroLabel();
            this.xptextbox = new MetroFramework.Controls.MetroTextBox();
            this.xpbutton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.MetroTabControl.SuspendLayout();
            this.MeleePage.SuspendLayout();
            this.RangedPage.SuspendLayout();
            this.MovementPage.SuspendLayout();
            this.MiscPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MetroTabControl);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 400);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // MetroTabControl
            // 
            this.MetroTabControl.Controls.Add(this.MeleePage);
            this.MetroTabControl.Controls.Add(this.RangedPage);
            this.MetroTabControl.Controls.Add(this.MovementPage);
            this.MetroTabControl.Controls.Add(this.MiscPage);
            this.MetroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetroTabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.MetroTabControl.ItemSize = new System.Drawing.Size(30, 30);
            this.MetroTabControl.Location = new System.Drawing.Point(0, 0);
            this.MetroTabControl.Name = "MetroTabControl";
            this.MetroTabControl.SelectedIndex = 3;
            this.MetroTabControl.Size = new System.Drawing.Size(760, 400);
            this.MetroTabControl.TabIndex = 2;
            this.MetroTabControl.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MetroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroTabControl.UseSelectable = true;
            this.MetroTabControl.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl_SelectedIndexChanged);
            // 
            // MeleePage
            // 
            this.MeleePage.Controls.Add(this.breakanimbox);
            this.MeleePage.Controls.Add(this.metroLabel8);
            this.MeleePage.Controls.Add(this.metroLabel7);
            this.MeleePage.Controls.Add(this.metroLabel6);
            this.MeleePage.Controls.Add(this.turncapytrack);
            this.MeleePage.Controls.Add(this.metroLabel5);
            this.MeleePage.Controls.Add(this.turncapxtrack);
            this.MeleePage.Controls.Add(this.turncapcheck);
            this.MeleePage.Controls.Add(this.Feintcheck);
            this.MeleePage.Controls.Add(this.metroLabel4);
            this.MeleePage.Controls.Add(this.Ripostetrack);
            this.MeleePage.Controls.Add(this.Ripostecheck);
            this.MeleePage.Controls.Add(this.metroLabel3);
            this.MeleePage.Controls.Add(this.ParryTrack);
            this.MeleePage.Controls.Add(this.Parrycheck);
            this.MeleePage.Controls.Add(this.metroLabel2);
            this.MeleePage.Controls.Add(this.FOVtrackbar);
            this.MeleePage.Controls.Add(this.FOVcheck);
            this.MeleePage.HorizontalScrollbarBarColor = true;
            this.MeleePage.HorizontalScrollbarHighlightOnWheel = false;
            this.MeleePage.HorizontalScrollbarSize = 10;
            this.MeleePage.Location = new System.Drawing.Point(4, 34);
            this.MeleePage.Name = "MeleePage";
            this.MeleePage.Size = new System.Drawing.Size(752, 362);
            this.MeleePage.TabIndex = 0;
            this.MeleePage.Text = "Melee";
            this.MeleePage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MeleePage.VerticalScrollbarBarColor = true;
            this.MeleePage.VerticalScrollbarHighlightOnWheel = false;
            this.MeleePage.VerticalScrollbarSize = 10;
            // 
            // breakanimbox
            // 
            this.breakanimbox.AutoSize = true;
            this.breakanimbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.breakanimbox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.breakanimbox.Location = new System.Drawing.Point(467, 17);
            this.breakanimbox.Name = "breakanimbox";
            this.breakanimbox.Size = new System.Drawing.Size(224, 19);
            this.breakanimbox.TabIndex = 19;
            this.breakanimbox.Text = "Break anims (Binded to CapsLock)";
            this.breakanimbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.breakanimbox.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(15, 316);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(17, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 18;
            this.metroLabel8.Text = "X";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 343);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(17, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Y";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(313, 347);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(30, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "200";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // turncapytrack
            // 
            this.turncapytrack.BackColor = System.Drawing.Color.Transparent;
            this.turncapytrack.Enabled = false;
            this.turncapytrack.LargeChange = 100;
            this.turncapytrack.Location = new System.Drawing.Point(38, 345);
            this.turncapytrack.Maximum = 1000;
            this.turncapytrack.Minimum = 200;
            this.turncapytrack.Name = "turncapytrack";
            this.turncapytrack.Size = new System.Drawing.Size(269, 23);
            this.turncapytrack.SmallChange = 50;
            this.turncapytrack.TabIndex = 15;
            this.turncapytrack.Text = "metroTrackBar2";
            this.turncapytrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.turncapytrack.Value = 200;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(313, 316);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "200";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // turncapxtrack
            // 
            this.turncapxtrack.BackColor = System.Drawing.Color.Transparent;
            this.turncapxtrack.Enabled = false;
            this.turncapxtrack.LargeChange = 100;
            this.turncapxtrack.Location = new System.Drawing.Point(38, 316);
            this.turncapxtrack.Maximum = 1000;
            this.turncapxtrack.Minimum = 200;
            this.turncapxtrack.Name = "turncapxtrack";
            this.turncapxtrack.Size = new System.Drawing.Size(269, 23);
            this.turncapxtrack.SmallChange = 50;
            this.turncapxtrack.TabIndex = 13;
            this.turncapxtrack.Text = "metroTrackBar1";
            this.turncapxtrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.turncapxtrack.Value = 200;
            // 
            // turncapcheck
            // 
            this.turncapcheck.AutoSize = true;
            this.turncapcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.turncapcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.turncapcheck.Location = new System.Drawing.Point(0, 281);
            this.turncapcheck.Name = "turncapcheck";
            this.turncapcheck.Size = new System.Drawing.Size(124, 19);
            this.turncapcheck.TabIndex = 12;
            this.turncapcheck.TabStop = false;
            this.turncapcheck.Text = "Turncap Changer";
            this.turncapcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.turncapcheck.UseSelectable = true;
            // 
            // Feintcheck
            // 
            this.Feintcheck.AutoSize = true;
            this.Feintcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Feintcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.Feintcheck.Location = new System.Drawing.Point(0, 233);
            this.Feintcheck.Name = "Feintcheck";
            this.Feintcheck.Size = new System.Drawing.Size(154, 19);
            this.Feintcheck.TabIndex = 11;
            this.Feintcheck.TabStop = false;
            this.Feintcheck.Text = "Increase feint duration";
            this.Feintcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Feintcheck.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(245, 181);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "0.1";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Ripostetrack
            // 
            this.Ripostetrack.BackColor = System.Drawing.Color.Transparent;
            this.Ripostetrack.Enabled = false;
            this.Ripostetrack.LargeChange = 100;
            this.Ripostetrack.Location = new System.Drawing.Point(0, 192);
            this.Ripostetrack.Maximum = 1000;
            this.Ripostetrack.Minimum = 100;
            this.Ripostetrack.Name = "Ripostetrack";
            this.Ripostetrack.Size = new System.Drawing.Size(269, 23);
            this.Ripostetrack.SmallChange = 50;
            this.Ripostetrack.TabIndex = 9;
            this.Ripostetrack.Text = "metroTrackBar1";
            this.Ripostetrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Ripostetrack.Value = 100;
            // 
            // Ripostecheck
            // 
            this.Ripostecheck.AutoSize = true;
            this.Ripostecheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Ripostecheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.Ripostecheck.Location = new System.Drawing.Point(0, 167);
            this.Ripostecheck.Name = "Ripostecheck";
            this.Ripostecheck.Size = new System.Drawing.Size(93, 19);
            this.Ripostecheck.TabIndex = 8;
            this.Ripostecheck.TabStop = false;
            this.Ripostecheck.Text = "Late riposte";
            this.Ripostecheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Ripostecheck.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(242, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "0.675";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ParryTrack
            // 
            this.ParryTrack.BackColor = System.Drawing.Color.Transparent;
            this.ParryTrack.Enabled = false;
            this.ParryTrack.LargeChange = 30;
            this.ParryTrack.Location = new System.Drawing.Point(-4, 120);
            this.ParryTrack.Maximum = 675;
            this.ParryTrack.Name = "ParryTrack";
            this.ParryTrack.Size = new System.Drawing.Size(269, 23);
            this.ParryTrack.SmallChange = 15;
            this.ParryTrack.TabIndex = 6;
            this.ParryTrack.Text = "metroTrackBar1";
            this.ParryTrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ParryTrack.Value = 675;
            // 
            // Parrycheck
            // 
            this.Parrycheck.AutoSize = true;
            this.Parrycheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.Parrycheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.Parrycheck.Location = new System.Drawing.Point(0, 87);
            this.Parrycheck.Name = "Parrycheck";
            this.Parrycheck.Size = new System.Drawing.Size(281, 19);
            this.Parrycheck.TabIndex = 5;
            this.Parrycheck.TabStop = false;
            this.Parrycheck.Text = "Change parry cooldown (maximum is base)";
            this.Parrycheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Parrycheck.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(242, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(23, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "90";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FOVtrackbar
            // 
            this.FOVtrackbar.BackColor = System.Drawing.Color.Transparent;
            this.FOVtrackbar.Enabled = false;
            this.FOVtrackbar.Location = new System.Drawing.Point(-4, 42);
            this.FOVtrackbar.Maximum = 150;
            this.FOVtrackbar.Name = "FOVtrackbar";
            this.FOVtrackbar.Size = new System.Drawing.Size(269, 23);
            this.FOVtrackbar.TabIndex = 3;
            this.FOVtrackbar.Text = "metroTrackBar1";
            this.FOVtrackbar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FOVtrackbar.Value = 90;
            // 
            // FOVcheck
            // 
            this.FOVcheck.AutoSize = true;
            this.FOVcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.FOVcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.FOVcheck.Location = new System.Drawing.Point(0, 17);
            this.FOVcheck.Name = "FOVcheck";
            this.FOVcheck.Size = new System.Drawing.Size(105, 19);
            this.FOVcheck.TabIndex = 2;
            this.FOVcheck.Text = "FOV Changer";
            this.FOVcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FOVcheck.UseSelectable = true;
            // 
            // RangedPage
            // 
            this.RangedPage.Controls.Add(this.rangedreloadcheck);
            this.RangedPage.Controls.Add(this.rangeddcheck);
            this.RangedPage.Controls.Add(this.rangedrcheck);
            this.RangedPage.HorizontalScrollbarBarColor = true;
            this.RangedPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RangedPage.HorizontalScrollbarSize = 10;
            this.RangedPage.Location = new System.Drawing.Point(4, 34);
            this.RangedPage.Name = "RangedPage";
            this.RangedPage.Size = new System.Drawing.Size(752, 362);
            this.RangedPage.TabIndex = 1;
            this.RangedPage.Text = "Ranged";
            this.RangedPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RangedPage.VerticalScrollbarBarColor = true;
            this.RangedPage.VerticalScrollbarHighlightOnWheel = false;
            this.RangedPage.VerticalScrollbarSize = 10;
            // 
            // rangedreloadcheck
            // 
            this.rangedreloadcheck.AutoSize = true;
            this.rangedreloadcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rangedreloadcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rangedreloadcheck.Location = new System.Drawing.Point(0, 119);
            this.rangedreloadcheck.Name = "rangedreloadcheck";
            this.rangedreloadcheck.Size = new System.Drawing.Size(85, 19);
            this.rangedreloadcheck.TabIndex = 5;
            this.rangedreloadcheck.Text = "No reload";
            this.rangedreloadcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rangedreloadcheck.UseSelectable = true;
            // 
            // rangeddcheck
            // 
            this.rangeddcheck.AutoSize = true;
            this.rangeddcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rangeddcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rangeddcheck.Location = new System.Drawing.Point(0, 68);
            this.rangeddcheck.Name = "rangeddcheck";
            this.rangeddcheck.Size = new System.Drawing.Size(133, 19);
            this.rangeddcheck.TabIndex = 4;
            this.rangeddcheck.Text = "Set draw time to 0";
            this.rangeddcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rangeddcheck.UseSelectable = true;
            // 
            // rangedrcheck
            // 
            this.rangedrcheck.AutoSize = true;
            this.rangedrcheck.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rangedrcheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rangedrcheck.Location = new System.Drawing.Point(0, 15);
            this.rangedrcheck.Name = "rangedrcheck";
            this.rangedrcheck.Size = new System.Drawing.Size(145, 19);
            this.rangedrcheck.TabIndex = 3;
            this.rangedrcheck.Text = "Set release time to 0";
            this.rangedrcheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rangedrcheck.UseSelectable = true;
            // 
            // MovementPage
            // 
            this.MovementPage.Controls.Add(this.slowbox);
            this.MovementPage.Controls.Add(this.metroLabel9);
            this.MovementPage.Controls.Add(this.dodgedurationtrack);
            this.MovementPage.Controls.Add(this.dodgedurationbox);
            this.MovementPage.Controls.Add(this.dodgecdbox);
            this.MovementPage.Controls.Add(this.dodgebox);
            this.MovementPage.Controls.Add(this.chasebox);
            this.MovementPage.Controls.Add(this.supersprintbox);
            this.MovementPage.HorizontalScrollbarBarColor = true;
            this.MovementPage.HorizontalScrollbarHighlightOnWheel = false;
            this.MovementPage.HorizontalScrollbarSize = 10;
            this.MovementPage.Location = new System.Drawing.Point(4, 34);
            this.MovementPage.Name = "MovementPage";
            this.MovementPage.Size = new System.Drawing.Size(752, 362);
            this.MovementPage.TabIndex = 2;
            this.MovementPage.Text = "Movement";
            this.MovementPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MovementPage.VerticalScrollbarBarColor = true;
            this.MovementPage.VerticalScrollbarHighlightOnWheel = false;
            this.MovementPage.VerticalScrollbarSize = 10;
            // 
            // slowbox
            // 
            this.slowbox.AutoSize = true;
            this.slowbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.slowbox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.slowbox.Location = new System.Drawing.Point(0, 92);
            this.slowbox.Name = "slowbox";
            this.slowbox.Size = new System.Drawing.Size(182, 19);
            this.slowbox.TabIndex = 11;
            this.slowbox.Text = "No slowdown when chased";
            this.slowbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.slowbox.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(267, 189);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "0.375";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dodgedurationtrack
            // 
            this.dodgedurationtrack.BackColor = System.Drawing.Color.Transparent;
            this.dodgedurationtrack.Enabled = false;
            this.dodgedurationtrack.LargeChange = 500;
            this.dodgedurationtrack.Location = new System.Drawing.Point(38, 202);
            this.dodgedurationtrack.Maximum = 5000;
            this.dodgedurationtrack.Minimum = 375;
            this.dodgedurationtrack.Name = "dodgedurationtrack";
            this.dodgedurationtrack.Size = new System.Drawing.Size(269, 23);
            this.dodgedurationtrack.SmallChange = 200;
            this.dodgedurationtrack.TabIndex = 9;
            this.dodgedurationtrack.Text = "metroTrackBar1";
            this.dodgedurationtrack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dodgedurationtrack.Value = 375;
            // 
            // dodgedurationbox
            // 
            this.dodgedurationbox.AutoSize = true;
            this.dodgedurationbox.Enabled = false;
            this.dodgedurationbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dodgedurationbox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.dodgedurationbox.Location = new System.Drawing.Point(38, 177);
            this.dodgedurationbox.Name = "dodgedurationbox";
            this.dodgedurationbox.Size = new System.Drawing.Size(166, 19);
            this.dodgedurationbox.TabIndex = 8;
            this.dodgedurationbox.Text = "Change dodge duration";
            this.dodgedurationbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dodgedurationbox.UseSelectable = true;
            // 
            // dodgecdbox
            // 
            this.dodgecdbox.AutoSize = true;
            this.dodgecdbox.Enabled = false;
            this.dodgecdbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dodgecdbox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.dodgecdbox.Location = new System.Drawing.Point(38, 152);
            this.dodgecdbox.Name = "dodgecdbox";
            this.dodgecdbox.Size = new System.Drawing.Size(153, 19);
            this.dodgecdbox.TabIndex = 7;
            this.dodgecdbox.Text = "Dodge cooldown to 0";
            this.dodgecdbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dodgecdbox.UseSelectable = true;
            // 
            // dodgebox
            // 
            this.dodgebox.AutoSize = true;
            this.dodgebox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dodgebox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.dodgebox.Location = new System.Drawing.Point(0, 127);
            this.dodgebox.Name = "dodgebox";
            this.dodgebox.Size = new System.Drawing.Size(141, 19);
            this.dodgebox.TabIndex = 6;
            this.dodgebox.Text = "Dodge without perk";
            this.dodgebox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dodgebox.UseSelectable = true;
            // 
            // chasebox
            // 
            this.chasebox.AutoSize = true;
            this.chasebox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chasebox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chasebox.Location = new System.Drawing.Point(0, 53);
            this.chasebox.Name = "chasebox";
            this.chasebox.Size = new System.Drawing.Size(157, 19);
            this.chasebox.TabIndex = 5;
            this.chasebox.Text = "Instant chase mechanic";
            this.chasebox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chasebox.UseSelectable = true;
            // 
            // supersprintbox
            // 
            this.supersprintbox.AutoSize = true;
            this.supersprintbox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.supersprintbox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.supersprintbox.Location = new System.Drawing.Point(0, 16);
            this.supersprintbox.Name = "supersprintbox";
            this.supersprintbox.Size = new System.Drawing.Size(91, 19);
            this.supersprintbox.TabIndex = 4;
            this.supersprintbox.Text = "Supersprint";
            this.supersprintbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.supersprintbox.UseSelectable = true;
            // 
            // MiscPage
            // 
            this.MiscPage.Controls.Add(this.xpbutton);
            this.MiscPage.Controls.Add(this.xptextbox);
            this.MiscPage.Controls.Add(this.xpstatuslabel);
            this.MiscPage.Controls.Add(this.metroLabel11);
            this.MiscPage.Controls.Add(this.removexpcheckbutton);
            this.MiscPage.Controls.Add(this.realMMRbutton);
            this.MiscPage.Controls.Add(this.realMMRtextbox);
            this.MiscPage.Controls.Add(this.visualMMRbutton);
            this.MiscPage.Controls.Add(this.visualMMRtextbox);
            this.MiscPage.Controls.Add(this.mmrstatuslabel);
            this.MiscPage.Controls.Add(this.metroLabel10);
            this.MiscPage.Controls.Add(this.removemmrcheckbutton);
            this.MiscPage.HorizontalScrollbarBarColor = true;
            this.MiscPage.HorizontalScrollbarHighlightOnWheel = false;
            this.MiscPage.HorizontalScrollbarSize = 10;
            this.MiscPage.Location = new System.Drawing.Point(4, 34);
            this.MiscPage.Name = "MiscPage";
            this.MiscPage.Size = new System.Drawing.Size(752, 362);
            this.MiscPage.TabIndex = 3;
            this.MiscPage.Text = "Misc";
            this.MiscPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MiscPage.VerticalScrollbarBarColor = true;
            this.MiscPage.VerticalScrollbarHighlightOnWheel = false;
            this.MiscPage.VerticalScrollbarSize = 10;
            // 
            // mmrstatuslabel
            // 
            this.mmrstatuslabel.AutoSize = true;
            this.mmrstatuslabel.ForeColor = System.Drawing.Color.Firebrick;
            this.mmrstatuslabel.Location = new System.Drawing.Point(652, 27);
            this.mmrstatuslabel.Name = "mmrstatuslabel";
            this.mmrstatuslabel.Size = new System.Drawing.Size(88, 19);
            this.mmrstatuslabel.TabIndex = 12;
            this.mmrstatuslabel.Text = "Not removed";
            this.mmrstatuslabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mmrstatuslabel.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(612, 27);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(46, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Status:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // removemmrcheckbutton
            // 
            this.removemmrcheckbutton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.removemmrcheckbutton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.removemmrcheckbutton.Location = new System.Drawing.Point(391, 13);
            this.removemmrcheckbutton.Name = "removemmrcheckbutton";
            this.removemmrcheckbutton.Size = new System.Drawing.Size(215, 33);
            this.removemmrcheckbutton.TabIndex = 2;
            this.removemmrcheckbutton.Text = "Remove server MMR check";
            this.removemmrcheckbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.removemmrcheckbutton.UseSelectable = true;
            this.removemmrcheckbutton.Click += new System.EventHandler(this.removemmrcheckbutton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Process ID: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pIDLabel
            // 
            this.pIDLabel.AutoSize = true;
            this.pIDLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.pIDLabel.Location = new System.Drawing.Point(62, 8);
            this.pIDLabel.Name = "pIDLabel";
            this.pIDLabel.Size = new System.Drawing.Size(41, 15);
            this.pIDLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.pIDLabel.TabIndex = 2;
            this.pIDLabel.Text = "100000";
            this.pIDLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MeleeTimer
            // 
            this.MeleeTimer.Enabled = true;
            this.MeleeTimer.Tick += new System.EventHandler(this.MeleeTimer_Tick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // visualMMRtextbox
            // 
            // 
            // 
            // 
            this.visualMMRtextbox.CustomButton.Image = null;
            this.visualMMRtextbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.visualMMRtextbox.CustomButton.Name = "";
            this.visualMMRtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.visualMMRtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.visualMMRtextbox.CustomButton.TabIndex = 1;
            this.visualMMRtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.visualMMRtextbox.CustomButton.UseSelectable = true;
            this.visualMMRtextbox.CustomButton.Visible = false;
            this.visualMMRtextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.visualMMRtextbox.Lines = new string[] {
        "Write needed visual MMR"};
            this.visualMMRtextbox.Location = new System.Drawing.Point(3, 13);
            this.visualMMRtextbox.MaxLength = 32767;
            this.visualMMRtextbox.Name = "visualMMRtextbox";
            this.visualMMRtextbox.PasswordChar = '\0';
            this.visualMMRtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.visualMMRtextbox.SelectedText = "";
            this.visualMMRtextbox.SelectionLength = 0;
            this.visualMMRtextbox.SelectionStart = 0;
            this.visualMMRtextbox.ShortcutsEnabled = true;
            this.visualMMRtextbox.Size = new System.Drawing.Size(170, 23);
            this.visualMMRtextbox.TabIndex = 13;
            this.visualMMRtextbox.Text = "Write needed visual MMR";
            this.visualMMRtextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.visualMMRtextbox.UseSelectable = true;
            this.visualMMRtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.visualMMRtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // visualMMRbutton
            // 
            this.visualMMRbutton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.visualMMRbutton.Location = new System.Drawing.Point(203, 13);
            this.visualMMRbutton.Name = "visualMMRbutton";
            this.visualMMRbutton.Size = new System.Drawing.Size(114, 23);
            this.visualMMRbutton.TabIndex = 14;
            this.visualMMRbutton.Text = "Change visual MMR";
            this.visualMMRbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.visualMMRbutton.UseSelectable = true;
            this.visualMMRbutton.Click += new System.EventHandler(this.visualMMRbutton_Click);
            // 
            // realMMRtextbox
            // 
            // 
            // 
            // 
            this.realMMRtextbox.CustomButton.Image = null;
            this.realMMRtextbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.realMMRtextbox.CustomButton.Name = "";
            this.realMMRtextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.realMMRtextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.realMMRtextbox.CustomButton.TabIndex = 1;
            this.realMMRtextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.realMMRtextbox.CustomButton.UseSelectable = true;
            this.realMMRtextbox.CustomButton.Visible = false;
            this.realMMRtextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.realMMRtextbox.Lines = new string[] {
        "Write needed real MMR"};
            this.realMMRtextbox.Location = new System.Drawing.Point(3, 63);
            this.realMMRtextbox.MaxLength = 32767;
            this.realMMRtextbox.Name = "realMMRtextbox";
            this.realMMRtextbox.PasswordChar = '\0';
            this.realMMRtextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.realMMRtextbox.SelectedText = "";
            this.realMMRtextbox.SelectionLength = 0;
            this.realMMRtextbox.SelectionStart = 0;
            this.realMMRtextbox.ShortcutsEnabled = true;
            this.realMMRtextbox.Size = new System.Drawing.Size(170, 23);
            this.realMMRtextbox.TabIndex = 15;
            this.realMMRtextbox.Text = "Write needed real MMR";
            this.realMMRtextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.realMMRtextbox.UseSelectable = true;
            this.realMMRtextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.realMMRtextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // realMMRbutton
            // 
            this.realMMRbutton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.realMMRbutton.Location = new System.Drawing.Point(203, 63);
            this.realMMRbutton.Name = "realMMRbutton";
            this.realMMRbutton.Size = new System.Drawing.Size(114, 23);
            this.realMMRbutton.TabIndex = 16;
            this.realMMRbutton.Text = "Change real MMR";
            this.realMMRbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.realMMRbutton.UseSelectable = true;
            this.realMMRbutton.Click += new System.EventHandler(this.realMMRbutton_Click);
            // 
            // removexpcheckbutton
            // 
            this.removexpcheckbutton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.removexpcheckbutton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.removexpcheckbutton.Location = new System.Drawing.Point(391, 63);
            this.removexpcheckbutton.Name = "removexpcheckbutton";
            this.removexpcheckbutton.Size = new System.Drawing.Size(215, 33);
            this.removexpcheckbutton.TabIndex = 17;
            this.removexpcheckbutton.Text = "Remove server XP check";
            this.removexpcheckbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.removexpcheckbutton.UseSelectable = true;
            this.removexpcheckbutton.Click += new System.EventHandler(this.removexpcheckbutton_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(612, 77);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(46, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Status:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // xpstatuslabel
            // 
            this.xpstatuslabel.AutoSize = true;
            this.xpstatuslabel.ForeColor = System.Drawing.Color.Firebrick;
            this.xpstatuslabel.Location = new System.Drawing.Point(652, 77);
            this.xpstatuslabel.Name = "xpstatuslabel";
            this.xpstatuslabel.Size = new System.Drawing.Size(88, 19);
            this.xpstatuslabel.TabIndex = 19;
            this.xpstatuslabel.Text = "Not removed";
            this.xpstatuslabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xpstatuslabel.UseCustomForeColor = true;
            // 
            // xptextbox
            // 
            // 
            // 
            // 
            this.xptextbox.CustomButton.Image = null;
            this.xptextbox.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.xptextbox.CustomButton.Name = "";
            this.xptextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.xptextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.xptextbox.CustomButton.TabIndex = 1;
            this.xptextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.xptextbox.CustomButton.UseSelectable = true;
            this.xptextbox.CustomButton.Visible = false;
            this.xptextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.xptextbox.Lines = new string[] {
        "Write needed XP"};
            this.xptextbox.Location = new System.Drawing.Point(3, 111);
            this.xptextbox.MaxLength = 32767;
            this.xptextbox.Name = "xptextbox";
            this.xptextbox.PasswordChar = '\0';
            this.xptextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.xptextbox.SelectedText = "";
            this.xptextbox.SelectionLength = 0;
            this.xptextbox.SelectionStart = 0;
            this.xptextbox.ShortcutsEnabled = true;
            this.xptextbox.Size = new System.Drawing.Size(170, 23);
            this.xptextbox.TabIndex = 20;
            this.xptextbox.Text = "Write needed XP";
            this.xptextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xptextbox.UseSelectable = true;
            this.xptextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.xptextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // xpbutton
            // 
            this.xpbutton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.xpbutton.Location = new System.Drawing.Point(203, 111);
            this.xpbutton.Name = "xpbutton";
            this.xpbutton.Size = new System.Drawing.Size(114, 23);
            this.xpbutton.TabIndex = 21;
            this.xpbutton.Text = "Change XP";
            this.xpbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.xpbutton.UseSelectable = true;
            this.xpbutton.Click += new System.EventHandler(this.xpbutton_Click);
            // 
            // CheatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pIDLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Name = "CheatMenu";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "Mordhau";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.CheatMenu_Shown);
            this.metroPanel1.ResumeLayout(false);
            this.MetroTabControl.ResumeLayout(false);
            this.MeleePage.ResumeLayout(false);
            this.MeleePage.PerformLayout();
            this.RangedPage.ResumeLayout(false);
            this.RangedPage.PerformLayout();
            this.MovementPage.ResumeLayout(false);
            this.MovementPage.PerformLayout();
            this.MiscPage.ResumeLayout(false);
            this.MiscPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl MetroTabControl;
        private MetroFramework.Controls.MetroTabPage MeleePage;
        private MetroFramework.Controls.MetroCheckBox FOVcheck;
        private MetroFramework.Controls.MetroTrackBar FOVtrackbar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel pIDLabel;
        private System.Windows.Forms.Timer MeleeTimer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox Parrycheck;
        private MetroFramework.Controls.MetroTrackBar ParryTrack;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox Ripostecheck;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar Ripostetrack;
        private MetroFramework.Controls.MetroCheckBox Feintcheck;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTrackBar turncapytrack;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTrackBar turncapxtrack;
        private MetroFramework.Controls.MetroCheckBox turncapcheck;
        private MetroFramework.Controls.MetroTabPage RangedPage;
        private MetroFramework.Controls.MetroCheckBox rangedreloadcheck;
        private MetroFramework.Controls.MetroCheckBox rangeddcheck;
        private MetroFramework.Controls.MetroCheckBox rangedrcheck;
        private MetroFramework.Controls.MetroTabPage MovementPage;
        private MetroFramework.Controls.MetroCheckBox dodgecdbox;
        private MetroFramework.Controls.MetroCheckBox dodgebox;
        private MetroFramework.Controls.MetroCheckBox chasebox;
        private MetroFramework.Controls.MetroCheckBox supersprintbox;
        private MetroFramework.Controls.MetroTrackBar dodgedurationtrack;
        private MetroFramework.Controls.MetroCheckBox dodgedurationbox;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroCheckBox slowbox;
        private MetroFramework.Controls.MetroCheckBox breakanimbox;
        private MetroFramework.Controls.MetroTabPage MiscPage;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton removemmrcheckbutton;
        private MetroFramework.Controls.MetroLabel mmrstatuslabel;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox visualMMRtextbox;
        private MetroFramework.Controls.MetroButton visualMMRbutton;
        private MetroFramework.Controls.MetroButton realMMRbutton;
        private MetroFramework.Controls.MetroTextBox realMMRtextbox;
        private MetroFramework.Controls.MetroButton xpbutton;
        private MetroFramework.Controls.MetroTextBox xptextbox;
        private MetroFramework.Controls.MetroLabel xpstatuslabel;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton removexpcheckbutton;
    }
}

