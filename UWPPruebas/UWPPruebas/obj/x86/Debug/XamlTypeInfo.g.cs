﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace UWPPruebas
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace UWPPruebas.UWPPruebas_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[12];
            _typeNameTable[0] = "UWPPruebas.ViewModel.MainPageVM";
            _typeNameTable[1] = "UWPPruebas.ViewModel.VMBase";
            _typeNameTable[2] = "Object";
            _typeNameTable[3] = "System.Collections.ObjectModel.ObservableCollection`1<UWPPruebas.Model.Persona>";
            _typeNameTable[4] = "System.Collections.ObjectModel.Collection`1<UWPPruebas.Model.Persona>";
            _typeNameTable[5] = "UWPPruebas.Model.Persona";
            _typeNameTable[6] = "String";
            _typeNameTable[7] = "Int32";
            _typeNameTable[8] = "UWPPruebas.ViewModel.DelegateCommand";
            _typeNameTable[9] = "UWPPruebas.MainPage";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[11] = "Windows.UI.Xaml.Controls.UserControl";

            _typeTable = new global::System.Type[12];
            _typeTable[0] = typeof(global::UWPPruebas.ViewModel.MainPageVM);
            _typeTable[1] = typeof(global::UWPPruebas.ViewModel.VMBase);
            _typeTable[2] = typeof(global::System.Object);
            _typeTable[3] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::UWPPruebas.Model.Persona>);
            _typeTable[4] = typeof(global::System.Collections.ObjectModel.Collection<global::UWPPruebas.Model.Persona>);
            _typeTable[5] = typeof(global::UWPPruebas.Model.Persona);
            _typeTable[6] = typeof(global::System.String);
            _typeTable[7] = typeof(global::System.Int32);
            _typeTable[8] = typeof(global::UWPPruebas.ViewModel.DelegateCommand);
            _typeTable[9] = typeof(global::UWPPruebas.MainPage);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[11] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPageVM() { return new global::UWPPruebas.ViewModel.MainPageVM(); }
        private object Activate_3_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::UWPPruebas.Model.Persona>(); }
        private object Activate_4_Collection() { return new global::System.Collections.ObjectModel.Collection<global::UWPPruebas.Model.Persona>(); }
        private object Activate_5_Persona() { return new global::UWPPruebas.Model.Persona(); }
        private object Activate_9_MainPage() { return new global::UWPPruebas.MainPage(); }
        private void VectorAdd_3_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::UWPPruebas.Model.Persona>)instance;
            var newItem = (global::UWPPruebas.Model.Persona)item;
            collection.Add(newItem);
        }
        private void VectorAdd_4_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::UWPPruebas.Model.Persona>)instance;
            var newItem = (global::UWPPruebas.Model.Persona)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  UWPPruebas.ViewModel.MainPageVM
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("UWPPruebas.ViewModel.VMBase"));
                userType.Activator = Activate_0_MainPageVM;
                userType.AddMemberName("Lista");
                userType.AddMemberName("PersonaSeleccionada");
                userType.AddMemberName("BorrarCommand");
                userType.AddMemberName("GuardarCommand");
                userType.AddMemberName("AddNewCommand");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  UWPPruebas.ViewModel.VMBase
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 2:   //  Object
                xamlType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  System.Collections.ObjectModel.ObservableCollection`1<UWPPruebas.Model.Persona>
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<UWPPruebas.Model.Persona>"));
                userType.CollectionAdd = VectorAdd_3_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  System.Collections.ObjectModel.Collection`1<UWPPruebas.Model.Persona>
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_Collection;
                userType.CollectionAdd = VectorAdd_4_Collection;
                xamlType = userType;
                break;

            case 5:   //  UWPPruebas.Model.Persona
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_5_Persona;
                userType.AddMemberName("nombre");
                userType.AddMemberName("apellido");
                userType.AddMemberName("fechaNac");
                userType.AddMemberName("telefono");
                userType.AddMemberName("direccion");
                userType.AddMemberName("ID");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  String
                xamlType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Int32
                xamlType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  UWPPruebas.ViewModel.DelegateCommand
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  UWPPruebas.MainPage
                userType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MainPageVM_Lista(object instance)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            return that.Lista;
        }
        private void set_0_MainPageVM_Lista(object instance, object Value)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            that.Lista = (global::System.Collections.ObjectModel.ObservableCollection<global::UWPPruebas.Model.Persona>)Value;
        }
        private object get_1_Persona_nombre(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.nombre;
        }
        private void set_1_Persona_nombre(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.nombre = (global::System.String)Value;
        }
        private object get_2_Persona_apellido(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.apellido;
        }
        private void set_2_Persona_apellido(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.apellido = (global::System.String)Value;
        }
        private object get_3_Persona_fechaNac(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.fechaNac;
        }
        private void set_3_Persona_fechaNac(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.fechaNac = (global::System.Object)Value;
        }
        private object get_4_Persona_telefono(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.telefono;
        }
        private void set_4_Persona_telefono(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.telefono = (global::System.String)Value;
        }
        private object get_5_Persona_direccion(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.direccion;
        }
        private void set_5_Persona_direccion(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.direccion = (global::System.String)Value;
        }
        private object get_6_Persona_ID(object instance)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            return that.ID;
        }
        private void set_6_Persona_ID(object instance, object Value)
        {
            var that = (global::UWPPruebas.Model.Persona)instance;
            that.ID = (global::System.Int32)Value;
        }
        private object get_7_MainPageVM_PersonaSeleccionada(object instance)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            return that.PersonaSeleccionada;
        }
        private void set_7_MainPageVM_PersonaSeleccionada(object instance, object Value)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            that.PersonaSeleccionada = (global::UWPPruebas.Model.Persona)Value;
        }
        private object get_8_MainPageVM_BorrarCommand(object instance)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            return that.BorrarCommand;
        }
        private object get_9_MainPageVM_GuardarCommand(object instance)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            return that.GuardarCommand;
        }
        private object get_10_MainPageVM_AddNewCommand(object instance)
        {
            var that = (global::UWPPruebas.ViewModel.MainPageVM)instance;
            return that.AddNewCommand;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember xamlMember = null;
            global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "UWPPruebas.ViewModel.MainPageVM.Lista":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.ViewModel.MainPageVM");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "Lista", "System.Collections.ObjectModel.ObservableCollection`1<UWPPruebas.Model.Persona>");
                xamlMember.Getter = get_0_MainPageVM_Lista;
                xamlMember.Setter = set_0_MainPageVM_Lista;
                break;
            case "UWPPruebas.Model.Persona.nombre":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "nombre", "String");
                xamlMember.Getter = get_1_Persona_nombre;
                xamlMember.Setter = set_1_Persona_nombre;
                break;
            case "UWPPruebas.Model.Persona.apellido":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "apellido", "String");
                xamlMember.Getter = get_2_Persona_apellido;
                xamlMember.Setter = set_2_Persona_apellido;
                break;
            case "UWPPruebas.Model.Persona.fechaNac":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "fechaNac", "Object");
                xamlMember.Getter = get_3_Persona_fechaNac;
                xamlMember.Setter = set_3_Persona_fechaNac;
                break;
            case "UWPPruebas.Model.Persona.telefono":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "telefono", "String");
                xamlMember.Getter = get_4_Persona_telefono;
                xamlMember.Setter = set_4_Persona_telefono;
                break;
            case "UWPPruebas.Model.Persona.direccion":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "direccion", "String");
                xamlMember.Getter = get_5_Persona_direccion;
                xamlMember.Setter = set_5_Persona_direccion;
                break;
            case "UWPPruebas.Model.Persona.ID":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.Model.Persona");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "ID", "Int32");
                xamlMember.Getter = get_6_Persona_ID;
                xamlMember.Setter = set_6_Persona_ID;
                break;
            case "UWPPruebas.ViewModel.MainPageVM.PersonaSeleccionada":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.ViewModel.MainPageVM");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "PersonaSeleccionada", "UWPPruebas.Model.Persona");
                xamlMember.Getter = get_7_MainPageVM_PersonaSeleccionada;
                xamlMember.Setter = set_7_MainPageVM_PersonaSeleccionada;
                break;
            case "UWPPruebas.ViewModel.MainPageVM.BorrarCommand":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.ViewModel.MainPageVM");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "BorrarCommand", "UWPPruebas.ViewModel.DelegateCommand");
                xamlMember.Getter = get_8_MainPageVM_BorrarCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "UWPPruebas.ViewModel.MainPageVM.GuardarCommand":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.ViewModel.MainPageVM");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "GuardarCommand", "UWPPruebas.ViewModel.DelegateCommand");
                xamlMember.Getter = get_9_MainPageVM_GuardarCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "UWPPruebas.ViewModel.MainPageVM.AddNewCommand":
                userType = (global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlUserType)GetXamlTypeByName("UWPPruebas.ViewModel.MainPageVM");
                xamlMember = new global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlMember(this, "AddNewCommand", "UWPPruebas.ViewModel.DelegateCommand");
                xamlMember.Getter = get_10_MainPageVM_AddNewCommand;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlSystemBaseType
    {
        global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::UWPPruebas.UWPPruebas_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}
