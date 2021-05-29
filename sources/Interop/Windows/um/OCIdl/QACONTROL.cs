// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct QACONTROL
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMiscStatus;

        [NativeTypeName("DWORD")]
        public uint dwViewStatus;

        [NativeTypeName("DWORD")]
        public uint dwEventCookie;

        [NativeTypeName("DWORD")]
        public uint dwPropNotifyCookie;

        [NativeTypeName("DWORD")]
        public uint dwPointerActivationPolicy;
    }
}
