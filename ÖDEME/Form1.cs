using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEME
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox5.Text);
            panel_kart.Visible = true;
            label7.Text = textBox5.Text; 
            if (checkBox1.Checked && checkBox2.Checked)
            {
                panel_nkt.Visible = true;
                panel_kart.Visible = true;
                panel_chk.Visible = false;
                panel1.Visible = false;
                }
                if (checkBox1.Checked && checkBox3.Checked)
                {
                    panel_kart.Visible = true;
                    panel_chk.Visible = true;
                    panel_nkt.Visible = false;
                    panel2.Visible = false;
                }
            if( checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                panel_nkt.Visible = true;
                panel_chk.Visible = true;
                panel_kart.Visible = true;
            }
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int b;
            b = Convert.ToInt32(textBox6.Text);
            panel_nkt.Visible = true;
            label6.Text = textBox6.Text;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                panel_nkt.Visible = true;
                panel_kart.Visible = true;
                panel_chk.Visible = false;
                panel1.Visible = false;
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                panel_nkt.Visible = true;
                panel_chk.Visible = true;
                panel_kart.Visible = false;
                panel3.Visible = false;
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                panel_nkt.Visible = true;
                panel_chk.Visible = true;
                panel_kart.Visible = true;
            }

        }
        
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int c;
            c = Convert.ToInt32(textBox7.Text);
            panel_chk.Visible = true;
            label11.Text = textBox7.Text;
            if (checkBox1.Checked && checkBox3.Checked)
            {
                panel_kart.Visible = true;
                panel_chk.Visible = true;
                panel_nkt.Visible = false;
                panel2.Visible = false;
            }
            if (checkBox2.Checked && checkBox3.Checked)
            {
                panel_nkt.Visible = true;
                panel_chk.Visible = true;
                panel_kart.Visible = false;
                panel3.Visible = false;
            }
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                panel_nkt.Visible = true;
                panel_chk.Visible = true;
                panel_kart.Visible = true;
            }

        }
        

      

        private void button1_Click(object sender, EventArgs e)
        {
            KREDI k = new KREDI();
            k.Numara = Convert.ToInt64(textBox1.Text);
            k.Tip = (radioButton1.Text == "") ? radioButton2.Text : radioButton1.Text;
          
            k.sonTarih =textBox5.Text;
            MessageBox.Show("Kredi Kart Numaranız:"+k.Numara.ToString()+"\n KartTipiniz:"+k.Tip+"\n Valid Thru:"+k.sonTarih);

          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NAKIT n = new NAKIT();
            n.nakitTeklifi = Convert.ToInt32(textBox6.Text);
            textBox6.Text = label6.Text;
            MessageBox.Show("Ödemeniz Gereken Tutar:"+n.nakitTeklifi.ToString());
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            CHECK c = new CHECK();
            c.Isim = textBox4.Text;
            c.bankaID = textBox3.Text;
            MessageBox.Show("İsminiz:" + c.Isim + "n banka ID'si:" + c.bankaID); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = "100";
            panel_chk.Hide();
            panel_nkt.Hide();
            panel_kart.Hide();
            
            
            
        }
    }
    public abstract class PAYMENT
    {
        public int Tutar { get; set; }
        public void Ode() { }
         
        
        
    }
            
    public class KREDI: PAYMENT
    {
        
        public long Numara { get; set; }
        public string Tip { get; set; }
        public string sonTarih { get; set; }
        

    }
    public class NAKIT : PAYMENT
    {
        public int nakitTeklifi { get; set; }
    }
    public class CHECK : PAYMENT
    {
        public string Isim { get; set; }
        public string bankaID { get; set; }
    }
    
   
    
}
