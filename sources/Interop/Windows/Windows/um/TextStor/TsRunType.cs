// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum TsRunType
    {
        TS_RT_PLAIN = 0,
        TS_RT_HIDDEN = (TS_RT_PLAIN + 1),
        TS_RT_OPAQUE = (TS_RT_HIDDEN + 1),
    }
}
