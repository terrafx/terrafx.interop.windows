// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='INSTALLSPEC.xml' path='doc/member[@name="INSTALLSPEC"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct INSTALLSPEC
{
    /// <include file='INSTALLSPEC.xml' path='doc/member[@name="INSTALLSPEC.AppName"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmgmt.h:39:5)")]
    public _AppName_e__Struct AppName;

    /// <include file='INSTALLSPEC.xml' path='doc/member[@name="INSTALLSPEC.FileExt"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("WCHAR *")]
    public ushort* FileExt;

    /// <include file='INSTALLSPEC.xml' path='doc/member[@name="INSTALLSPEC.ProgId"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("WCHAR *")]
    public ushort* ProgId;

    /// <include file='INSTALLSPEC.xml' path='doc/member[@name="INSTALLSPEC.COMClass"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmgmt.h:46:5)")]
    public _COMClass_e__Struct COMClass;

    /// <include file='_AppName_e__Struct.xml' path='doc/member[@name="_AppName_e__Struct"]/*' />
    public unsafe partial struct _AppName_e__Struct
    {
        /// <include file='_AppName_e__Struct.xml' path='doc/member[@name="_AppName_e__Struct.Name"]/*' />
        [NativeTypeName("WCHAR *")]
        public ushort* Name;

        /// <include file='_AppName_e__Struct.xml' path='doc/member[@name="_AppName_e__Struct.GPOId"]/*' />
        public Guid GPOId;
    }

    /// <include file='_COMClass_e__Struct.xml' path='doc/member[@name="_COMClass_e__Struct"]/*' />
    public partial struct _COMClass_e__Struct
    {
        /// <include file='_COMClass_e__Struct.xml' path='doc/member[@name="_COMClass_e__Struct.Clsid"]/*' />
        public Guid Clsid;

        /// <include file='_COMClass_e__Struct.xml' path='doc/member[@name="_COMClass_e__Struct.ClsCtx"]/*' />
        [NativeTypeName("DWORD")]
        public uint ClsCtx;
    }
}
