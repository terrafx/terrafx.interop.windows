// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_LOGOTYPE_IMAGE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwLogotypeImageInfoChoice;

        [NativeTypeName("DWORD")]
        public uint dwFileSize;

        [NativeTypeName("DWORD")]
        public uint dwXSize;

        [NativeTypeName("DWORD")]
        public uint dwYSize;

        [NativeTypeName("DWORD")]
        public uint dwLogotypeImageResolutionChoice;

        [NativeTypeName("_CERT_LOGOTYPE_IMAGE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:5456:5)")]
        public _Anonymous_e__Union Anonymous

        [NativeTypeName("LPWSTR")]
        public ushort* pwszLanguage;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwNumBits;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwTableSize;
        }
    }
}
