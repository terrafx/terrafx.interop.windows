// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_OBJECT_LOCATOR_PROVIDER_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_GET")]
        public IntPtr* pfnGet;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_RELEASE")]
        public IntPtr* pfnRelease;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_PASSWORD")]
        public IntPtr* pfnFreePassword;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE")]
        public IntPtr* pfnFree;

        [NativeTypeName("PFN_CRYPT_OBJECT_LOCATOR_PROVIDER_FREE_IDENTIFIER")]
        public IntPtr* pfnFreeIdentifier;
    }
}
