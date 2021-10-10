// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WBEM_UNSECAPP_FLAG_TYPE
    {
        WBEM_FLAG_UNSECAPP_DEFAULT_CHECK_ACCESS = 0,
        WBEM_FLAG_UNSECAPP_CHECK_ACCESS = 1,
        WBEM_FLAG_UNSECAPP_DONT_CHECK_ACCESS = 2,
    }
}
