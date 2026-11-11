// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY"]/*' />
    [NativeTypeName("#define CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY 0x00000001")]
    public const int CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO"]/*' />
    [NativeTypeName("#define CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO 0x00000002")]
    public const int CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CRM_PROTOCOL_MAXIMUM_OPTION"]/*' />
    [NativeTypeName("#define CRM_PROTOCOL_MAXIMUM_OPTION 0x00000003")]
    public const int CRM_PROTOCOL_MAXIMUM_OPTION = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KTM_MARSHAL_BLOB_VERSION_MAJOR"]/*' />
    [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MAJOR 1")]
    public const int KTM_MARSHAL_BLOB_VERSION_MAJOR = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.KTM_MARSHAL_BLOB_VERSION_MINOR"]/*' />
    [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MINOR 1")]
    public const int KTM_MARSHAL_BLOB_VERSION_MINOR = 1;
}
