using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace MordhauDess
{
    public partial class CheatMenu : MetroFramework.Forms.MetroForm
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        private readonly Mem mem = new Mem();
        private bool pOpen;
        private int pID;
        public CheatMenu()
        {
            
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void CheatMenu_Shown(object sender, EventArgs e)
        {
            pID = mem.GetProcIdFromName("Mordhau-Win64-Shipping");
            if (pID != 0)
            {
                pOpen = mem.OpenProcess(pID);
                pIDLabel.Text = pID.ToString();
            }
            else
            {
                MessageBox.Show("Please open Mordhau.");
                CheatMenu.ActiveForm.Close();
            }
            this.components.Remove(MeleeTimer.Container.Components[0]);
            MetroTabControl.SelectTab(0);
        }

        private void MeleeTimer_Tick(object sender, EventArgs e)
        {
            if (mem.ReadUInt(Offsets.Pawn) != 0)
            {

                if (FOVcheck.Checked)
                {
                    FOVtrackbar.Enabled = true;
                    metroLabel2.Text = FOVtrackbar.Value.ToString();
                    mem.WriteMemory(Offsets.RealFOV, "float", FOVtrackbar.Value.ToString());
                }
                else
                {
                    FOVtrackbar.Enabled = false;
                    metroLabel2.Text = mem.ReadFloat(Offsets.DefaultFOV).ToString();
                }

                if (Parrycheck.Checked)
                {
                    metroLabel3.Text = ((float)ParryTrack.Value * 0.001f).ToString();
                    ParryTrack.Enabled = true;
                    mem.WriteMemory(Offsets.ParryRecoveryTime, "float", "0." + ParryTrack.Value.ToString());
                }
                else
                {
                    ParryTrack.Enabled = false;
                    mem.WriteMemory(Offsets.ParryRecoveryTime, "float", "0.6750000119");
                }

                if (Ripostecheck.Checked)
                {
                    metroLabel4.Text = ((float)Ripostetrack.Value * 0.001f).ToString();
                    Ripostetrack.Enabled = true;
                    mem.WriteMemory(Offsets.RiposteWindowBase, "float", "0." + Ripostetrack.Value.ToString());
                }
                else
                {
                    Ripostetrack.Enabled = false;
                    mem.WriteMemory(Offsets.RiposteWindowBase, "float", "0.1");
                }

                if (Feintcheck.Checked)
                {
                    mem.WriteMemory(Offsets.StrikeWindup1, "float", "0.8");
                    mem.WriteMemory(Offsets.StrikeWindup2, "float", "0.8");
                }
                else
                {
                    if (mem.ReadFloat(Offsets.StrikeWindup1, round: false) != 0.8)
                    {
                        float basewindup1 = mem.ReadFloat(Offsets.StrikeWindup1) * 100f;
                        float basewindup2 = mem.ReadFloat(Offsets.StrikeWindup2) * 100f;
                        mem.WriteMemory(Offsets.StrikeWindup1, "float", "0." + basewindup1.ToString());
                        mem.WriteMemory(Offsets.StrikeWindup2, "float", "0." + basewindup2.ToString());
                    }
                }

                if (turncapcheck.Checked)
                {
                    turncapxtrack.Enabled = true;
                    turncapytrack.Enabled = true;
                    metroLabel5.Text = turncapxtrack.Value.ToString();
                    metroLabel6.Text = turncapytrack.Value.ToString();


                    if (mem.ReadFloat(Offsets.turncapx) != -1)
                    {
                        mem.WriteMemory(Offsets.turncapy, "float", turncapytrack.Value.ToString());
                        mem.WriteMemory(Offsets.turncapx, "float", turncapxtrack.Value.ToString());
                    }
                }

                else
                {
                    turncapxtrack.Enabled = false;
                    turncapytrack.Enabled = false;
                }


                if (rangedrcheck.Checked)
                {
                    mem.WriteMemory(Offsets.RangedReleaseTime, "float", "0");
                }
                if (rangeddcheck.Checked)
                {
                    mem.WriteMemory(Offsets.RangedDrawTime, "float", "0");
                }
                if (rangedreloadcheck.Checked)
                {
                    mem.WriteMemory(Offsets.RangedReloadTime, "float", "0");
                }



                if (supersprintbox.Checked) mem.WriteMemory(Offsets.WantSupersprint, "byte", "1");
                else mem.WriteMemory(Offsets.WantSupersprint, "byte", "0");

                if (chasebox.Checked) mem.WriteMemory(Offsets.MinTimeChasing, "float", "0");
                else mem.WriteMemory(Offsets.MinTimeChasing, "float", "0.25");

                if (dodgebox.Checked)
                {
                    mem.WriteMemory(Offsets.CanDodge, "byte", "1");
                    dodgecdbox.Enabled = true;
                    dodgedurationbox.Enabled = true;
                }
                else
                {
                    mem.WriteMemory(Offsets.CanDodge, "byte", "0");
                    dodgecdbox.Checked = false;
                    dodgecdbox.Enabled = false;
                    dodgedurationbox.Checked = false;
                    dodgedurationbox.Enabled = false;
                }

                if (dodgecdbox.Checked) mem.WriteMemory(Offsets.DodgeCooldown, "float", "0");
                else mem.WriteMemory(Offsets.DodgeCooldown, "float", "0.15");

                if (dodgedurationbox.Checked)
                {
                    dodgedurationtrack.Enabled = true;
                    metroLabel9.Text = ((float)dodgedurationtrack.Value / 1000f).ToString();
                    if (dodgedurationtrack.Value < 1000)
                    {
                        mem.WriteMemory(Offsets.DodgeDuration, "float", "0." + dodgedurationtrack.Value.ToString());
                    }
                    else mem.WriteMemory(Offsets.DodgeDuration, "float", (dodgedurationtrack.Value / 1000).ToString());
                }
                else
                {
                    dodgedurationtrack.Enabled = false;
                    mem.WriteMemory(Offsets.DodgeDuration, "float", "0.15");
                }

                if (slowbox.Checked) mem.WriteMemory(Offsets.NoSlowdownWhenChased, "byte", "0");
                else mem.WriteMemory(Offsets.NoSlowdownWhenChased, "byte", "1");

                if (breakanimbox.Checked)
                {
                    if (GetAsyncKeyState(Keys.CapsLock) < 0) mem.WriteMemory(Offsets.EndTime, "float", "0");
                }
            }

        }

        private void MetroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MetroTabControl.SelectedTab == MeleePage)
            {
                metroStyleManager1.Style = MetroColorStyle.Blue;
                components.SetStyle(this, MetroColorStyle.Blue);
            }
            if (MetroTabControl.SelectedTab == RangedPage) 
            {
                metroStyleManager1.Style = MetroColorStyle.Green;
                components.SetStyle(this, MetroColorStyle.Green);
            }
            if (MetroTabControl.SelectedTab == MovementPage)
            {
                metroStyleManager1.Style = MetroColorStyle.Red;
                components.SetStyle(this, MetroColorStyle.Red);
            }
            if (MetroTabControl.SelectedTab == MiscPage)
            {
                metroStyleManager1.Style = MetroColorStyle.Purple;
                components.SetStyle(this, MetroColorStyle.Purple);
            }
        }

        private void removemmrcheckbutton_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<long>> task = mem.AoBScan("89 43 08 42 8B 44 2B 0C 89 43 0C 42 0F B6 44 2B 10 88 43 10");
            task.Wait();
            foreach (long number in task.Result)
            {
                byte[] nop = new byte[] { 144, 144, 144 };
                Imps.MemoryProtection memoryProtection = Imps.MemoryProtection.ExecuteReadWrite;
                if (mem.ChangeProtection(number.ToString("X"), Imps.MemoryProtection.ExecuteReadWrite, out memoryProtection))
                {
                    mem.WriteBytes(number.ToString("X"), nop);
                    mem.ChangeProtection(number.ToString("X"), memoryProtection, out memoryProtection);
                }

            }
            mmrstatuslabel.Text = "Removed";
            mmrstatuslabel.ForeColor = Color.Green;
        }

        private void visualMMRbutton_Click(object sender, EventArgs e)
        {
            if (visualMMRtextbox.Text != "") mem.WriteMemory(Offsets.VisualMMR, "int", visualMMRtextbox.Text);
        }

        private void realMMRbutton_Click(object sender, EventArgs e)
        {
            if (realMMRtextbox.Text != "") mem.WriteMemory(Offsets.RealMMR, "int", realMMRtextbox.Text);
        }

        private void removexpcheckbutton_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<long>> task = mem.AoBScan("89 71 10 49 8D 54 24 08 49 8B 0C 24 E8 34 5D 04 00 49 8B 04 24");
            task.Wait();
            foreach (long number in task.Result)
            {
                byte[] nop = new byte[] { 144, 144, 144 };
                Imps.MemoryProtection memoryProtection = Imps.MemoryProtection.ExecuteReadWrite;
                if (mem.ChangeProtection(number.ToString("X"), Imps.MemoryProtection.ExecuteReadWrite, out memoryProtection))
                {
                    mem.WriteBytes(number.ToString("X"), nop);
                    mem.ChangeProtection(number.ToString("X"), memoryProtection, out memoryProtection);
                }

            }
            xpstatuslabel.Text = "Removed";
            xpstatuslabel.ForeColor = Color.Green;
        }

        private void xpbutton_Click(object sender, EventArgs e)
        {
            if (xptextbox.Text != "") mem.WriteMemory(Offsets.XP, "int", xptextbox.Text);
        }
    }
}
