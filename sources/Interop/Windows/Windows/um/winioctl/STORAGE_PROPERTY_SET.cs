// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STORAGE_PROPERTY_SET
    {
        public STORAGE_PROPERTY_ID PropertyId;

        public STORAGE_SET_TYPE SetType;

        [NativeTypeName("BYTE [1]")]
        public fixed byte AdditionalParameters[1];
    }
}
