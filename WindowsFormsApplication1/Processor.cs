using LinqToExcel;
using System.Linq;
using System.Text;

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
                statBlocks.Append("        soldier:" + nextLine);
                statBlocks.Append("          id: " + currentBundle.soldierCount.ToString() + nextLine);
                statBlocks.Append("          name: " + item[0] + " " + item[1] + nextLine);
                statBlocks.Append("          initialStats:" + nextLine);
                statBlocks.Append("            tu: " + item[3] + nextLine);
                statBlocks.Append("            stamina: " + item[4] + nextLine);
                statBlocks.Append("            health: " + item[5] + nextLine);
                statBlocks.Append("            bravery: " + item[6] + nextLine);
                statBlocks.Append("            reactions: " + item[7] + nextLine);
                statBlocks.Append("            firing: " + item[8] + nextLine);
                statBlocks.Append("            throwing: " + item[9] + nextLine);
                statBlocks.Append("            strength: " + item[10] + nextLine);
                statBlocks.Append("            psiStrength: " + item[11] + nextLine);
                statBlocks.Append("            psiSkill: " + item[12] + nextLine);
                statBlocks.Append("            melee: " + item[13] + nextLine);
                statBlocks.Append("          currentStats:" + nextLine);
                statBlocks.Append("            tu: " + item[3] + nextLine);
                statBlocks.Append("            stamina: " + item[4] + nextLine);
                statBlocks.Append("            health: " + item[5] + nextLine);
                statBlocks.Append("            bravery: " + item[6] + nextLine);
                statBlocks.Append("            reactions: " + item[7] + nextLine);
                statBlocks.Append("            firing: " + item[8] + nextLine);
                statBlocks.Append("            throwing: " + item[9] + nextLine);
                statBlocks.Append("            strength: " + item[10] + nextLine);
                statBlocks.Append("            psiStrength: " + item[11] + nextLine);
                statBlocks.Append("            psiSkill: " + item[12] + nextLine);
                statBlocks.Append("            melee: " + item[13] + nextLine);
                statBlocks.Append("          rank: 0" + nextLine);
                statBlocks.Append("          gender: " + item[14] + nextLine);
                statBlocks.Append("          look: " + item[15] + nextLine);
                statBlocks.Append("          missions: 0" + nextLine);
                statBlocks.Append("          kills: 0" + nextLine);
                statBlocks.Append("          armor: STR_NONE_UC" + nextLine);
                statBlocks.Append("          improvement: 0" + nextLine);
                statBlocks.Append("          psiStrImprovement: 0" + nextLine);
            }
            currentBundle.soldierText = statBlocks.ToString();

            return currentBundle;
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
                _soldierGen.statusStrip1.Text = currentBundle.soldierCount.ToString();
                currentBundle.soldierCount++;
                statBlocks.Append("      - id: " + currentBundle.soldierCount.ToString() + nextLine);
                statBlocks.Append("        name: " + item[0] + " " + item[1] + nextLine);
                statBlocks.Append("        initialStats:" + nextLine);
                statBlocks.Append("          tu: " + item[3] + nextLine);
                statBlocks.Append("          stamina: " + item[4] + nextLine);
                statBlocks.Append("          health: " + item[5] + nextLine);
                statBlocks.Append("          bravery: " + item[6] + nextLine);
                statBlocks.Append("          reactions: " + item[7] + nextLine);
                statBlocks.Append("          firing: " + item[8] + nextLine);
                statBlocks.Append("          throwing: " + item[9] + nextLine);
                statBlocks.Append("          strength: " + item[10] + nextLine);
                statBlocks.Append("          psiStrength: " + item[11] + nextLine);
                statBlocks.Append("          psiSkill: " + item[12] + nextLine);
                statBlocks.Append("          melee: " + item[13] + nextLine);
                statBlocks.Append("        currentStats:" + nextLine);
                statBlocks.Append("          tu: " + item[3] + nextLine);
                statBlocks.Append("          stamina: " + item[4] + nextLine);
                statBlocks.Append("          health: " + item[5] + nextLine);
                statBlocks.Append("          bravery: " + item[6] + nextLine);
                statBlocks.Append("          reactions: " + item[7] + nextLine);
                statBlocks.Append("          firing: " + item[8] + nextLine);
                statBlocks.Append("          throwing: " + item[9] + nextLine);
                statBlocks.Append("          strength: " + item[10] + nextLine);
                statBlocks.Append("          psiStrength: " + item[11] + nextLine);
                statBlocks.Append("          psiSkill: " + item[12] + nextLine);
                statBlocks.Append("          melee: " + item[13] + nextLine);
                statBlocks.Append("        rank: 0" + nextLine);
                statBlocks.Append("        gender: " + item[14] + nextLine);
                statBlocks.Append("        look: " + item[15] + nextLine);
                statBlocks.Append("        missions: 0" + nextLine);
                statBlocks.Append("        kills: 0" + nextLine);
                statBlocks.Append("        armor: STR_NONE_UC" + nextLine);
                statBlocks.Append("        improvement: 0" + nextLine);
                statBlocks.Append("        psiStrImprovement: 0" + nextLine);
            }
            currentBundle.soldierText = statBlocks.ToString();
            return currentBundle;
        }
    }
}