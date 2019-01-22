using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SLOWNIK
{
    public partial class Form1 : Form
    {
        private bool endnauka = false;
        
    
        public Form1()
        {
          
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int idx = lbxWyrazy.FindString(txtWyszukaj.Text, 0);

            if (idx > 0)
            {
                lbxWyrazy.SelectedIndex = idx;
                txtWyszukaj.SelectAll();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tPolTableAdapter1.Fill(dsBaza1.TPol);
            tEnTableAdapter1.Fill(dsBaza1.TEn);
            tKategorieTableAdapter1.Fill(dsBaza1.TKategorie);

            tscbRodzjSlownika.SelectedIndex = 0;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtNowaKategoria.Text.Length == 0)
            {
                toolTip1.Show("Podaj nazwe kategorii", txtNowaKategoria, 1000);
                return;
            }

            if (dsBaza1.TKategorie.Rows.Find(txtNowaKategoria.Text) == null)
            {
                DataRow dr = dsBaza1.TKategorie.NewRow();
                dr["nazwa"] = txtNowaKategoria.Text;
                dsBaza1.TKategorie.Rows.Add(dr);
                tKategorieTableAdapter1.Update(dsBaza1.TKategorie);
                txtNowaKategoria.Clear();
            }
            else
            {
                toolTip1.Show("Ta kategoria juz istnieje", txtNowaKategoria, 1000);

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DataRowView drV = (DataRowView)cbKategorie.SelectedItem;

            if (drV != null)
            {

                if (MessageBox.Show(this, "Na pewno usunac kategorie. \nSpowoduje to usuniecie wszystkich s³ow z tej kategorii?", "Pyatnia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    

                        foreach (DataRow drr in dsBaza1.TEn.Rows)
                        {
                            //  MessageBox.Show(drr["wyraz"].ToString());
                            if (drr["nazwakat"].ToString() == cbKategorie.Text)
                            {
                                drr.Delete();
                            }

                        }
                        tEnTableAdapter1.Update(dsBaza1);
                   

                    

                        foreach (DataRow drr in dsBaza1.TPol.Rows)
                        {
                            //  MessageBox.Show(drr["wyraz"].ToString());
                            if (drr["nazwakat"].ToString() == cbKategorie.Text)
                            {
                                drr.Delete();
                            }

                        }
                        tPolTableAdapter1.Update(dsBaza1);
                  



                    try
                    {
                        drV.Delete();
                        tKategorieTableAdapter1.Update(dsBaza1.TKategorie);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool duplicate=false;
            if (txtWyraz.Text.Length == 0)
            {
                toolTip1.Show("Pole nie mo¿e byæ puste", txtWyraz, 1000);
                return;
            }

            if (txtZnaczenie1.Text.Length == 0)
            {
                toolTip1.Show("Musi byæ podane jedno  znaczenie",txtZnaczenie1, 1000);
                return;

            }

            //test cz w slowniku angielskim nie wystepuje takie slowo
            if (tscbRodzjSlownika.SelectedIndex == 0)
            {

                foreach (DataRow drr in dsBaza1.TEn.Rows)
                {
                  //  MessageBox.Show(drr["wyraz"].ToString());
                    if (drr["wyraz"].ToString() == txtWyraz.Text)
                    {
                        duplicate = true;
                        break;
                    }

                }
            }
            else
            {
                foreach (DataRow drr in dsBaza1.TPol.Rows)
                {
                   // MessageBox.Show(drr["wyraz"].ToString());
                    if (drr["wyraz"].ToString() == txtWyraz.Text)
                    {
                        duplicate = true;
                        break;
                    }

                }
            }


            if(duplicate==false)
          //  if (dsBaza1.Tables[bindingSource1.DataMember].Rows.Find(txtWyraz.Text) == null)
            {
                //DataRow dr = dsBaza1.Tables[bindingSource1.DataMember].NewRow();
                if (tscbRodzjSlownika.SelectedIndex == 0)
                {
                DataRow dr = dsBaza1.TEn.NewRow();

                dr["wyraz"] = txtWyraz.Text;
                dr["nazwakat"] = cbKategorie.SelectedValue;
                dr["znaczenie1"] = txtZnaczenie1.Text;
                dr["znaczenie2"] = txtZnaczenie2.Text;
                dr["znaczenie3"] = txtxZnaczenie3.Text;
                dr["uwagi"]=txtUwagi.Text;

             //   dsBaza1.Tables[bindingSource1.DataMember].Rows.Add(dr);
                dsBaza1.TEn.Rows.Add(dr);

                
                    tEnTableAdapter1.Update(dr);

                    DataRow dr1 = dsBaza1.TPol.NewRow();
                    dr1["wyraz"]=txtZnaczenie1.Text;
                    dr1["nazwakat"] = cbKategorie.SelectedValue;
                    dr1["znaczenie1"]=txtWyraz.Text;

                    dsBaza1.TPol.Rows.Add(dr1);
                    tPolTableAdapter1.Update(dr1);


                }
                else
                {
                    DataRow dr = dsBaza1.TPol.NewRow();

                    dr["wyraz"] = txtWyraz.Text;
                    dr["nazwakat"] = cbKategorie.SelectedValue;
                    dr["znaczenie1"] = txtZnaczenie1.Text;
                    dr["znaczenie2"] = txtZnaczenie2.Text;
                    dr["znaczenie3"] = txtxZnaczenie3.Text;
                    dr["uwagi"] = txtUwagi.Text;

                    tPolTableAdapter1.Update(dr);

                    DataRow dr1 = dsBaza1.TEn.NewRow();
                    dr1["wyraz"]=txtZnaczenie1.Text;
                    dr1["nazwakat"] = cbKategorie.SelectedValue;
                    dr1["znaczenie1"]=txtWyraz.Text;

                    dsBaza1.TEn.Rows.Add(dr1);
                    tEnTableAdapter1.Update(dr1);
                }

                txtWyraz.Text=txtZnaczenie1.Text=txtZnaczenie2.Text=txtxZnaczenie3.Text=txtUwagi.Text="";

            }
            else
            {
                toolTip1.Show("Wyraz juz istnieje",txtWyraz, 1000);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (dgvDodaneSlowka.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(this, "Na pewno usunac s³owko?", "Pyatnia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow dGVR in dgvDodaneSlowka.SelectedRows)
                    {
                        ((DataRowView)dGVR.DataBoundItem).Delete();
                    }

                    if (tscbRodzjSlownika.SelectedIndex == 0)
                    {
                        tEnTableAdapter1.Update(dsBaza1.TEn);
                    }
                    else
                    {
                        tPolTableAdapter1.Update(dsBaza1.TPol);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Nie wybrano zadnego slowka");
            }
        }

        private void lbxWyrazy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWyrazy.SelectedIndex >= 0)
            {
                DataRowView drV = (DataRowView)lbxWyrazy.SelectedItem;

                txtOpis.Lines = new string[] {"t³umaczenia \r\n\t"+
                    drV.Row[2].ToString()+"\r\n\t"+
                    drV.Row[3].ToString()+"\r\n\t"+
                    drV.Row[4].ToString(),"Kategoria: "+
                    drV.Row[1].ToString(), "Uwagi: " + drV.Row[5].ToString()};

            }
        }

        private void txtWyszukaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStart_Click(null, null);
            }
        }

        private void tsbtnAddToNAuka_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }


        private void tabNauka_Enter(object sender, EventArgs e)
        {
            cbSlownik.SelectedIndex = 0;       
            btnSprawdz.Enabled = false;
        }

        private void cbKategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            Koniec();          
            btnSprawdz.Enabled = true;
        }
       

        private void WypelnijListe()
        {
            lbxNaukaEn.Items.Clear();
            
            if (cbSlownik.SelectedIndex == 0)  //ang-pol
            {

                foreach (String lst in lbxKategorieWybrane.Items)
                {
           

                    foreach (dsBaza.TEnRow drv in dsBaza1.TEn)
                    {

                       
                        if (drv[1].ToString() == lst)
                        {
                            lbxNaukaEn.Items.Add(drv[0].ToString());


                        }
                    }
                }
                


            }
            else  //pol-ang
            {
                foreach (String lst in lbxKategorieWybrane.Items)
                {
                    foreach (dsBaza.TPolRow drv in dsBaza1.TPol)
                    {

                        if (drv[1].ToString() == lst)
                        {
                            lbxNaukaEn.Items.Add(drv[0].ToString());


                        }
                    }
                }
            }
            lbxNaukaEn.Update();
        }

        private void LosujSlowko()
        {
            txtZnaczenie.Clear(); 
            txtSlowko.Clear();
          
            if (lbxNaukaEn.Items.Count > 0)
            {
                int randnumber;
                Random rnd = new Random();
                randnumber = rnd.Next(0, lbxNaukaEn.Items.Count);
                txtSlowko.Text = lbxNaukaEn.Items[randnumber].ToString();              

            }
            
        
        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lbxNaukaEn.Items.Count > 1)
            {
                if (txtZnaczenie.Text.Length > 0)
                 {
                Sprawdz();
                
                    if (rdbnopowt.Checked == true)
                    {
                        lbxNaukaEn.Items.Remove((string)txtSlowko.Text);
                        lbxNaukaEn.Update();

                    }
                    LosujSlowko();
                 }               
            }
            else
            {
               
                btnKoniec_Click(null, null);
            }
        }
        private void Koniec()
        {
            endnauka = true;
            WyczyscWszystko();
            
          
        }

        private void WyczyscWszystko()
        {
            txtSlowko.Clear();
            txtZnaczenie.Clear();
            lbxNaukaEn.Items.Clear();
            lbxKategorieWybrane.Items.Clear();

            txtDobrze.Text = "0";
            txtZle.Text = "0";
            btnSprawdz.Enabled = false;
            btnNext.Enabled = false;

        }
        private void Sprawdz()
        {
            int liczba;

            if (cbSlownik.SelectedIndex == 0)
            {
                foreach (dsBaza.TEnRow drv in dsBaza1.TEn)
                {

                    if (txtZnaczenie.Text.Length > 0)
                    {
                        if (drv["wyraz"].ToString() == txtSlowko.Text)
                        {
                            if (drv["znaczenie1"].ToString() == txtZnaczenie.Text || drv["znaczenie2"].ToString() == txtZnaczenie.Text || drv["znaczenie3"].ToString() == txtZnaczenie.Text)
                            {
                                liczba = int.Parse(txtDobrze.Text);
                                liczba = liczba + 1;
                                txtDobrze.Text = liczba.ToString();
                            }
                            else
                            {
                                DodajDoBledow(txtSlowko.Text);
                                liczba = int.Parse(txtZle.Text);
                                liczba = liczba + 1;
                                txtZle.Text = liczba.ToString();
                            }
                            break;
                        }
                    }
                }
            }

            

            if (cbSlownik.SelectedIndex == 1)
            {
                foreach (dsBaza.TPolRow drv in dsBaza1.TPol)
                {

                    if (txtZnaczenie.Text.Length > 0)
                    {
                        if (drv["wyraz"].ToString() == txtSlowko.Text)
                        {
                            if (drv["znaczenie1"].ToString() == txtZnaczenie.Text || drv["znaczenie2"].ToString() == txtZnaczenie.Text || drv["znaczenie3"].ToString() == txtZnaczenie.Text)
                            {
                                liczba = int.Parse(txtDobrze.Text);
                                liczba = liczba + 1;
                                txtDobrze.Text = liczba.ToString();
                            }
                            else
                            {
                                DodajDoBledow(txtSlowko.Text);
                                liczba = int.Parse(txtZle.Text);
                                liczba = liczba + 1;
                                txtZle.Text = liczba.ToString();
                            }
                            break;
                        }
                    }
                }

            }
           
            
            

        }

        private void DodajDoBledow(string str)
        {
            if (lbxPodsumowanie.FindString(str) == -1)
            {
                lbxPodsumowanie.Items.Add(str);
            }

        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            Start();
            
          
        }
        private void Start()
        {
            WypelnijListe();
            LosujSlowko();
            btnSprawdz.Enabled = false;
            btnNext.Enabled = true;
            btnKoniec.Enabled = true;

            lbxPodsumowanie.Items.Clear();
        }

        private void txtZle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tscbRodzjSlownika_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbRodzjSlownika.SelectedIndex == 0)
            {
                bindingSource1.DataSource = dsBaza1.TEn;
            }
            if (tscbRodzjSlownika.SelectedIndex == 1)
            {
                bindingSource1.DataSource = dsBaza1.TPol;
            }
        }

        private void cbSlownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (endnauka == true)
            {
                endnauka = false;
                lbxPodsumowanie.Items.Clear();
                lbxPodsumowanie.Visible = false;
                btnKoniec.Enabled = false;
                btnSprawdz.Enabled = false;
                btnAddToNauka.Enabled = true;
                btnRemoveToNauka.Enabled = true;
                btnRemoveAll.Enabled = true;
                btnAddAll.Enabled = true;
                
            }
            else
            {
                Koniec();
            }
        }

        private void tsbToSpeech_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechLib.SpVoice sp = new SpeechLib.SpVoice();
                sp.Speak(lbxWyrazy.SelectedValue.ToString(), SpeechLib.SpeechVoiceSpeakFlags.SVSFDefault);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tsbAddKat_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToNauka_Click(object sender, EventArgs e)
        {
            if (btnKoniec.Enabled == true)
            {
                btnAddToNauka.Enabled = false;
            }
            else
            {
                if (lbxKategorieWybrane.FindString(lbxKategorie.Text) == -1)
                {
                    lbxKategorieWybrane.Items.Add(lbxKategorie.Text);
                }
                else
                {
                    MessageBox.Show("Ta kategoria jest juz wybrana");
                }



                btnSprawdz.Enabled = true;
            }
            
        }

        private void txtZnaczenie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNext_Click(null, null);
            }
        }

        private void btnKoniec_Click(object sender, EventArgs e)
        {
            Koniec();

            lbxPodsumowanie.Visible = true;
            lblBledy.Visible = true;
        }

        private void btnRemoveToNauka_Click(object sender, EventArgs e)
        {
            if (btnKoniec.Enabled == true)
            {
               btnRemoveToNauka.Enabled = false;
            }
            else
            {
                lbxKategorieWybrane.Items.Remove(lbxKategorieWybrane.SelectedItem);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (btnKoniec.Enabled == true)
            {
               btnAddAll.Enabled = false;
            }
            else
            {
                lbxKategorieWybrane.Items.Clear();
                
                    foreach (DataRowView drv in lbxKategorie.Items)
                    {
                        lbxKategorieWybrane.Items.Add(drv[0].ToString());

                    }
               
                    btnSprawdz.Enabled = true;                
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (btnKoniec.Enabled == true)
            {
                btnRemoveAll.Enabled = false;
            }
            else
            {
                lbxKategorieWybrane.Items.Clear();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}