// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CERT_ALT_NAME_ENTRY.xml' path='doc/member[@name="CERT_ALT_NAME_ENTRY"]/*' />
public unsafe partial struct CERT_ALT_NAME_ENTRY
{
    /// <include file='CERT_ALT_NAME_ENTRY.xml' path='doc/member[@name="CERT_ALT_NAME_ENTRY.dwAltNameChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAltNameChoice;

    /// <include file='CERT_ALT_NAME_ENTRY.xml' path='doc/member[@name="CERT_ALT_NAME_ENTRY.Anonymous"]/*' />
    [NativeTypeName("_CERT_ALT_NAME_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:3957:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOtherName"]/*' />
    public ref CERT_OTHER_NAME* pOtherName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pOtherName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszRfc822Name"]/*' />
    public ref ushort* pwszRfc822Name
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pwszRfc822Name;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszDNSName"]/*' />
    public ref ushort* pwszDNSName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pwszDNSName;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DirectoryName"]/*' />
    public ref CRYPT_DATA_BLOB DirectoryName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.DirectoryName, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszURL"]/*' />
    public ref ushort* pwszURL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pwszURL;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IPAddress"]/*' />
    public ref CRYPT_DATA_BLOB IPAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IPAddress, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszRegisteredID"]/*' />
    public ref sbyte* pszRegisteredID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous.pszRegisteredID;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pOtherName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCERT_OTHER_NAME")]
        public CERT_OTHER_NAME* pOtherName;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszRfc822Name"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszRfc822Name;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszDNSName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszDNSName;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DirectoryName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB DirectoryName;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pwszURL"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszURL;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IPAddress"]/*' />
        [FieldOffset(0)]
        public CRYPT_DATA_BLOB IPAddress;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszRegisteredID"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszRegisteredID;
    }
}
