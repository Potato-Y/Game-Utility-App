﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameUtilityApp.Function.KartRider.Nickname_Tracker
{
    public delegate void DataGetEventHandler2(string type, string value); //delegate 선언
    public partial class Add_user_nickname : Form
    {
        public Add_user_nickname()
        {
            InitializeComponent();
        }

        public DataGetEventHandler2 DataSendEvent;
    }
}