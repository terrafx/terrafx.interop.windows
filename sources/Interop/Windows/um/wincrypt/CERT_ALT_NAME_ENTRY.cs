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

        public unsafe ref CERT_OTHER_NAME* pOtherName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pOtherName;
            }
        }

        public unsafe ref ushort* pwszRfc822Name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pwszRfc822Name;
            }
        }

        public unsafe ref ushort* pwszDNSName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pwszDNSName;
            }
        }

        public unsafe ref CRYPTOAPI_BLOB DirectoryName
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DirectoryName, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->DirectoryName;
#endif
            }
        }

        public unsafe ref ushort* pwszURL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pwszURL;
            }
        }

        public unsafe ref CRYPTOAPI_BLOB IPAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IPAddress, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->IPAddress;
#endif
            }
        }

        public unsafe ref sbyte* pszRegisteredID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pszRegisteredID;
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
