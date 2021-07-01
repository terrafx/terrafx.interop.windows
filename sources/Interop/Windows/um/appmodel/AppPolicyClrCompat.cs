// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AppPolicyClrCompat
    {
        AppPolicyClrCompat_Other = 0,
        AppPolicyClrCompat_ClassicDesktop = 1,
        AppPolicyClrCompat_Universal = 2,
        AppPolicyClrCompat_PackagedDesktop = 3,
    }
}
