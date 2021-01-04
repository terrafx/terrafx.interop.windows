// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PackagePathType
    {
        PackagePathType_Install = 0,
        PackagePathType_Mutable = 1,
        PackagePathType_Effective = 2,
        PackagePathType_MachineExternal = 3,
        PackagePathType_UserExternal = 4,
        PackagePathType_EffectiveExternal = 5,
    }
}
