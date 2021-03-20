// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct CorePhysicalKeyStatus
    {
        [NativeTypeName("UINT32")]
        public uint RepeatCount;

        [NativeTypeName("UINT32")]
        public uint ScanCode;

        [NativeTypeName("boolean")]
        public byte IsExtendedKey;

        [NativeTypeName("boolean")]
        public byte IsMenuKeyDown;

        [NativeTypeName("boolean")]
        public byte WasKeyDown;

        [NativeTypeName("boolean")]
        public byte IsKeyReleased;
    }
}
