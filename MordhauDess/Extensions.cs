using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordhauDess
{
    // Copypaste from overflow
    public static class MyExtensions
    {
        //What is your style
        public static void SetStyle(this IContainer container, MetroForm ownerForm, MetroColorStyle FormStyle)
        {
            if (container == null)
            {
                container = new System.ComponentModel.Container();
            }
            var manager = new MetroFramework.Components.MetroStyleManager(container);
            manager.Owner = ownerForm;
            container.SetDefaultStyle(ownerForm, FormStyle);


        }
        public static void SetDefaultStyle(this IContainer contr, MetroForm owner, MetroColorStyle style)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Style = style;
            owner.Style = style;
        }
        public static void SetDefaultTheme(this IContainer contr, MetroForm owner, MetroThemeStyle thme)
        {
            MetroStyleManager manager = FindManager(contr, owner);
            manager.Theme = thme;
        }
        private static MetroStyleManager FindManager(IContainer contr, MetroForm owner)
        {
            MetroStyleManager manager = null;
            foreach (IComponent item in contr.Components)
            {
                if (((MetroStyleManager)item).Owner == owner)
                {
                    manager = (MetroStyleManager)item;
                }
            }
            return manager;
        }
    }
}
