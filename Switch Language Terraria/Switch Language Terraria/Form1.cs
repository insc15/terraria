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

namespace Switch_Language_Terraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool check = false;

        private void button2_Click(object sender, EventArgs e)
        {
            //check de xoa file cu
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Terraria.exe"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Terraria.exe");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\readme.txt"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\readme.txt");
            }
            //en
            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb", Properties.Resources.Logo_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb", Properties.Resources.Logo2_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb", Properties.Resources.Logo3_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb", Properties.Resources.Logo4_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb", Properties.Resources.Splash_1_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb", Properties.Resources.Splash_1_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb", Properties.Resources.Splash_2_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb", Properties.Resources.Splash_3_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb", Properties.Resources.Splash_4_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb", Properties.Resources.Splash_5_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb", Properties.Resources.Splash_6_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb", Properties.Resources.Splash_7_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb", Properties.Resources.Splash_8_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb", Properties.Resources.Splash_9_0_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb", Properties.Resources.Combat_Crit_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb", Properties.Resources.Combat_Text_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb", Properties.Resources.Death_Text_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb", Properties.Resources.Item_Stack_en);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb", Properties.Resources.Mouse_Text_en);

            if (check == true)
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Terraria.exe", Properties.Resources.Terraria_en_cr);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe", Properties.Resources.TerrariaServer_en_cr);
            }
            if (check == false)
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Terraria.exe", Properties.Resources.Terraria_en);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe", Properties.Resources.TerrariaServer_en);
            }    
            MessageBox.Show("Thành công","Info", MessageBoxButtons.OK);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check de xoa file cu
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Terraria.exe"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\Terraria.exe");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe");
            }
            if (File.Exists(Directory.GetCurrentDirectory() + @"\readme.txt"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"\readme.txt");
            }
            //vi
            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo.xnb", Properties.Resources.Logo);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo2.xnb", Properties.Resources.Logo2);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo3.xnb", Properties.Resources.Logo3);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\Logo4.xnb", Properties.Resources.Logo4);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1.xnb", Properties.Resources.Splash_1);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_1_0.xnb", Properties.Resources.Splash_1_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_2_0.xnb", Properties.Resources.Splash_2_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_3_0.xnb", Properties.Resources.Splash_3_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_4_0.xnb", Properties.Resources.Splash_4_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_5_0.xnb", Properties.Resources.Splash_5_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_6_0.xnb", Properties.Resources.Splash_6_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_7_0.xnb", Properties.Resources.Splash_7_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_8_0.xnb", Properties.Resources.Splash_8_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Images\SplashScreens\Splash_9_0.xnb", Properties.Resources.Splash_9_0);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Crit.xnb", Properties.Resources.Combat_Crit);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Combat_Text.xnb", Properties.Resources.Combat_Text);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Death_Text.xnb", Properties.Resources.Death_Text);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Item_Stack.xnb", Properties.Resources.Item_Stack);

            File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Content\Fonts\Mouse_Text.xnb", Properties.Resources.Mouse_Text);
            
            if (check == true)
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Terraria.exe", Properties.Resources.Terraria_cr);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe", Properties.Resources.TerrariaServer_cr);
            }
            if (check == false)
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\Terraria.exe", Properties.Resources.Terraria);

                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\TerrariaServer.exe", Properties.Resources.TerrariaServer);
            }
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\readme.txt", Properties.Resources.readme);

            MessageBox.Show("Thành công", "Info", MessageBoxButtons.OK);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check = true;
            label1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
