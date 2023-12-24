// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE"]/*' />
public partial struct FONTSIGNATURE
{
    /// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE.fsUsb"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _fsUsb_e__FixedBuffer fsUsb;

    /// <include file='FONTSIGNATURE.xml' path='doc/member[@name="FONTSIGNATURE.fsCsb"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _fsCsb_e__FixedBuffer fsCsb;

    /// <include file='_fsUsb_e__FixedBuffer.xml' path='doc/member[@name="_fsUsb_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _fsUsb_e__FixedBuffer
    {
        public uint e0;
    }

    /// <include file='_fsCsb_e__FixedBuffer.xml' path='doc/member[@name="_fsCsb_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _fsCsb_e__FixedBuffer
    {
        public uint e0;
    }
}
