// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA
{
    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.TaskIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint TaskIndex;

    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.ClassName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _ClassName_e__FixedBuffer ClassName;

    /// <include file='MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.xml' path='doc/member[@name="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA.BasePriority"]/*' />
    [NativeTypeName("LONG")]
    public int BasePriority;

    /// <include file='_ClassName_e__FixedBuffer.xml' path='doc/member[@name="_ClassName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _ClassName_e__FixedBuffer
    {
        public char e0;
    }
}
