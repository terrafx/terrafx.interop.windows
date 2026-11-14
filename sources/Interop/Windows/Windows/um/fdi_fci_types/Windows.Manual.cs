// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort CompressionTypeFromTCOMP(ushort tcomp)
        => (ushort)(tcomp & tcompMASK_TYPE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort CompressionLevelFromTCOMP(ushort tcomp)
        => (ushort)((tcomp & tcompMASK_QUANTUM_LEVEL) >> tcompSHIFT_QUANTUM_LEVEL);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort CompressionMemoryFromTCOMP(ushort tcomp)
        => (ushort)((tcomp & tcompMASK_QUANTUM_MEM) >> tcompSHIFT_QUANTUM_MEM);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort TCOMPfromTypeLevelMemory(ushort type, ushort level, ushort memory)
        => unchecked((ushort)((memory << tcompSHIFT_QUANTUM_MEM) | (level << tcompSHIFT_QUANTUM_LEVEL) | type));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort LZXCompressionWindowFromTCOMP(ushort tcomp)
        => (ushort)((tcomp & tcompMASK_LZX_WINDOW) >> tcompSHIFT_LZX_WINDOW);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TCOMPfromLZXWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort TCOMPfromLZXWindow(ushort window)
        => unchecked((ushort)((window << tcompSHIFT_LZX_WINDOW) | tcompTYPE_LZX));
}
