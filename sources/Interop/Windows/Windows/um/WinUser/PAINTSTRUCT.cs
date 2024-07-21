// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT"]/*' />
public partial struct PAINTSTRUCT
{
    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.hdc"]/*' />
    public HDC hdc;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fErase"]/*' />
    public BOOL fErase;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.rcPaint"]/*' />
    public RECT rcPaint;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fRestore"]/*' />
    public BOOL fRestore;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.fIncUpdate"]/*' />
    public BOOL fIncUpdate;

    /// <include file='PAINTSTRUCT.xml' path='doc/member[@name="PAINTSTRUCT.rgbReserved"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _rgbReserved_e__FixedBuffer rgbReserved;

    /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _rgbReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
