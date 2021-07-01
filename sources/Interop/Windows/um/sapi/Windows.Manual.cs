// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.SPEVENTENUM;
using static TerraFX.Interop.SPPHRASERNG;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static ulong SPFEI(int SPEI_ord) => ((1UL << SPEI_ord) | SPFEI_FLAGCHECK);

        public static readonly Guid LIBID_SpeechLib = new Guid(0xC866CA3A, 0x32F7, 0x11D2, 0x96, 0x02, 0x00, 0xC0, 0x4F, 0x8E, 0xE6, 0x28);
    }
}
