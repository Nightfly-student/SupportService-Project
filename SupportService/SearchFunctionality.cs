using SupportLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportService
{
    //Gemaakt door Jelle Toonen// 
    public class SearchFunctionality
    {
        //Moest er een bool van maken want als er niks in de textbox staat moet het de items herladen zodat het op het scherm staat//
        public bool Search(TextBox text, ListView list)
        {
            if (text.Text != "")
            {
                foreach (ListViewItem item in list.Items)
                {
                    if (item.SubItems[1].Text.ToLower().Contains(text.Text.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        list.Items.Remove(item);
                    }
                    if (list.SelectedItems.Count == 1)
                    {
                        list.Focus();
                    }
                }
            }
            else
            {
                list.Items.Clear();
                return false;
            }
            return true;
        }
    }
}
