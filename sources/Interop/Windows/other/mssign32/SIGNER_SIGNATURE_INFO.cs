// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIGNER_SIGNATURE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("ALG_ID")]
        public uint algidHash;

        [NativeTypeName("DWORD")]
        public uint dwAttrChoice;

        [NativeTypeName("_SIGNER_SIGNATURE_INFO::(anonymous union at ./mssign32.h:53:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref SIGNER_ATTR_AUTHCODE* pAttrAuthcode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pAttrAuthcode;
                }
            }
        }

        [NativeTypeName("PCRYPT_ATTRIBUTES")]
        public CRYPT_ATTRIBUTES* psAuthenticated;

        [NativeTypeName("PCRYPT_ATTRIBUTES")]
        public CRYPT_ATTRIBUTES* psUnauthenticated;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("SIGNER_ATTR_AUTHCODE *")]
            public SIGNER_ATTR_AUTHCODE* pAttrAuthcode;
        }
    }
}
