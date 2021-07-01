// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct RID_DEVICE_INFO_KEYBOARD
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwSubType;

        [NativeTypeName("DWORD")]
        public uint dwKeyboardMode;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfFunctionKeys;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfIndicators;

        [NativeTypeName("DWORD")]
        public uint dwNumberOfKeysTotal;
    }
}
