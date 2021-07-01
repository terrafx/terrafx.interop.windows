// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RID_DEVICE_INFO_MOUSE
    {
        [NativeTypeName("DWORD")]
        public uint dwId;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfButtons;

        [NativeTypeName("DWORD")]
        public uint dwSampleRate;

        [NativeTypeName("BOOL")]
        public int fHasHorizontalWheel;
    }
}
