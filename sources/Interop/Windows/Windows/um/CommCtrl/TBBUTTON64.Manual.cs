// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct TBBUTTON64
{
    public int iBitmap;

    public int idCommand;

    public byte fsState;

    public byte fsStyle;

    [NativeTypeName("BYTE[6]")]
    public _bReserved_e__FixedBuffer bReserved;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwData;

    [NativeTypeName("INT_PTR")]
    public nint iString;

    [InlineArray(6)]
    public partial struct _bReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
