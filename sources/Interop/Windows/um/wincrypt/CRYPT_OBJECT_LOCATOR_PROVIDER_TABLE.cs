// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET")]
        public delegate* stdcall<void*, CRYPTOAPI_BLOB*, uint, CRYPTOAPI_BLOB*, byte**, uint*, ushort**, CRYPTOAPI_BLOB**, int> pfnGet;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_RELEASE")]
        public delegate* stdcall<uint, void*, void> pfnRelease;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_PASSWORD")]
        public delegate* stdcall<void*, ushort*, void> pfnFreePassword;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE")]
        public delegate* stdcall<void*, byte*, void> pfnFree;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_IDENTIFIER")]
        public delegate* stdcall<void*, CRYPTOAPI_BLOB*, void> pfnFreeIdentifier;
    }
}
