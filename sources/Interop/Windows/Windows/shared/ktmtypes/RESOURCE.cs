// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RESOURCE
{
    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_MANAGER_VOLATILE"]/*' />
    [NativeTypeName("#define RESOURCE_MANAGER_VOLATILE 0x00000001")]
    public const int RESOURCE_MANAGER_VOLATILE = 0x00000001;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_MANAGER_COMMUNICATION"]/*' />
    [NativeTypeName("#define RESOURCE_MANAGER_COMMUNICATION 0x00000002")]
    public const int RESOURCE_MANAGER_COMMUNICATION = 0x00000002;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_MANAGER_MAXIMUM_OPTION"]/*' />
    [NativeTypeName("#define RESOURCE_MANAGER_MAXIMUM_OPTION 0x00000003")]
    public const int RESOURCE_MANAGER_MAXIMUM_OPTION = 0x00000003;

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_MANAGER_OBJECT_PATH"]/*' />
    [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_PATH L\"\\ResourceManager\"")]
    public const string RESOURCE_MANAGER_OBJECT_PATH = "\\ResourceManager\\";

    /// <include file='RESOURCE.xml' path='doc/member[@name="RESOURCE.RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES"]/*' />
    [NativeTypeName("#define RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES (sizeof(RESOURCE_MANAGER_OBJECT_PATH)+(38*sizeof(WCHAR)))")]
    public const uint RESOURCE_MANAGER_OBJECT_NAME_LENGTH_IN_BYTES = (36 + (38 * 2));
}
