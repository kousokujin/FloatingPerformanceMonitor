using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingPerformanceMonitor
{
    public partial class seting : Form
    {
        Form mainwindow;
        Label cpu_label, cpu_value, mem_label, mem_value, time_label, time_value;
        TableLayoutPanel table;
        seting_data set_d=new seting_data();
        seting_data set_true;
        version ver = null; // バージョン情報
        

        public seting(seting_data set,Form main,TableLayoutPanel tab,Label cp_lab,Label cp_val,Label me_lab,Label me_val,Label time_lab,Label time_val)
        {
            set_true = set;
            mainwindow = main;
            table = tab;
            cpu_label = cp_lab;
            cpu_value = cp_val;
            mem_label = me_lab;
            mem_value = me_val;
            time_label = time_lab;
            time_value = time_val;

            set_true.cp_class(set_d);
            InitializeComponent();
            set_control();
        }

        public void set_control()
        {
            CPU_enable_chack.Checked = set_true.cpu_enable;    //チェックボックス
            mem_enable_ckeck.Checked = set_true.mem_enable;
            time_enable_check.Checked = set_true.time_enable;

            this.trackBar1.Value = set_true.mainform_opt;          //透明度
            this.opa_lv_label.Text = (100-set_d.mainform_opt).ToString();

            this.Top_most_check.Checked = mainwindow.TopMost;   //透明度ラベル


            this.back_op_check.Checked = set_true.back; //背景透明
            this.back_color_button.Enabled = !(set_true.back);

            this.Top_most_check.Checked = set_true.top; //常に最前面
        }

        public void label_setup(seting_data set_in)
        {
            int n = 0;
            int Row=0;

            if (set_in.cpu_enable)
            {
                Row++;
            }

            if (set_in.mem_enable)
            {
                Row++;
            }

            if (set_in.time_enable)
            {
                Row++;
            }

            table.RowCount= Row;

            if (set_in.cpu_enable)
            {
                table.Controls.Add(cpu_label, 0, n);
                table.Controls.Add(cpu_value, 1, n);
                n++;
            }

            if (set_in.mem_enable)
            {
                table.Controls.Add(mem_label, 0, n);
                table.Controls.Add(mem_value, 1, n);
                n++;
            }

            if (set_in.time_enable)
            {
                table.Controls.Add(time_label, 0, n);
                table.Controls.Add(time_value, 1, n);
            }
            mainwindow.Width = table.Width;
            mainwindow.Height = table.Height;
        }

        private void re_setup() //set_trueを元にメインウィンドウのプロパティを設定する
        {
            mainwindow.Opacity = (double)set_true.mainform_opt/100.00;
            mainwindow.TopMost = set_true.top;
            mainwindow.BackColor = convert_from_mycolor(set_true.back_mycolor);

            cpu_label.Font = new Font(set_true.font_name, set_true.font_size);
            cpu_value.Font = new Font(set_true.font_name, set_true.font_size);
            mem_label.Font = new Font(set_true.font_name, set_true.font_size);
            mem_value.Font = new Font(set_true.font_name, set_true.font_size);
            time_label.Font = new Font(set_true.font_name, set_true.font_size);
            time_value.Font = new Font(set_true.font_name, set_true.font_size);

            cpu_label.ForeColor = convert_from_mycolor(set_true.cpu_mycolor);
            cpu_value.ForeColor = convert_from_mycolor(set_true.cpu_mycolor);
            mem_label.ForeColor = convert_from_mycolor(set_true.mem_mycolor);
            mem_value.ForeColor = convert_from_mycolor(set_true.mem_mycolor);
            time_label.ForeColor = convert_from_mycolor(set_true.time_mycolor);
            time_value.ForeColor = convert_from_mycolor(set_true.time_mycolor);

            if (set_true.cpu_enable)    //CPUラベル
            {
                cpu_label.Show();
                cpu_value.Show();
            }
            else
            {
                cpu_label.Hide();
                cpu_value.Hide();
            }

            if (set_true.mem_enable)    //MEMラベル
            {
                mem_label.Show();
                mem_value.Show();
            }
            else
            {
                mem_label.Hide();
                mem_value.Hide();
            }

            if (set_true.time_enable)   //Timeラベル
            {
                time_label.Show();
                time_value.Show();
            }
            else
            {
                time_label.Hide();
                time_value.Hide();
            }

            if (set_true.back)  //背景透過
            {
                mainwindow.TransparencyKey = convert_from_mycolor(set_true.back_mycolor);
            }
            else
            {
                mainwindow.TransparencyKey = System.Drawing.Color.AliceBlue;
            }
        }

        private Color convert_from_mycolor(my_color co)          //RGBからColor構造体へ変換
        {        
            Color output;
            output = Color.FromArgb(co.red, co.green, co.blue);
            return output;
        }

        private my_color convert_from_color(Color co)   //Color構造体からRGBへ変換
        {
            my_color output;
            output.red = co.R;
            output.green = co.G;
            output.blue = co.B;

            return output;
        }
        //------------------以下イベント---------------------------------

        private void trackBar1_Scroll(object sender, EventArgs e)       //透明度のバーが変更された時
        {
            double opa=(double)(this.trackBar1.Value)/100.00;
            mainwindow.Opacity = opa;
            this.opa_lv_label.Text = (100-this.trackBar1.Value).ToString();
            set_d.mainform_opt = this.trackBar1.Value;
        }

        private void FontChange_button_Click(object sender, EventArgs e)    //フォント変更ボタンが押された時
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                cpu_label.Font = fontDialog1.Font;
                cpu_value.Font = fontDialog1.Font;
                mem_label.Font = fontDialog1.Font;
                mem_value.Font = fontDialog1.Font;
                time_label.Font = fontDialog1.Font;
                time_value.Font = fontDialog1.Font;

                set_d.font_name = fontDialog1.Font.Name;
                set_d.font_size = fontDialog1.Font.Size;
                label_setup(set_d);
            }
        }

        private void mem_enable_ckeck_CheckedChanged(object sender, EventArgs e)    //メモリ有効のチェックボックスが変更された時
        {
            if (mem_enable_ckeck.Checked)
            {
                mem_label.Show();
                mem_value.Show();
                set_d.mem_enable = true;
                label_setup(set_d);
            }
            else
            {
                mem_label.Hide();
                mem_value.Hide();
                set_d.mem_enable = false;
                label_setup(set_d);
            }
        }

        private void time_enable_check_CheckedChanged(object sender, EventArgs e)   //時計有効のチェックボックスが変更された時
        {   
            if (time_enable_check.Checked)
            {
                time_label.Show();
                time_value.Show();
                set_d.time_enable = true;
                label_setup(set_d);
            }
            else
            {
                time_label.Hide();
                time_value.Hide();
                set_d.time_enable = false;
                label_setup(set_d);
            }
        }

        private void CPU_enable_chack_CheckedChanged(object sender, EventArgs e)    //CPU有効のチェックボックスが変更された時
        {
            if (CPU_enable_chack.Checked)
            {
                cpu_label.Show();
                cpu_value.Show();
                set_d.cpu_enable = true;
                label_setup(set_d);
            }
            else
            {
                cpu_label.Hide();
                cpu_value.Hide();
                set_d.cpu_enable = false;
                label_setup(set_d);
            }
        }

        private void back_op_check_CheckedChanged(object sender, EventArgs e)   //背景透過のチェックボックスが変更された時
        {
            if (back_op_check.Checked)
            {
                mainwindow.TransparencyKey = mainwindow.BackColor;
                back_color_button.Enabled = false;
                set_d.back = true;
            }
            else
            {
                mainwindow.TransparencyKey = System.Drawing.Color.AliceBlue;
                back_color_button.Enabled = true;
                set_d.back = false;
            }
        }

        private void Top_most_check_CheckedChanged(object sender, EventArgs e)  //常に最前面のチェックボックスが変更された時
        {
            if (Top_most_check.Checked)
            {
                mainwindow.TopMost = true;
                set_d.top = mainwindow.TopMost;
            }
            else
            {
                mainwindow.TopMost = false;
                set_d.top = mainwindow.TopMost;
            }
        }

        private void OK_button_Click(object sender, EventArgs e)    //OKボタンがクリックされた時
        {
            set_d.cp_class(set_true);
            this.Dispose(true);
        }

        private void Cancel_button_Click(object sender, EventArgs e)    //キャンセルボタンがクリックされた時
        {
            label_setup(set_true);
            re_setup();
            this.Dispose(true);
        }

        private void seting_FormClosing(object sender, FormClosingEventArgs e)  //設定ウィンドウの閉じるボタンが押された時
        {
            re_setup();
        }

        private void Color_button_cpu_Click(object sender, EventArgs e)
        {
            // カラーダイアログを表示
	        if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
	        {
                cpu_label.ForeColor = colorDialog1.Color;
                cpu_value.ForeColor = colorDialog1.Color;
                set_d.cpu_mycolor = convert_from_color(colorDialog1.Color);
	        }
        }

        private void Color_button_mem_Click(object sender, EventArgs e)
        {
            // カラーダイアログを表示
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mem_label.ForeColor = colorDialog1.Color;
                mem_value.ForeColor = colorDialog1.Color;
                set_d.mem_mycolor = convert_from_color(colorDialog1.Color);
            }
        }

        private void Color_button_Time_Click(object sender, EventArgs e)
        {
            // カラーダイアログを表示
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                time_label.ForeColor = colorDialog1.Color;
                time_value.ForeColor = colorDialog1.Color;
                set_d.time_mycolor = convert_from_color(colorDialog1.Color);
            }
        }

        private void back_color_button_Click(object sender, EventArgs e)
        {
            // カラーダイアログを表示
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mainwindow.BackColor = colorDialog1.Color;
                set_d.back_mycolor=convert_from_color(colorDialog1.Color);
            }
        }

        private void version_button_Click(object sender, EventArgs e)
        {
            if ((ver == null) || ver.IsDisposed)
            {
                ver = new version();
                ver.Show();
            }
            else
            {
                ver.Activate();
            }

        }
 
    }
}
