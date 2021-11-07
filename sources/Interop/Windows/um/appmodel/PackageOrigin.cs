// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.1")]
    public enum PackageOrigin
    {
        PackageOrigin_Unknown = 0,
        PackageOrigin_Unsigned = 1,
        PackageOrigin_Inbox = 2,
        PackageOrigin_Store = 3,
        PackageOrigin_DeveloperUnsigned = 4,
        PackageOrigin_DeveloperSigned = 5,
        PackageOrigin_LineOfBusiness = 6,
    }
}
