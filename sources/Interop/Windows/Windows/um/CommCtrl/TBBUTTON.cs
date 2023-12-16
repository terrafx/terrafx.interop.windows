// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON"]/*' />
public partial struct TBBUTTON
{
    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.iBitmap"]/*' />
    public int iBitmap;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.idCommand"]/*' />
    public int idCommand;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.fsState"]/*' />
    public byte fsState;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.fsStyle"]/*' />
    public byte fsStyle;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.bReserved"]/*' />
    [NativeTypeName("BYTE[6]")]
    public _bReserved_e__FixedBuffer bReserved;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.dwData"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwData;

    /// <include file='TBBUTTON.xml' path='doc/member[@name="TBBUTTON.iString"]/*' />
    [NativeTypeName("INT_PTR")]
    public nint iString;

    /// <include file='_bReserved_e__FixedBuffer.xml' path='doc/member[@name="_bReserved_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _bReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
