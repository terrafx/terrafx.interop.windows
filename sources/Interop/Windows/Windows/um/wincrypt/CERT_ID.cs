// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct CERT_ID
{
    [NativeTypeName("DWORD")]
    public uint dwIdChoice;

    [NativeTypeName("_CERT_ID::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:6665:5)")]
    public _Anonymous_e__Union Anonymous;

    public ref CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.IssuerSerialNumber, 1));
        }
    }

    public ref CRYPT_DATA_BLOB KeyId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.KeyId, 1));
        }
    }

    public ref CRYPT_DATA_BLOB HashId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.HashId, 1));
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber;

        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB KeyId;

        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB HashId;
    }
}
