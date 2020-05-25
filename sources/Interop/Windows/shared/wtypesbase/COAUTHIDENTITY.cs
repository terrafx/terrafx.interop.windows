// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct COAUTHIDENTITY
    {
        [NativeTypeName("USHORT *")]
        public ushort* User;

        [NativeTypeName("ULONG")]
        public uint UserLength;

        [NativeTypeName("USHORT *")]
        public ushort* Domain;

        [NativeTypeName("ULONG")]
        public uint DomainLength;

        [NativeTypeName("USHORT *")]
        public ushort* Password;

        [NativeTypeName("ULONG")]
        public uint PasswordLength;

        [NativeTypeName("ULONG")]
        public uint Flags;
    }
}
