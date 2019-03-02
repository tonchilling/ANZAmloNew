﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ANZ2AMLO.Forms
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.GetEnumerable += pLinqInstantFeedbackSource1_GetEnumerable;
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.DismissEnumerable += pLinqInstantFeedbackSource1_DismissEnumerable;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Instantiate a new DataContext
            ANZ2AMLO.Contexts.AnzContextsDataContext dataContext = new ANZ2AMLO.Contexts.AnzContextsDataContext();
            // Assign a queryable source to the PLinqInstantFeedbackSource
            e.Source = dataContext.unloadings;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_DismissEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Dispose of the DataContext
            ((ANZ2AMLO.Contexts.AnzContextsDataContext)e.Tag).Dispose();
        }
    }
}