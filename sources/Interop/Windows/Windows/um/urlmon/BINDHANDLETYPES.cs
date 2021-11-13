// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum BINDHANDLETYPES
    {
        BINDHANDLETYPES_APPCACHE = 0,
        BINDHANDLETYPES_DEPENDENCY = 0x1,
        BINDHANDLETYPES_COUNT = (BINDHANDLETYPES_DEPENDENCY + 1),
    }
}
