using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauDess
{
    internal class Offsets
    {
        public Offsets() { }

        static Offsets() { }

        private const string GEngine = "Mordhau-Win64-Shipping.exe+0x593FDA8";
        private const string UWorld = GEngine + ",780,78,0";

        // main
        public static string PlayerController = GEngine + ",DF8,38,0,30";
        public static string PlayerCameraManager = PlayerController + ",2B8";
        public static string Pawn = PlayerController + ",2A0";
        public static string CharacterMovement = Pawn + ",288";

        // visual
        public static string DefaultFOV = PlayerCameraManager + ",238";
        public static string RealFOV = PlayerCameraManager + ",23C";

        // motions
        public static string LastAttackMotion = Pawn + ",688,108";
        public static string LastParryMotion = Pawn + ",688,F0";
        public static string LastFeintMotion = Pawn + ",688,100";

        // attack
        public static string ParryRecoveryTime = LastParryMotion + ",500";
        public static string RiposteWindowBase = LastParryMotion + ",4B4";
        public static string EndTime = LastAttackMotion + ",50";

        // weapon
        public static string RightHandEquipment = Pawn + ",11F8";
        public static string LeftHandEquipment = Pawn + ",1200";

        // weapon modifications
        public static string StrikeWindup1 = RightHandEquipment + ",13F0";
        public static string StrikeWindup2 = RightHandEquipment + ",1518";
        public static string turncapx = Pawn + ",8C4";
        public static string turncapy = Pawn + ",8CC";

        // ranged modifications
        public static string RangedDrawTime = LeftHandEquipment + ",CEC";
        public static string RangedReleaseTime = LeftHandEquipment + ",CEC";
        public static string RangedReloadTime = LeftHandEquipment + ",CEC";

        // movement
        public static string WantSupersprint = CharacterMovement + ",D1C";
        public static string MinTimeChasing = CharacterMovement + ",CB4";
        public static string NoSlowdownWhenChased = CharacterMovement + ",C49";
        public static string CanDodge = Pawn + ",E66";
        public static string DodgeDuration = Pawn + ",EA4";
        public static string DodgeCooldown = Pawn + ",EA8";

        // misc
        public static string RealMMR = "Mordhau-Win64-Shipping.exe+580D8F8,A70,0,170,B50,58,10,1E0";
        public static string VisualMMR = "Mordhau-Win64-Shipping.exe+580D8F8,A70,0,170,B50,58,10,138";
        public static string XP = "Mordhau-Win64-Shipping.exe+59437A0,510,28,8,150,230,D0,10";

        //playerstate
        public static string IsAlive = PlayerState + ",368";


    }
}
