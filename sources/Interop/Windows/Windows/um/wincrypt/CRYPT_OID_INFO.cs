// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO"]/*' />
public unsafe partial struct CRYPT_OID_INFO
{
    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.pszOID"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszOID;

    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.pwszName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszName;

    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.dwGroupId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwGroupId;

    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.Anonymous"]/*' />
    [NativeTypeName("_CRYPT_OID_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:6206:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='CRYPT_OID_INFO.xml' path='doc/member[@name="CRYPT_OID_INFO.ExtraInfo"]/*' />
    public CRYPT_DATA_BLOB ExtraInfo;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwValue"]/*' />
    public ref uint dwValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwValue, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Algid"]/*' />
    public ref uint Algid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Algid, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwLength"]/*' />
    public ref uint dwLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwLength, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwValue;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Algid"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ALG_ID")]
        public uint Algid;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwLength"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLength;
    }
}
