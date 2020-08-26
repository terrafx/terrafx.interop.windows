// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_CONTENT_ENCRYPT_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public nuint hCryptProv;

        public CRYPT_ALGORITHM_IDENTIFIER ContentEncryptionAlgorithm;

        [NativeTypeName("void *")]
        public void* pvEncryptionAuxInfo;

        [NativeTypeName("DWORD")]
        public uint cRecipients;

        [NativeTypeName("PCMSG_RECIPIENT_ENCODE_INFO")]
        public CMSG_RECIPIENT_ENCODE_INFO* rgCmsRecipients;

        [NativeTypeName("PFN_CMSG_ALLOC")]
        public delegate* stdcall<nuint, void*> pfnAlloc;

        [NativeTypeName("PFN_CMSG_FREE")]
        public delegate* stdcall<void*, void> pfnFree;

        [NativeTypeName("DWORD")]
        public uint dwEncryptFlags;

        [NativeTypeName("_CMSG_CONTENT_ENCRYPT_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:8442:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref nuint hContentEncryptKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hContentEncryptKey, 1));
            }
        }

        public ref void* hCNGContentEncryptKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->hCNGContentEncryptKey;
                }
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("BOOL")]
        public int fCNG;

        [NativeTypeName("BYTE *")]
        public byte* pbCNGContentEncryptKeyObject;

        [NativeTypeName("BYTE *")]
        public byte* pbContentEncryptKey;

        [NativeTypeName("DWORD")]
        public uint cbContentEncryptKey;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTKEY")]
            public nuint hContentEncryptKey;

            [FieldOffset(0)]
            [NativeTypeName("BCRYPT_KEY_HANDLE")]
            public void* hCNGContentEncryptKey;
        }
    }
}
