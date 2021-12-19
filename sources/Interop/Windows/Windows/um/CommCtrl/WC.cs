// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class WC
{
    [NativeTypeName("#define WC_HEADERA \"SysHeader32\"")]
    public static ReadOnlySpan<byte> WC_HEADERA => new byte[] { 0x53, 0x79, 0x73, 0x48, 0x65, 0x61, 0x64, 0x65, 0x72, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_HEADERW L\"SysHeader32\"")]
    public const string WC_HEADERW = "SysHeader32";

    [NativeTypeName("#define WC_HEADER WC_HEADERW")]
    public const string WC_HEADER = "SysHeader32";

    [NativeTypeName("#define WC_LINK L\"SysLink\"")]
    public const string WC_LINK = "SysLink";

    [NativeTypeName("#define WC_LISTVIEWA \"SysListView32\"")]
    public static ReadOnlySpan<byte> WC_LISTVIEWA => new byte[] { 0x53, 0x79, 0x73, 0x4C, 0x69, 0x73, 0x74, 0x56, 0x69, 0x65, 0x77, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_LISTVIEWW L\"SysListView32\"")]
    public const string WC_LISTVIEWW = "SysListView32";

    [NativeTypeName("#define WC_LISTVIEW WC_LISTVIEWW")]
    public const string WC_LISTVIEW = "SysListView32";

    [NativeTypeName("#define WC_TREEVIEWA \"SysTreeView32\"")]
    public static ReadOnlySpan<byte> WC_TREEVIEWA => new byte[] { 0x53, 0x79, 0x73, 0x54, 0x72, 0x65, 0x65, 0x56, 0x69, 0x65, 0x77, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_TREEVIEWW L\"SysTreeView32\"")]
    public const string WC_TREEVIEWW = "SysTreeView32";

    [NativeTypeName("#define WC_TREEVIEW WC_TREEVIEWW")]
    public const string WC_TREEVIEW = "SysTreeView32";

    [NativeTypeName("#define WC_COMBOBOXEXW L\"ComboBoxEx32\"")]
    public const string WC_COMBOBOXEXW = "ComboBoxEx32";

    [NativeTypeName("#define WC_COMBOBOXEXA \"ComboBoxEx32\"")]
    public static ReadOnlySpan<byte> WC_COMBOBOXEXA => new byte[] { 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x42, 0x6F, 0x78, 0x45, 0x78, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_COMBOBOXEX WC_COMBOBOXEXW")]
    public const string WC_COMBOBOXEX = "ComboBoxEx32";

    [NativeTypeName("#define WC_TABCONTROLA \"SysTabControl32\"")]
    public static ReadOnlySpan<byte> WC_TABCONTROLA => new byte[] { 0x53, 0x79, 0x73, 0x54, 0x61, 0x62, 0x43, 0x6F, 0x6E, 0x74, 0x72, 0x6F, 0x6C, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_TABCONTROLW L\"SysTabControl32\"")]
    public const string WC_TABCONTROLW = "SysTabControl32";

    [NativeTypeName("#define WC_TABCONTROL WC_TABCONTROLW")]
    public const string WC_TABCONTROL = "SysTabControl32";

    [NativeTypeName("#define WC_IPADDRESSW L\"SysIPAddress32\"")]
    public const string WC_IPADDRESSW = "SysIPAddress32";

    [NativeTypeName("#define WC_IPADDRESSA \"SysIPAddress32\"")]
    public static ReadOnlySpan<byte> WC_IPADDRESSA => new byte[] { 0x53, 0x79, 0x73, 0x49, 0x50, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x33, 0x32, 0x00 };

    [NativeTypeName("#define WC_IPADDRESS WC_IPADDRESSW")]
    public const string WC_IPADDRESS = "SysIPAddress32";

    [NativeTypeName("#define WC_PAGESCROLLERW L\"SysPager\"")]
    public const string WC_PAGESCROLLERW = "SysPager";

    [NativeTypeName("#define WC_PAGESCROLLERA \"SysPager\"")]
    public static ReadOnlySpan<byte> WC_PAGESCROLLERA => new byte[] { 0x53, 0x79, 0x73, 0x50, 0x61, 0x67, 0x65, 0x72, 0x00 };

    [NativeTypeName("#define WC_PAGESCROLLER WC_PAGESCROLLERW")]
    public const string WC_PAGESCROLLER = "SysPager";

    [NativeTypeName("#define WC_NATIVEFONTCTLW L\"NativeFontCtl\"")]
    public const string WC_NATIVEFONTCTLW = "NativeFontCtl";

    [NativeTypeName("#define WC_NATIVEFONTCTLA \"NativeFontCtl\"")]
    public static ReadOnlySpan<byte> WC_NATIVEFONTCTLA => new byte[] { 0x4E, 0x61, 0x74, 0x69, 0x76, 0x65, 0x46, 0x6F, 0x6E, 0x74, 0x43, 0x74, 0x6C, 0x00 };

    [NativeTypeName("#define WC_NATIVEFONTCTL WC_NATIVEFONTCTLW")]
    public const string WC_NATIVEFONTCTL = "NativeFontCtl";

    [NativeTypeName("#define WC_BUTTONA \"Button\"")]
    public static ReadOnlySpan<byte> WC_BUTTONA => new byte[] { 0x42, 0x75, 0x74, 0x74, 0x6F, 0x6E, 0x00 };

    [NativeTypeName("#define WC_BUTTONW L\"Button\"")]
    public const string WC_BUTTONW = "Button";

    [NativeTypeName("#define WC_BUTTON WC_BUTTONW")]
    public const string WC_BUTTON = "Button";

    [NativeTypeName("#define WC_STATICA \"Static\"")]
    public static ReadOnlySpan<byte> WC_STATICA => new byte[] { 0x53, 0x74, 0x61, 0x74, 0x69, 0x63, 0x00 };

    [NativeTypeName("#define WC_STATICW L\"Static\"")]
    public const string WC_STATICW = "Static";

    [NativeTypeName("#define WC_STATIC WC_STATICW")]
    public const string WC_STATIC = "Static";

    [NativeTypeName("#define WC_EDITA \"Edit\"")]
    public static ReadOnlySpan<byte> WC_EDITA => new byte[] { 0x45, 0x64, 0x69, 0x74, 0x00 };

    [NativeTypeName("#define WC_EDITW L\"Edit\"")]
    public const string WC_EDITW = "Edit";

    [NativeTypeName("#define WC_EDIT WC_EDITW")]
    public const string WC_EDIT = "Edit";

    [NativeTypeName("#define WC_LISTBOXA \"ListBox\"")]
    public static ReadOnlySpan<byte> WC_LISTBOXA => new byte[] { 0x4C, 0x69, 0x73, 0x74, 0x42, 0x6F, 0x78, 0x00 };

    [NativeTypeName("#define WC_LISTBOXW L\"ListBox\"")]
    public const string WC_LISTBOXW = "ListBox";

    [NativeTypeName("#define WC_LISTBOX WC_LISTBOXW")]
    public const string WC_LISTBOX = "ListBox";

    [NativeTypeName("#define WC_COMBOBOXA \"ComboBox\"")]
    public static ReadOnlySpan<byte> WC_COMBOBOXA => new byte[] { 0x43, 0x6F, 0x6D, 0x62, 0x6F, 0x42, 0x6F, 0x78, 0x00 };

    [NativeTypeName("#define WC_COMBOBOXW L\"ComboBox\"")]
    public const string WC_COMBOBOXW = "ComboBox";

    [NativeTypeName("#define WC_COMBOBOX WC_COMBOBOXW")]
    public const string WC_COMBOBOX = "ComboBox";

    [NativeTypeName("#define WC_SCROLLBARA \"ScrollBar\"")]
    public static ReadOnlySpan<byte> WC_SCROLLBARA => new byte[] { 0x53, 0x63, 0x72, 0x6F, 0x6C, 0x6C, 0x42, 0x61, 0x72, 0x00 };

    [NativeTypeName("#define WC_SCROLLBARW L\"ScrollBar\"")]
    public const string WC_SCROLLBARW = "ScrollBar";

    [NativeTypeName("#define WC_SCROLLBAR WC_SCROLLBARW")]
    public const string WC_SCROLLBAR = "ScrollBar";
}
