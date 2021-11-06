// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/verrsrc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct VS_FIXEDFILEINFO
    {
        [NativeTypeName("DWORD")]
        public uint dwSignature;

        [NativeTypeName("DWORD")]
        public uint dwStrucVersion;

        [NativeTypeName("DWORD")]
        public uint dwFileVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwFileVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwProductVersionMS;

        [NativeTypeName("DWORD")]
        public uint dwProductVersionLS;

        [NativeTypeName("DWORD")]
        public uint dwFileFlagsMask;

        [NativeTypeName("DWORD")]
        public uint dwFileFlags;

        [NativeTypeName("DWORD")]
        public uint dwFileOS;

        [NativeTypeName("DWORD")]
        public uint dwFileType;

        [NativeTypeName("DWORD")]
        public uint dwFileSubtype;

        [NativeTypeName("DWORD")]
        public uint dwFileDateMS;

        [NativeTypeName("DWORD")]
        public uint dwFileDateLS;
    }
}
