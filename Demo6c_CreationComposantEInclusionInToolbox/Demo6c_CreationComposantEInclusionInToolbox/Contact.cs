using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Demo6c_CreationComposantEInclusionInToolbox
{
    public partial class Contact : Component
    {
        public Contact()
        {
            InitializeComponent();
        }

        public Contact(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
