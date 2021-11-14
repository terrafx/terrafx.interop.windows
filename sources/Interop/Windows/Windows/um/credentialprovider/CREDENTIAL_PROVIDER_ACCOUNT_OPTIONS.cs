// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum CREDENTIAL_PROVIDER_ACCOUNT_OPTIONS
    {
        CPAO_NONE = 0,
        CPAO_EMPTY_LOCAL = 0x1,
        CPAO_EMPTY_CONNECTED = 0x2,
    }
}
