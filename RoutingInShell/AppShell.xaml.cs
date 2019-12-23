using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RoutingInShell
{
    public partial class AppShell : Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            this.Navigating += AppShell_Navigating;
        }

        private void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            Debug.WriteLine("Target:-\n" + e.Target.Location.OriginalString + "\n");
        }
    }
}
