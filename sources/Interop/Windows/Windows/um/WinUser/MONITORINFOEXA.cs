// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MONITORINFOEXA.xml' path='doc/member[@name="MONITORINFOEXA"]/*' />
[NativeTypeName("struct tagMONITORINFOEXA : tagMONITORINFO")]
[NativeInheritance("tagMONITORINFO")]
public partial struct MONITORINFOEXA
{
    public MONITORINFO Base;

    /// <include file='MONITORINFOEXA.xml' path='doc/member[@name="MONITORINFOEXA.szDevice"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szDevice_e__FixedBuffer szDevice;

    /// <include file='_szDevice_e__FixedBuffer.xml' path='doc/member[@name="_szDevice_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDevice_e__FixedBuffer
    {
        public sbyte e0;
    }
}
