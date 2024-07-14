// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW"]/*' />
[NativeTypeName("struct tagMONITORINFOEXW : tagMONITORINFO")]
[NativeInheritance("tagMONITORINFO")]
public partial struct MONITORINFOEXW
{
    public MONITORINFO Base;

    /// <include file='MONITORINFOEXW.xml' path='doc/member[@name="MONITORINFOEXW.szDevice"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szDevice_e__FixedBuffer szDevice;

    /// <include file='_szDevice_e__FixedBuffer.xml' path='doc/member[@name="_szDevice_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _szDevice_e__FixedBuffer
    {
        public char e0;
    }
}
