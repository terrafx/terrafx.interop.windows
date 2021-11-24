// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public partial struct REPARSE_GUID_DATA_BUFFER
{
    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    [NativeTypeName("WORD")]
    public ushort ReparseDataLength;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    public Guid ReparseGuid;

    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:14636:5)")]
    public _GenericReparseBuffer_e__Struct GenericReparseBuffer;

    public unsafe partial struct _GenericReparseBuffer_e__Struct
    {
        [NativeTypeName("BYTE [1]")]
        public fixed byte DataBuffer[1];
    }
}
