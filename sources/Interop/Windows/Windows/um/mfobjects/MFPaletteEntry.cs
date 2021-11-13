// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct MFPaletteEntry
    {
        [FieldOffset(0)]
        public MFARGB ARGB;

        [FieldOffset(0)]
        public MFAYUVSample AYCbCr;
    }
}
