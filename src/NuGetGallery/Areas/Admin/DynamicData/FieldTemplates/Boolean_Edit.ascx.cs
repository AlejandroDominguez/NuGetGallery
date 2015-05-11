﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System;
using System.Collections.Specialized;
using System.Web.DynamicData;
using System.Web.UI;

namespace NuGetGallery.Areas.Admin.DynamicData
{
    public partial class Boolean_EditField : FieldTemplateUserControl
    {
        public override Control DataControl
        {
            get { return CheckBox1; }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);

            object val = FieldValue;
            if (val != null)
            {
                CheckBox1.Checked = (bool)val;
            }
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = CheckBox1.Checked;
        }
    }
}