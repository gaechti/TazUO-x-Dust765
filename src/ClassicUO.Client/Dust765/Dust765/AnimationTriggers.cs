using System;
using ClassicUO.Game.Managers;
using ClassicUO.Assets;
using System.Text.RegularExpressions; //REGEX

namespace ClassicUO.Dust765.Dust765
{
    internal class AnimationTriggers
    {
        public void OnOwnCharacterAnimation(ushort action)
        {
            if (action >= 9 && action <= 15 || action == 18 || action == 19 || action >= 26 && action <= 29 || action == 31)
            {
                //26 horse_attack1h_slashright_01 / 27 horse_attackbow_01 / 28 horse_attackcrossbow_01 / 29 horse_attack2h_slashright_01 / 31_punch_punc_jab 01
                //9 attacklslash1h_01 / 10 attackpierce1h_01 / 11 attackbash1h_01 / 12 attackbash2h_01 / 13 attackslash2h_01 / 14 attackpierce2h_01 / 15 combatadvanced_1h_01 / 18 attackbow_01 / 19 attackcrossbow_01

                // ## BEGIN - END ## // MACROS
                CombatCollection._HarmOnSwingTrigger = true;
                // ## BEGIN - END ## // MACROS
                // ## BEGIN - END ## // BUFFBAR/UCCSETTINGS
                UOClassicCombatBuffbar UOClassicCombatBuffbar = UIManager.GetGump<UOClassicCombatBuffbar>();
                UOClassicCombatBuffbar?.ClilocTriggerSwing();
                // ## BEGIN - END ## // BUFFBAR/UCCSETTINGS
            }
            return;
        }
        public void OnOwnCharacterAnimationNew(ushort action, ushort type)
        {
            // ## BEGIN - END ## // MACROS
            CombatCollection._HarmOnSwingTrigger = true;
            // ## BEGIN - END ## // MACROS
            // ## BEGIN - END ## // BUFFBAR/UCCSETTINGS
            UOClassicCombatBuffbar UOClassicCombatBuffbar = UIManager.GetGump<UOClassicCombatBuffbar>();
            UOClassicCombatBuffbar?.ClilocTriggerSwing();
            // ## BEGIN - END ## // BUFFBAR/UCCSETTINGS

            return;
        }
    }
}
