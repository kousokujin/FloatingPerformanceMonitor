using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace FloatingPerformanceMonitor
{
    public struct my_color
    {
        public int red;
        public int blue;
        public int green;

        public my_color(int r, int g, int b)
        {
            red = r;
            green = g;
            blue = b;
        }
    }

    public class CPU
    {
        public PerformanceCounter pc_all = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        public int get_usege_all()
        {
            float useage = this.pc_all.NextValue();
            int output = sisya(useage);
            return output;
        }

        static int sisya(float input) //四捨五入-->int整数
        {
            int output = (int)(input + 0.5);
            return output;
        }
    }

    public class Memory
    {
        public PerformanceCounter mem_ins = new PerformanceCounter();
        public String scale;

        public Memory()
        {
            mem_ins = new PerformanceCounter("Process", "Working Set", "_Total");
            scale = "Bytes";
        }

        public float get_mem_byte()
        {
            float mem = mem_ins.NextValue();
            return (mem);
        }

        public float get_mem()
        {
            float mem = get_mem_byte();
            if (mem >= 1000000000)
            {
                mem = (float)Math.Round(mem / 100000000);
                mem = mem / 10;
                scale = "GB";
            }
            if(mem<1000000000 && mem>=1000000)
            {
                mem = (float)Math.Round(mem / 100000);
                mem = mem / 10;
                scale = "MB";
            }
            if (mem < 1000000 && mem >= 1000)
            {
                mem = (float)Math.Round(mem / 100);
                mem = mem / 10;
                scale = "KB";
            }
            return mem;
        }
    }

    public class seting_data
    {

        public int x = 100;     //mainwindowの座標
        public int y = 100;

        public int mainform_opt = 100;  //透明度

        public bool cpu_enable = true;     //CPU使用率
        public bool mem_enable = true;     //メモリ使用率
        public bool time_enable = true;    //時計

        public my_color cpu_mycolor = new my_color(80,73,203);
        public my_color mem_mycolor = new my_color(34,195,80);
        public my_color time_mycolor = new my_color(255,94,25);
        public my_color back_mycolor = new my_color(255,255,255);

        public bool move = true;           //移動

        public bool back = false;        //背景透明化
        public bool top = false;        //常に最前面

        public string font_name = "MS P ゴシック";   //フォント
        public float font_size = 20;

        public void cp_class(seting_data data)  //引数のオブジェクトにフィールド変数をコピー
        {
            data.x = x;
            data.y = y;
            data.mainform_opt = mainform_opt;
            data.cpu_enable = cpu_enable;
            data.mem_enable = mem_enable;
            data.time_enable = time_enable;
            data.cpu_mycolor = cpu_mycolor;
            data.mem_mycolor = mem_mycolor;
            data.time_mycolor = time_mycolor;
            data.back_mycolor = back_mycolor;
            data.move = move;
            data.back = back;
            data.top = top;
            data.font_name = font_name;
            data.font_size = font_size;
        }
    }
}
