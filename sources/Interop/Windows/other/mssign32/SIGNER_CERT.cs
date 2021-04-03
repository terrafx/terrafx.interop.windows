// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_CERT
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwCertChoice;

        [NativeTypeName("_SIGNER_CERT::(anonymous union at ./mssign32.h:109:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        public ref ushort* pwszSpcFile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszSpcFile;
                }
            }
        }

        public ref SIGNER_CERT_STORE_INFO* pCertStoreInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pCertStoreInfo;
                }
            }
        }

        public ref SIGNER_SPC_CHAIN_INFO* pSpcChainInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pSpcChainInfo;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pwszSpcFile;

            [FieldOffset(0)]
            public SIGNER_CERT_STORE_INFO* pCertStoreInfo;

            [FieldOffset(0)]
            public SIGNER_SPC_CHAIN_INFO* pSpcChainInfo;
        }
    }
}
