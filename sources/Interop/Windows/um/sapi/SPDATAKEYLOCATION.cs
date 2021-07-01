// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPDATAKEYLOCATION
    {
        SPDKL_DefaultLocation = 0,
        SPDKL_CurrentUser = 1,
        SPDKL_LocalMachine = 2,
        SPDKL_CurrentConfig = 5,
    }
}
