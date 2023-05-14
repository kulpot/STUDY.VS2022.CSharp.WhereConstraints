using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereConstraints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    /*public class MyClass<T> where T : Form, new() //struct ICloneable, new() 
    {
        public T GetInstance()
        {
            return new T();
        }
    }*/
    public class MyClass//apply constrain through a method
    {
        public T GetInstance<T>() where T : Form, new()
        {
            return new T();
        }
    }
}
