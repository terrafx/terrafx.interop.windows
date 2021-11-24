// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct IMAGE_LINENUMBER
{
    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:19349:5)")]
    public _Type_e__Union Type;

    [NativeTypeName("WORD")]
    public ushort Linenumber;

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _Type_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint SymbolTableIndex;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualAddress;
    }
}
