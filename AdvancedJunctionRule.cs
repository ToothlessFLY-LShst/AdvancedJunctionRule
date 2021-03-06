﻿using AdvancedJunctionRule.Util;
using ColossalFramework.UI;
using ICities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedJunctionRule
{
    public class AdvancedJunctionRule : IUserMod
    {
        public static bool IsEnabled = false;
        public static int language_idex = 0;

        public string Name
        {
            get { return "Advanced Junction Rule"; }
        }

        public string Description
        {
            get { return "Add more advanced junction rules for Left and Uturn"; }
        }

        public void OnEnabled()
        {
            IsEnabled = true;
            FileStream fs = File.Create("AdvancedJunctionRule.txt");
            fs.Close();
        }

        public void OnDisabled()
        {
            IsEnabled = false;
        }
    }
}
