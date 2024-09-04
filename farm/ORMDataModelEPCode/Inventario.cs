using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace farm.el_porvenir
{

    public partial class Inventario
    {
        public Inventario(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
