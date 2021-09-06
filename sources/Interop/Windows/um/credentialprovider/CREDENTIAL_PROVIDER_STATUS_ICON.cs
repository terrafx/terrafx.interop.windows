// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CREDENTIAL_PROVIDER_STATUS_ICON
    {
        CPSI_NONE = 0,
        CPSI_ERROR = (CPSI_NONE + 1),
        CPSI_WARNING = (CPSI_ERROR + 1),
        CPSI_SUCCESS = (CPSI_WARNING + 1),
    }
}
