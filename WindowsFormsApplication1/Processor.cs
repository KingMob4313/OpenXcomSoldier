using LinqToExcel;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace SoldierGen
{
    public class Processor
    {
        private SoldierGen _soldierGen;

        public Processor(SoldierGen soldierGen)
        {
            _soldierGen = soldierGen;
        }

        public SoldierBundle LoadXLS(string strFile, SoldierBundle currentBundle, bool transit, string arrivalTime)
        {
            if (string.IsNullOrEmpty(arrivalTime))
            {
                arrivalTime = "12";
            }
            StringBuilder statBlocks = new StringBuilder();
            currentBundle.soldierCount = 0;

            string nextLine = "\r\n";
            if (transit)
            {
                currentBundle = SetArrivalSoldiers(strFile, currentBundle, statBlocks, nextLine, arrivalTime);
            }
            else
            {
                currentBundle = SetCurrentSoldiers(strFile, currentBundle, statBlocks, nextLine);
            }

            return currentBundle;
        }

        private SoldierBundle SetArrivalSoldiers(string strFile, SoldierBundle currentBundle, StringBuilder statBlocks, string nextLine, string arrivalTime)
        {
            statBlocks.Clear();
            statBlocks.Append("    transfers:" + nextLine);
            var excel = new ExcelQueryFactory(strFile);
            var line = from c in excel.Worksheet("Soldiers")
                           //where c[3].Value  listBox1.SelectedItems
                           //where c[2].Value.ToString() != "Team3" && c[2].Value.ToString() != "Team4"
                       select c;
            foreach (var item in line)
            {
                _soldierGen.statusStrip1.Text = currentBundle.soldierCount.ToString();
                currentBundle.soldierCount++;
                statBlocks.Append("      - hours: " + arrivalTime + nextLine);
                statBlocks.Append("        type: STR_SOLDIER" + nextLine);
                statBlocks.Append("        id: " + currentBundle.soldierCount.ToString() + nextLine);
                statBlocks.Append("        name: " + item[0] + " " + item[1] + nextLine);
                statBlocks.Append("        nationality: 0" + nextLine); // + item[0] + " " + item[1] + nextLine);
                statBlocks.Append("        initialStats:" + nextLine);
                statBlocks.Append("          tu: " + Convert.ToInt32(item[3].Value) + nextLine);
                statBlocks.Append("          stamina: " + Convert.ToInt32(item[4].Value) + nextLine);
                statBlocks.Append("          health: " + Convert.ToInt32(item[5].Value) + nextLine);
                statBlocks.Append("          bravery: " + Convert.ToInt32(item[6].Value) + nextLine);
                statBlocks.Append("          reactions: " + Convert.ToInt32(item[7].Value) + nextLine);
                statBlocks.Append("          firing: " + Convert.ToInt32(item[8].Value) + nextLine);
                statBlocks.Append("          throwing: " + Convert.ToInt32(item[9].Value) + nextLine);
                statBlocks.Append("          strength: " + Convert.ToInt32(item[10].Value) + nextLine);
                statBlocks.Append("          psiStrength: " + Convert.ToInt32(item[11].Value) + nextLine);
                statBlocks.Append("          psiSkill: " + Convert.ToInt32(item[12].Value) + nextLine);
                statBlocks.Append("          melee: " + Convert.ToInt32(item[13].Value) + nextLine);
                statBlocks.Append("        currentStats:" + nextLine);
                statBlocks.Append("          tu: " + Convert.ToInt32(item[3].Value) + nextLine);
                statBlocks.Append("          stamina: " + Convert.ToInt32(item[4].Value) + nextLine);
                statBlocks.Append("          health: " + Convert.ToInt32(item[5].Value) + nextLine);
                statBlocks.Append("          bravery: " + Convert.ToInt32(item[6].Value) + nextLine);
                statBlocks.Append("          reactions: " + Convert.ToInt32(item[7].Value) + nextLine);
                statBlocks.Append("          firing: " + Convert.ToInt32(item[8].Value) + nextLine);
                statBlocks.Append("          throwing: " + Convert.ToInt32(item[9].Value) + nextLine);
                statBlocks.Append("          strength: " + Convert.ToInt32(item[10].Value) + nextLine);
                statBlocks.Append("          psiStrength: " + Convert.ToInt32(item[11].Value) + nextLine);
                statBlocks.Append("          psiSkill: " + Convert.ToInt32(item[12].Value) + nextLine);
                statBlocks.Append("          melee: " + Convert.ToInt32(item[13].Value) + nextLine);
                statBlocks.Append("        rank: 0" + nextLine);
                statBlocks.Append("        gender: " + item[14] + nextLine);
                statBlocks.Append("        look: " + item[15] + nextLine);
                //statBlocks.Append("        lookVariant: 0" + nextLine); //What is this??
                statBlocks.Append("        missions: 0" + nextLine);
                statBlocks.Append("        kills: 0" + nextLine);
                statBlocks.Append("          armor: STR_NONE_UC" + nextLine);
                //statBlocks.Append("          armor: " + GetArmorName(Convert.ToInt32(item[16].Value)) + nextLine);
                statBlocks.Append("        improvement: 0" + nextLine);
                statBlocks.Append("        psiStrImprovement: 0" + nextLine);
                statBlocks.Append("        tags: ~" + nextLine);

            }
            currentBundle.soldierText = statBlocks.ToString();

            return currentBundle;
        }

        private string GetArmorName(int armorKey)
        {
            return ConfigurationManager.AppSettings[armorKey];
        }

        private SoldierBundle SetCurrentSoldiers(string strFile, SoldierBundle currentBundle, StringBuilder statBlocks, string nextLine)
        {
            statBlocks.Clear();
            statBlocks.Append("    soldiers:" + nextLine);
            var excel = new ExcelQueryFactory(strFile);
            var line = from c in excel.Worksheet("Soldiers")
                           //where c[3].Value  listBox1.SelectedItems
                           //where c[2].Value.ToString() != "Team3" && c[2].Value.ToString() != "Team4"
                       select c;
            foreach (var item in line)
            {
                if (!string.IsNullOrWhiteSpace(item[0] + " " + item[1]))
                {
                    _soldierGen.statusStrip1.Text = currentBundle.soldierCount.ToString();
                    currentBundle.soldierCount++;
                    statBlocks.Append("      - type: STR_SOLDIER" + nextLine);
                    statBlocks.Append("        id: " + currentBundle.soldierCount.ToString() + nextLine);
                    statBlocks.Append("        name: " + item[0] + " " + item[1] + nextLine);
                    statBlocks.Append("        nationality: 0" + nextLine); // + item[0] + " " + item[1] + nextLine);
                    statBlocks.Append("        initialStats:" + nextLine);
                    statBlocks.Append("          tu: " + Convert.ToInt32(item[3].Value) + nextLine);
                    statBlocks.Append("          stamina: " + Convert.ToInt32(item[4].Value) + nextLine);
                    statBlocks.Append("          health: " + Convert.ToInt32(item[5].Value) + nextLine);
                    statBlocks.Append("          bravery: " + Convert.ToInt32(item[6].Value) + nextLine);
                    statBlocks.Append("          reactions: " + Convert.ToInt32(item[7].Value) + nextLine);
                    statBlocks.Append("          firing: " + Convert.ToInt32(item[8].Value) + nextLine);
                    statBlocks.Append("          throwing: " + Convert.ToInt32(item[9].Value) + nextLine);
                    statBlocks.Append("          strength: " + Convert.ToInt32(item[10].Value) + nextLine);
                    statBlocks.Append("          psiStrength: " + Convert.ToInt32(item[11].Value) + nextLine);
                    statBlocks.Append("          psiSkill: " + Convert.ToInt32(item[12].Value) + nextLine);
                    statBlocks.Append("          melee: " + Convert.ToInt32(item[13].Value) + nextLine);
                    statBlocks.Append("        currentStats:" + nextLine);
                    statBlocks.Append("          tu: " + Convert.ToInt32(item[3].Value) + nextLine);
                    statBlocks.Append("          stamina: " + Convert.ToInt32(item[4].Value) + nextLine);
                    statBlocks.Append("          health: " + Convert.ToInt32(item[5].Value) + nextLine);
                    statBlocks.Append("          bravery: " + Convert.ToInt32(item[6].Value) + nextLine);
                    statBlocks.Append("          reactions: " + Convert.ToInt32(item[7].Value) + nextLine);
                    statBlocks.Append("          firing: " + Convert.ToInt32(item[8].Value) + nextLine);
                    statBlocks.Append("          throwing: " + Convert.ToInt32(item[9].Value) + nextLine);
                    statBlocks.Append("          strength: " + Convert.ToInt32(item[10].Value) + nextLine);
                    statBlocks.Append("          psiStrength: " + Convert.ToInt32(item[11].Value) + nextLine);
                    statBlocks.Append("          psiSkill: " + Convert.ToInt32(item[12].Value) + nextLine);
                    statBlocks.Append("          melee: " + Convert.ToInt32(item[13].Value) + nextLine);
                    statBlocks.Append("        rank: 0" + nextLine);
                    statBlocks.Append("        gender: " + item[14] + nextLine);
                    statBlocks.Append("        look: " + item[15] + nextLine);
                    //statBlocks.Append("        lookVariant: 0" + nextLine); //What is this??
                    statBlocks.Append("        missions: 0" + nextLine);
                    statBlocks.Append("        kills: 0" + nextLine);
                    statBlocks.Append("          armor: STR_NONE_UC" + nextLine);
                    //statBlocks.Append("          armor: " + GetArmorName(Convert.ToInt32(item[16].Value)) + nextLine);
                    statBlocks.Append("        improvement: 0" + nextLine);
                    statBlocks.Append("        psiStrImprovement: 0" + nextLine);
                    statBlocks.Append("        tags: ~" + nextLine);
                }
            }
            currentBundle.soldierText = statBlocks.ToString();
            return currentBundle;
        }
    }
}