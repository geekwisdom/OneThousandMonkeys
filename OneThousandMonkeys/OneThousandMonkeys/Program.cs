/********************************************************************************
File: Program.cs
@(#) Purpose: This is the main instance for the One Thousand Monkeys.
@(#) I created this program as a result of watching Amanda Lang's
@(#)  Amanda Lang: Suing internet pirates harsh, but it's the right thing to do
@(#) See: https://blog.geekwisdom.org/2019/05/the-most-dangerous-software-on-internet.html
**********************************************************************************
Written By: Brad Detchevery
Created: May 5th, 2019
********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneThousandMonkeys
{
    static class Program
    {
        
        /// <summary>
        /// The Infite Monkey Theorem using Markov Chains ! W00t
        /// </summary>
        [STAThread]
        static void Main()
        {
                    Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
