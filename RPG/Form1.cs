using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
  public partial class Form1 : Form
  {
    int index = 0;
    int numOfResets = 3;


    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      switch(index)
      {
        case 0:
          textBox1.Text = Roll().ToString();
          break;
        case 1:
          textBox2.Text = Roll().ToString();
          break;
        case 2:
          textBox3.Text = Roll().ToString();
          break;
        case 3:
          textBox4.Text = Roll().ToString();
          break;
        case 4:
          textBox5.Text = Roll().ToString();
          break;
        case 5:
          textBox6.Text = Roll().ToString();
          break;
      }
      btn_Roll.Location = new Point(btn_Roll.Location.X, btn_Roll.Location.Y + textBox1.Height);
      index++;
      if(index > 5)
      {
        btn_Confirm.Enabled = true;
      }
    }

    int Roll()
    {
      Random rand = new Random();
      int sum = 0;
      
      for (int i = 0; i < 3; i++)
      {
        sum += rand.Next(1, 6);
      }
      return sum;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (numOfResets > 0)
      {

        listBox1.Visible = false;
        index = 0;
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
        textBox5.Text = "";
        textBox6.Text = "";
        btn_Roll.Location = new Point(btn_Roll.Location.X, textBox1.Location.Y + textBox1.Height);
        numOfResets--;
        btn_Confirm.Enabled = false;
      }
    }

    private void btn_Confirm_Click(object sender, EventArgs e)
    {
      if (!listBox1.Visible)

      {
        if (listBox1.Items.Count > 0)
        {
          listBox1.Items.Clear();
        }
        Player p = new Player(
          int.Parse(textBox1.Text),
          int.Parse(textBox2.Text),
          int.Parse(textBox3.Text),
          int.Parse(textBox4.Text),
          int.Parse(textBox5.Text),
          int.Parse(textBox6.Text)
          );
        listBox1.Visible = true;

        if (int.Parse(textBox1.Text) >= 9)
        {
          listBox1.Items.Add("Fighter");
        }

        if (int.Parse(textBox2.Text) >= 9)
        {
          listBox1.Items.Add("Thief");
        }

        if (int.Parse(textBox4.Text) >= 9)
        {
          listBox1.Items.Add("Mage");
        }

        if (int.Parse(textBox5.Text) >= 9)
        {
          listBox1.Items.Add("Priest");
        }

      }
    else
    {
    if (listBox1.Text == "Mage")
      {
       Mage player = new Mage();
      }
       else if (listBox1.Text == "Warrior")
      {
       Warrior player = new Warrior();
       }
       else if (listBox1.Text == "Thief")
       {
         Thief player = new Thief();
       }
       else if (listBox1.Text == "Priest")
       {
        Priest player = new Priest();
       }
      else
      {
          MessageBox.Show("No Class Selected");
      }
       }



    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
