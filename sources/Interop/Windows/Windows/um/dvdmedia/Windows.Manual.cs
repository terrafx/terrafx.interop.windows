// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static uint SIZE_MPEG2VIDEOINFO(MPEG2VIDEOINFO* pv)
    {
        Unsafe.SkipInit(out MPEG2VIDEOINFO tmp);
        uint sequenceHeaderOffset = unchecked((uint)(&tmp.dwSequenceHeader.e0) - (uint)(&tmp));
        return unchecked(sequenceHeaderOffset + pv->cbSequenceHeader);
    }

    [return: NativeTypeName("const BYTE *")]
    public static byte* MPEG2_SEQUENCE_INFO(MPEG2VIDEOINFO* pv)
        => (byte*)&pv->dwSequenceHeader.e0;
}
