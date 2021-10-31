// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct INSTALLSPEC
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmgmt.h:39:5)")]
        public _AppName_e__Struct AppName;

        [FieldOffset(0)]
        [NativeTypeName("WCHAR *")]
        public ushort* FileExt;

        [FieldOffset(0)]
        [NativeTypeName("WCHAR *")]
        public ushort* ProgId;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/appmgmt.h:46:5)")]
        public _COMClass_e__Struct COMClass;

        public unsafe partial struct _AppName_e__Struct
        {
            [NativeTypeName("WCHAR *")]
            public ushort* Name;

            public Guid GPOId;
        }

        public partial struct _COMClass_e__Struct
        {
            public Guid Clsid;

            [NativeTypeName("DWORD")]
            public uint ClsCtx;
        }
    }
}
