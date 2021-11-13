// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WBEM_CONNECT_OPTIONS
    {
        WBEM_FLAG_CONNECT_REPOSITORY_ONLY = 0x40,
        WBEM_FLAG_CONNECT_USE_MAX_WAIT = 0x80,
        WBEM_FLAG_CONNECT_PROVIDERS = 0x100,
    }
}
