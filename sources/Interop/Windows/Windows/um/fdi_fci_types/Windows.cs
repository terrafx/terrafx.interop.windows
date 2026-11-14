// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.INCLUDED_TYPES_FCI_FDI"]/*' />
    [NativeTypeName("#define INCLUDED_TYPES_FCI_FDI 1")]
    public const int INCLUDED_TYPES_FCI_FDI = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompMASK_TYPE"]/*' />
    [NativeTypeName("#define tcompMASK_TYPE 0x000F")]
    public const int tcompMASK_TYPE = 0x000F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompTYPE_NONE"]/*' />
    [NativeTypeName("#define tcompTYPE_NONE 0x0000")]
    public const int tcompTYPE_NONE = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompTYPE_MSZIP"]/*' />
    [NativeTypeName("#define tcompTYPE_MSZIP 0x0001")]
    public const int tcompTYPE_MSZIP = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompTYPE_QUANTUM"]/*' />
    [NativeTypeName("#define tcompTYPE_QUANTUM 0x0002")]
    public const int tcompTYPE_QUANTUM = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompTYPE_LZX"]/*' />
    [NativeTypeName("#define tcompTYPE_LZX 0x0003")]
    public const int tcompTYPE_LZX = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompBAD"]/*' />
    [NativeTypeName("#define tcompBAD 0x000F")]
    public const int tcompBAD = 0x000F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompMASK_LZX_WINDOW"]/*' />
    [NativeTypeName("#define tcompMASK_LZX_WINDOW 0x1F00")]
    public const int tcompMASK_LZX_WINDOW = 0x1F00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompLZX_WINDOW_LO"]/*' />
    [NativeTypeName("#define tcompLZX_WINDOW_LO 0x0F00")]
    public const int tcompLZX_WINDOW_LO = 0x0F00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompLZX_WINDOW_HI"]/*' />
    [NativeTypeName("#define tcompLZX_WINDOW_HI 0x1500")]
    public const int tcompLZX_WINDOW_HI = 0x1500;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompSHIFT_LZX_WINDOW"]/*' />
    [NativeTypeName("#define tcompSHIFT_LZX_WINDOW 8")]
    public const int tcompSHIFT_LZX_WINDOW = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompMASK_QUANTUM_LEVEL"]/*' />
    [NativeTypeName("#define tcompMASK_QUANTUM_LEVEL 0x00F0")]
    public const int tcompMASK_QUANTUM_LEVEL = 0x00F0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompQUANTUM_LEVEL_LO"]/*' />
    [NativeTypeName("#define tcompQUANTUM_LEVEL_LO 0x0010")]
    public const int tcompQUANTUM_LEVEL_LO = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompQUANTUM_LEVEL_HI"]/*' />
    [NativeTypeName("#define tcompQUANTUM_LEVEL_HI 0x0070")]
    public const int tcompQUANTUM_LEVEL_HI = 0x0070;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompSHIFT_QUANTUM_LEVEL"]/*' />
    [NativeTypeName("#define tcompSHIFT_QUANTUM_LEVEL 4")]
    public const int tcompSHIFT_QUANTUM_LEVEL = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompMASK_QUANTUM_MEM"]/*' />
    [NativeTypeName("#define tcompMASK_QUANTUM_MEM 0x1F00")]
    public const int tcompMASK_QUANTUM_MEM = 0x1F00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompQUANTUM_MEM_LO"]/*' />
    [NativeTypeName("#define tcompQUANTUM_MEM_LO 0x0A00")]
    public const int tcompQUANTUM_MEM_LO = 0x0A00;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompQUANTUM_MEM_HI"]/*' />
    [NativeTypeName("#define tcompQUANTUM_MEM_HI 0x1500")]
    public const int tcompQUANTUM_MEM_HI = 0x1500;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompSHIFT_QUANTUM_MEM"]/*' />
    [NativeTypeName("#define tcompSHIFT_QUANTUM_MEM 8")]
    public const int tcompSHIFT_QUANTUM_MEM = 8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.tcompMASK_RESERVED"]/*' />
    [NativeTypeName("#define tcompMASK_RESERVED 0xE000")]
    public const int tcompMASK_RESERVED = 0xE000;
}
