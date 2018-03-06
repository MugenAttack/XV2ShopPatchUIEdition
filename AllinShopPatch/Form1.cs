using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllinShopPatch
{
    public struct tdbdata
    {
        public short id;
        public short star;
        public int tp;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chklstIDB.GetItemChecked(0))
                applytoIDB("data\\system\\item\\costume_top_item.idb");

            if (chklstIDB.GetItemChecked(1))
                applytoIDB("data\\system\\item\\costume_bottom_item.idb");

            if (chklstIDB.GetItemChecked(1))
                applytoIDB("data\\system\\item\\costume_shoes_item.idb");

            if (chklstIDB.GetItemChecked(3))
                applytoIDB("data\\system\\item\\costume_gloves_item.idb");

            if (chklstIDB.GetItemChecked(4))
                applytoIDB("data\\system\\item\\accessory_item.idb");

            if (chklstIDB.GetItemChecked(5))
                applytoIDB("data\\system\\item\\skill_item.idb");

            if (chklstIDB.GetItemChecked(6))
                applytoIDB("data\\system\\item\\talisman_item.idb");

            if (chklstIDB.GetItemChecked(7))
                applytoIDB("data\\system\\item\\battle_item.idb");

            if (chklstIDB.GetItemChecked(8))
                applytoIDB("data\\system\\item\\material_item.idb");

            if (chklstIDB.GetItemChecked(9))
                modifyTdbS1("data\\system\\TtlList\\TTLItemList.tdb", 8);

            if (chklstIDB.GetItemChecked(10))
                modifyTdbS1("data\\system\\TtlList\\TTLItemList.tdb", 16);

            MessageBox.Show("Patch has been Applied to Selected Items");
        }

        private void RegShop_Click(object sender, EventArgs e)
        {
            RegShop.Checked = !RegShop.Checked;
        }

        private void IgnoreZeni_Click(object sender, EventArgs e)
        {
            IgnoreZeni.Checked = !IgnoreZeni.Checked;
        }

        private void IgnoreTP_Click(object sender, EventArgs e)
        {
            IgnoreTP.Checked = !IgnoreTP.Checked;
        }

        private void applytoIDB(string filename)
        {
            IDB file = new IDB();
            file.Read(filename);
            for (int i = 0; i < file.items.Length; i++)
            {
                if (!(file.items[i].buy == 0 && file.items[i].tp == 0 && !addToShopToolStripMenuItem.Checked))
                {
                    if (RegShop.Checked)
                    {
                        file.items[i].unk2 = 32767;
                    }

                    DataTable dt = new DataTable();
                    bool allow = true;

                    if (IgnoreZeni.Checked)
                        allow = file.items[i].buy == 0;

                    if (allow)
                    {
                        string Zeni = txtZeni.Text;
                        Zeni = Zeni.Replace("ID", file.items[i].id.ToString());
                        Zeni = Zeni.Replace("STAR", file.items[i].star.ToString());
                        Zeni = Zeni.Replace("BUY", file.items[i].buy.ToString());
                        Zeni = Zeni.Replace("SELL", file.items[i].sell.ToString());
                        Zeni = Zeni.Replace("TP", file.items[i].tp.ToString());
                        Zeni = Zeni.Replace("TYPE", file.items[i].type.ToString());
                        file.items[i].buy = (int)dt.Compute(Zeni, "");
                    }

                    if (IgnoreTP.Checked)
                        allow = file.items[i].tp == 0;

                    if (allow)
                    {
                        string Tp = txtTP.Text;
                        Tp = Tp.Replace("ID", file.items[i].id.ToString());
                        Tp = Tp.Replace("STAR", file.items[i].star.ToString());
                        Tp = Tp.Replace("BUY", file.items[i].buy.ToString());
                        Tp = Tp.Replace("SELL", file.items[i].sell.ToString());
                        Tp = Tp.Replace("TP", file.items[i].tp.ToString());
                        Tp = Tp.Replace("TYPE", file.items[i].type.ToString());
                        file.items[i].tp = (int)dt.Compute(Tp, "");
                    }
                }
            }

            file.Write(filename);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyTdbS1(string FileName,int readPoint)
        {
            int count;
            int startAddress;
            tdbdata[] items;
            using (BinaryReader br = new BinaryReader(File.Open(FileName, FileMode.Open)))
            {
                br.BaseStream.Seek(readPoint,SeekOrigin.Begin);
                count = br.ReadInt32();
                startAddress = br.ReadInt32();
                items = new tdbdata[count];
                for (int i = 0; i < count; i++)
                {
                    br.BaseStream.Seek(startAddress + (44 * i), SeekOrigin.Begin);
                    br.BaseStream.Seek(0, SeekOrigin.Current);
                    items[i].id = br.ReadInt16();
                    br.BaseStream.Seek(2, SeekOrigin.Current);
                    items[i].star = br.ReadInt16();
                    br.BaseStream.Seek(34, SeekOrigin.Current);
                    items[i].tp = br.ReadInt32();
                }
            }

            using (BinaryWriter bw = new BinaryWriter(File.Open(FileName, FileMode.Open)))
            {
                for (int i = 0; i < count; i++)
                {
                    bw.BaseStream.Seek(startAddress + (44 * i) + 40, SeekOrigin.Begin);
                    string tp = txtTP.Text;
                    DataTable dt = new DataTable();
                    
                    string Tp = txtTP.Text;
                    Tp = Tp.Replace("ID", items[i].id.ToString());
                    Tp = Tp.Replace("STAR", items[i].star.ToString());
                    Tp = Tp.Replace("BUY", 1.ToString());
                    Tp = Tp.Replace("SELL", 1.ToString());
                    Tp = Tp.Replace("TP", items[i].tp.ToString());
                    Tp = Tp.Replace("TYPE", 1.ToString());
                    bw.Write((int)dt.Compute(Tp, ""));

                    if (addToShopToolStripMenuItem.Checked)
                    {
                        bw.BaseStream.Seek(startAddress + (44 * i) + 16, SeekOrigin.Begin);
                        bw.Write(new byte[]{0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x0});
                    }
                }

            }
        }

        private void addToShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToShopToolStripMenuItem.Checked = !addToShopToolStripMenuItem.Checked;
        }
    }
}
