// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_ALT_NAME_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint dwAltNameChoice;

        [NativeTypeName("_CERT_ALT_NAME_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:3957:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref CERT_OTHER_NAME* pOtherName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pOtherName;
                }
            }
        }

        public ref ushort* pwszRfc822Name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszRfc822Name;
                }
            }
        }

        public ref ushort* pwszDNSName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszDNSName;
                }
            }
        }

        public ref CRYPTOAPI_BLOB DirectoryName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DirectoryName, 1));
            }
        }

        public ref ushort* pwszURL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pwszURL;
                }
            }
        }

        public ref CRYPTOAPI_BLOB IPAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IPAddress, 1));
            }
        }

        public ref sbyte* pszRegisteredID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pszRegisteredID;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCERT_OTHER_NAME")]
            public CERT_OTHER_NAME* pOtherName;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszRfc822Name;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszDNSName;

            [FieldOffset(0)]
            [NativeTypeName("CERT_NAME_BLOB")]
            public CRYPTOAPI_BLOB DirectoryName;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszURL;

            [FieldOffset(0)]
            [NativeTypeName("CRYPT_DATA_BLOB")]
            public CRYPTOAPI_BLOB IPAddress;

            [FieldOffset(0)]
            [NativeTypeName("LPSTR")]
            public sbyte* pszRegisteredID;
        }
    }
}
