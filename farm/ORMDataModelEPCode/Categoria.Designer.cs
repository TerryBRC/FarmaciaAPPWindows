﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace farm.el_porvenir
{

    [Persistent(@"categoria")]
    public partial class Categoria : XPLiteObject
    {
        int fId_categoria;
        [Key(true)]
        [Persistent(@"id_categoria")]
        public int Id_categoria
        {
            get { return fId_categoria; }
            set { SetPropertyValue<int>(nameof(Id_categoria), ref fId_categoria, value); }
        }
        string fNombre;
        [Size(45)]
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fDescripcion;
        [Size(255)]
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
    }

}
