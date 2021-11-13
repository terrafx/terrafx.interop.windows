// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum TKBLayoutType
    {
        TKBLT_UNDEFINED = 0,
        TKBLT_CLASSIC = 1,
        TKBLT_OPTIMIZED = 2,
    }
}
