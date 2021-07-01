// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SCM_BUS_SET_TYPE
    {
        ScmBusSet_Descriptor = 0,
        ScmBusSet_IsSupported,
        ScmBusSet_Max,
    }
}
