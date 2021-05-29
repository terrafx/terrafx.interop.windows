// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct SIP_SUBJECTINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("GUID *")]
        public Guid* pgSubjectType;

        [NativeTypeName("HANDLE")]
        public IntPtr hFile;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwsFileName;

        [NativeTypeName("LPCWSTR")]
        public ushort* pwsDisplayName;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;

        [NativeTypeName("DWORD")]
        public uint dwIntVersion;

        [NativeTypeName("HCRYPTPROV")]
        public nuint hProv;

        public CRYPT_ALGORITHM_IDENTIFIER DigestAlgorithm;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwEncodingType;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;

        [NativeTypeName("DWORD")]
        public uint fdwCAPISettings;

        [NativeTypeName("DWORD")]
        public uint fdwSecuritySettings;

        [NativeTypeName("DWORD")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwUnionChoice;

        [NativeTypeName("SIP_SUBJECTINFO_::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mssip.h:114:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("LPVOID")]
        public void* pClientData;

        public ref MS_ADDINFO_FLAT* psFlat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->psFlat;
                }
            }
        }

        public ref MS_ADDINFO_CATALOGMEMBER* psCatMember
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->psCatMember;
                }
            }
        }

        public ref MS_ADDINFO_BLOB* psBlob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->psBlob;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct MS_ADDINFO_FLAT_ *")]
            public MS_ADDINFO_FLAT* psFlat;

            [FieldOffset(0)]
            [NativeTypeName("struct MS_ADDINFO_CATALOGMEMBER_ *")]
            public MS_ADDINFO_CATALOGMEMBER* psCatMember;

            [FieldOffset(0)]
            [NativeTypeName("struct MS_ADDINFO_BLOB_ *")]
            public MS_ADDINFO_BLOB* psBlob;
        }
    }
}
