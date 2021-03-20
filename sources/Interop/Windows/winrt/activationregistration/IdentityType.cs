// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IdentityType
    {
        IdentityType_ActivateAsActivator,
        IdentityType_RunAs,
        IdentityType_ActivateAsPackage,
        IdentityType_SessionVirtual,
        IdentityType_SessionUser,
        IdentityType_ActivateAsActivatingUser,
    }
}
