// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class SZ
{
    [NativeTypeName("#define sz_CERT_STORE_PROV_MEMORY \"Memory\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_MEMORY => new byte[] { 0x4D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME_W \"File\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME_W => new byte[] { 0x46, 0x69, 0x6C, 0x65, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME sz_CERT_STORE_PROV_FILENAME_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME => new byte[] { 0x46, 0x69, 0x6C, 0x65, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_W \"System\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_W => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM sz_CERT_STORE_PROV_SYSTEM_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS7 \"PKCS7\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS7 => new byte[] { 0x50, 0x4B, 0x43, 0x53, 0x37, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS12 \"PKCS12\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS12 => new byte[] { 0x50, 0x4B, 0x43, 0x53, 0x31, 0x32, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SERIALIZED \"Serialized\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SERIALIZED => new byte[] { 0x53, 0x65, 0x72, 0x69, 0x61, 0x6C, 0x69, 0x7A, 0x65, 0x64, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_COLLECTION \"Collection\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_COLLECTION => new byte[] { 0x43, 0x6F, 0x6C, 0x6C, 0x65, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W \"SystemRegistry\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x72, 0x79, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY => new byte[] { 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x52, 0x65, 0x67, 0x69, 0x73, 0x74, 0x72, 0x79, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL_W \"Physical\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL_W => new byte[] { 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL sz_CERT_STORE_PROV_PHYSICAL_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL => new byte[] { 0x50, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD_W \"SmartCard\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD_W => new byte[] { 0x53, 0x6D, 0x61, 0x72, 0x74, 0x43, 0x61, 0x72, 0x64, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD sz_CERT_STORE_PROV_SMART_CARD_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD => new byte[] { 0x53, 0x6D, 0x61, 0x72, 0x74, 0x43, 0x61, 0x72, 0x64, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP_W \"Ldap\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP_W => new byte[] { 0x4C, 0x64, 0x61, 0x70, 0x00 };

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP sz_CERT_STORE_PROV_LDAP_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP => new byte[] { 0x4C, 0x64, 0x61, 0x70, 0x00 };
}
