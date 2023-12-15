// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_ADAPTER_SERIAL_NUMBER
{
    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.SerialNumber"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    /// <include file='_SerialNumber_e__FixedBuffer.xml' path='doc/member[@name="_SerialNumber_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public char e0;
    }
}
