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
    public partial class Monitor : Form
    {
        private Point mousePoint;
        private CPU cpu_ins =new CPU();
        private Memory memory_ins = new Memory();

        seting set=null; // 子ﾌｫｰﾑ
        Label CPU_label = new Label();
        Label CPU_value = new Label();
        Label MEM_label = new Label();
        Label MEM_value = new Label();
        Label Time_label = new Label();
        Label Time_value = new Label();

        seting_data set_data = new seting_data();

        public Monitor()
        {
            InitializeComponent();
            Setup();
        }

        public void Setup()
        {
            // ラベルやボタンのマウス移動(ドラッグ)でもフォームが動くように設定
            setting_file_eixst();
            set_read();

            form_setup();
            label_setup();
            cpu_label_setup();
            mem_label_setup();
            time_label_setup();
            re_setup();
            label_setup();
            mousecontrol(set_data.move);
            move_swich.Checked = !(set_data.move);
            appear();
        }

        public void form_setup()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.DesktopLocation = new Point(set_data.x, set_data.y);
        }

        public void label_setup()
        {
            int n=0;
            int Row=0;

            if (set_data.cpu_enable)
            {
                Row++;
            }

            if (set_data.mem_enable)
            {
                Row++;
            }

            if (set_data.time_enable)
            {
                Row++;
            }

            tableLayoutPanel1.RowCount = Row;

            if (set_data.cpu_enable)
            {
                tableLayoutPanel1.Controls.Add(CPU_label, 0, n);
                tableLayoutPanel1.Controls.Add(CPU_value, 1, n);
                n++;
            }

            if (set_data.mem_enable)
            {
                tableLayoutPanel1.Controls.Add(MEM_label, 0, n);
                tableLayoutPanel1.Controls.Add(MEM_value, 1, n);
                n++;
            }

            if (set_data.time_enable)
            {
                tableLayoutPanel1.Controls.Add(Time_label, 0, n);
                tableLayoutPanel1.Controls.Add(Time_value, 1, n);
            }

            this.Width = tableLayoutPanel1.Width;
            this.Height = tableLayoutPanel1.Height;
        }
        public void cpu_label_setup()  //CPU使用率
        {

            CPU_label.Text = "CPU:";
            CPU_value.Text =(cpu_ins.get_usege_all()).ToString();
            CPU_label.AutoSize = true;
            CPU_value.AutoSize = true;
            CPU_label.Hide();
            CPU_value.Hide();
            this.CPU_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                
        }

        public void mem_label_setup() //メモリ使用率
        {

            MEM_label.Text = "MEM:";
            MEM_value.Text = String.Format("{0}[{1}]", memory_ins.get_mem(), memory_ins.scale);
            MEM_label.AutoSize = true;
            MEM_value.AutoSize = true;
            MEM_label.Hide();
            MEM_value.Hide();
            this.MEM_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }

        public void time_label_setup() //メモリ使用率
        {

            Time_label.Text = "Time:";
            Time_value.Text = DateTime.Now.ToString("HH:mm:ss");
            Time_label.AutoSize = true;
            Time_value.AutoSize = true;
            Time_label.Hide();
            Time_value.Hide();
            this.Time_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        }
        public void appear() //表示
        {
            if (set_data.cpu_enable)
            {
                CPU_label.Show();
                CPU_value.Show();
            }

            if(set_data.mem_enable)
            {
                MEM_label.Show();
                MEM_value.Show();
            }
            if(set_data.time_enable)
            {
                Time_label.Show();
                Time_value.Show();
            }
        }
        private void re_setup() //set_dataを元にメインウィンドウのプロパティを設定する
        {
            this.Opacity = (double)set_data.mainform_opt / 100.00;
            this.TopMost = set_data.top;
            this.BackColor = convert_from_mycolor(set_data.back_mycolor);

            CPU_label.Font = new Font(set_data.font_name, set_data.font_size);
            CPU_value.Font = new Font(set_data.font_name, set_data.font_size);
            MEM_label.Font = new Font(set_data.font_name, set_data.font_size);
            MEM_value.Font = new Font(set_data.font_name, set_data.font_size);
            Time_label.Font = new Font(set_data.font_name, set_data.font_size);
            Time_value.Font = new Font(set_data.font_name, set_data.font_size);

            CPU_label.ForeColor = convert_from_mycolor(set_data.cpu_mycolor);
            CPU_value.ForeColor = convert_from_mycolor(set_data.cpu_mycolor);
            MEM_label.ForeColor = convert_from_mycolor(set_data.mem_mycolor);
            MEM_value.ForeColor = convert_from_mycolor(set_data.mem_mycolor);
            Time_label.ForeColor = convert_from_mycolor(set_data.time_mycolor);
            Time_value.ForeColor = convert_from_mycolor(set_data.time_mycolor);

            if (set_data.cpu_enable)    //CPUラベル
            {
                CPU_label.Show();
                CPU_value.Show();
            }
            else
            {
                CPU_label.Hide();
                CPU_value.Hide();
            }

            if (set_data.mem_enable)    //MEMラベル
            {
                MEM_label.Show();
                MEM_value.Show();
            }
            else
            {
                MEM_label.Hide();
                MEM_value.Hide();
            }

            if (set_data.time_enable)   //Timeラベル
            {
                Time_label.Show();
                Time_value.Show();
            }
            else
            {
                Time_label.Hide();
                Time_value.Hide();
            }

            if (set_data.back)  //背景透過
            {
                this.TransparencyKey = BackColor;
            }
            else
            {
                this.TransparencyKey = System.Drawing.Color.AliceBlue;
            }
        }

        public Color convert_from_mycolor(my_color co) {        //RGBからcolor構造体へ変換
            Color output;
            output = Color.FromArgb(co.red, co.green, co.blue);
            return output;
        }


        public void mousecontrol(bool mouse)
        {
            if (mouse)
            {
                this.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                this.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                CPU_label.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                CPU_label.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                CPU_value.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                CPU_value.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                MEM_label.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                MEM_label.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                MEM_value.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                MEM_value.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                Time_label.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                Time_label.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                Time_value.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                Time_value.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
                tableLayoutPanel1.MouseDown += new MouseEventHandler(this.Monitor_MouseDown);
                tableLayoutPanel1.MouseMove += new MouseEventHandler(this.Monitor_MouseMove);
            }
            else
            {
                this.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                this.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                CPU_label.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                CPU_label.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                CPU_value.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                CPU_value.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                MEM_label.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                MEM_label.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                MEM_value.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                MEM_value.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                Time_label.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                Time_label.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                Time_value.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                Time_value.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
                tableLayoutPanel1.MouseDown -= new MouseEventHandler(this.Monitor_MouseDown);
                tableLayoutPanel1.MouseMove -= new MouseEventHandler(this.Monitor_MouseMove);
            }
        }

        //xmlに設定ファイルを保存するメソッド
        public void set_save()
        {
            set_data.x = this.Location.X;
            set_data.y = this.Location.Y;
            //保存先のファイル名
            string fileName = @"settings.config";

            //＜XMLファイルに書き込む＞
            //XmlSerializerオブジェクトを作成
            //書き込むオブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer1 =
                new System.Xml.Serialization.XmlSerializer(typeof(seting_data));
            //ファイルを開く（UTF-8 BOM無し）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));
            //シリアル化し、XMLファイルに保存する
            serializer1.Serialize(sw, set_data);
            //閉じる
            sw.Close();
        }

        public void set_read()  //設定ファイルから値を設定
        {
            string fileName = @"settings.config";

            //＜XMLファイルから読み込む＞
            //XmlSerializerオブジェクトの作成
            System.Xml.Serialization.XmlSerializer serializer2 = new System.Xml.Serialization.XmlSerializer(typeof(seting_data));
            //ファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(fileName, new System.Text.UTF8Encoding(false));
            //XMLファイルから読み込み、逆シリアル化する
            set_data = (seting_data)serializer2.Deserialize(sr);
            //閉じる
            sr.Close();
        }

        public void setting_file_eixst()    //設定ファイルが存在するかどうか.存在しなかった場合は作る.
        {
            if (!(System.IO.File.Exists("settings.config")))
            {
                MessageBox.Show("設定ファイルが見つからないので、デフォルトの設定で起動します。", "情報", System.Windows.Forms.MessageBoxButtons.OK);
                set_save();
            }
        }


        //-----------------------------------以下イベント--------------------------------

        public void Monitor_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //左クリックの場合のみ位置を記憶
                mousePoint = new Point(-e.X, -e.Y);
            }
        }

        // マウスの移動
        public void Monitor_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //フォームの移動
                this.Left += e.X + mousePoint.X;
                this.Top += e.Y + mousePoint.Y;
            }
        }

        private void End_ToolStripMenuItem_Click(object sender, EventArgs e) //タスクバーから終了
        {
            notifyIcon1.Visible = false;
            set_save();
            Application.Exit();
        }

        private void setting_toolStripMenuItem1_Click(object sender, EventArgs e)//設定ウィンドウ表示
        {
            if ((set == null) || set.IsDisposed)
            {
                set = new seting(set_data,this,tableLayoutPanel1,CPU_label,CPU_value,MEM_label,MEM_value,Time_label,Time_value);
                set.Show();
            }
            else
            {
                set.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CPU_value.Text = cpu_ins.get_usege_all().ToString();
            MEM_value.Text = String.Format("{0}[{1}]", memory_ins.get_mem(), memory_ins.scale);
            Time_value.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void move_swich_Click(object sender, EventArgs e) //移動
        {
            if (move_swich.Checked)
            {
                mousecontrol(false);
                move_swich.Checked = true;
                set_data.move = false;
            }
            else
            {
                mousecontrol(true);
                move_swich.Checked = false;
                set_data.move = true;
            }
        }

        private void Monitor_MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void Top_most_menu_Click(object sender, EventArgs e)
        {
            if (Top_most_menu.Checked)
            {
                this.TopMost = true;
                set_data.top = true;
                Top_most_menu.Checked = true;
                this.Activate();
            }
            else
            {
                this.TopMost = false;
                set_data.top = false;
                Top_most_menu.Checked = false;
                this.Activate();
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Top_most_menu.Checked = this.TopMost;
        }
    }
}
