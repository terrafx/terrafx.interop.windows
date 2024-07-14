// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ByteOrder.xml' path='doc/member[@name="ByteOrder"]/*' />
public enum ByteOrder
{
    /// <include file='ByteOrder.xml' path='doc/member[@name="ByteOrder.ByteOrder_LittleEndian"]/*' />
    ByteOrder_LittleEndian = 0,

    /// <include file='ByteOrder.xml' path='doc/member[@name="ByteOrder.ByteOrder_BigEndian"]/*' />
    ByteOrder_BigEndian = 1,
}
