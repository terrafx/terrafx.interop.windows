// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_BLOB_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("GUID *")]
        public Guid* pGuidSubject;

        [NativeTypeName("DWORD")]
        public uint cbBlob;

        [NativeTypeName("BYTE *")]
        public byte* pbBlob;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwszDisplayName;
    }
}
