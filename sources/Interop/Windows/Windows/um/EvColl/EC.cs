// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EC
{
    /// <include file='EC.xml' path='doc/member[@name="EC.EC_VARIANT_TYPE_MASK"]/*' />
    [NativeTypeName("#define EC_VARIANT_TYPE_MASK 0x7f")]
    public const int EC_VARIANT_TYPE_MASK = 0x7f;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_VARIANT_TYPE_ARRAY"]/*' />
    [NativeTypeName("#define EC_VARIANT_TYPE_ARRAY 128")]
    public const int EC_VARIANT_TYPE_ARRAY = 128;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_READ_ACCESS"]/*' />
    [NativeTypeName("#define EC_READ_ACCESS 1")]
    public const int EC_READ_ACCESS = 1;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_WRITE_ACCESS"]/*' />
    [NativeTypeName("#define EC_WRITE_ACCESS 2")]
    public const int EC_WRITE_ACCESS = 2;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_OPEN_ALWAYS"]/*' />
    [NativeTypeName("#define EC_OPEN_ALWAYS 0")]
    public const int EC_OPEN_ALWAYS = 0;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_CREATE_NEW"]/*' />
    [NativeTypeName("#define EC_CREATE_NEW 1")]
    public const int EC_CREATE_NEW = 1;

    /// <include file='EC.xml' path='doc/member[@name="EC.EC_OPEN_EXISTING"]/*' />
    [NativeTypeName("#define EC_OPEN_EXISTING 2")]
    public const int EC_OPEN_EXISTING = 2;
}
