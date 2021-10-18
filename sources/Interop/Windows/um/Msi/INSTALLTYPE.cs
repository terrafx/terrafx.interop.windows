// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum INSTALLTYPE
    {
        INSTALLTYPE_DEFAULT = 0,
        INSTALLTYPE_NETWORK_IMAGE = 1,
        INSTALLTYPE_SINGLE_INSTANCE = 2,
    }
}
