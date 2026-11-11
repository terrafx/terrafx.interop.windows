// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi_fci_types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CB
{
    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_CHUNK"]/*' />
    [NativeTypeName("#define CB_MAX_CHUNK 32768U")]
    public const uint CB_MAX_CHUNK = 32768U;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_DISK"]/*' />
    [NativeTypeName("#define CB_MAX_DISK 0x7fffffffL")]
    public const int CB_MAX_DISK = 0x7fffffff;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_FILENAME"]/*' />
    [NativeTypeName("#define CB_MAX_FILENAME 256")]
    public const int CB_MAX_FILENAME = 256;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_CABINET_NAME"]/*' />
    [NativeTypeName("#define CB_MAX_CABINET_NAME 256")]
    public const int CB_MAX_CABINET_NAME = 256;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_CAB_PATH"]/*' />
    [NativeTypeName("#define CB_MAX_CAB_PATH 256")]
    public const int CB_MAX_CAB_PATH = 256;

    /// <include file='CB.xml' path='doc/member[@name="CB.CB_MAX_DISK_NAME"]/*' />
    [NativeTypeName("#define CB_MAX_DISK_NAME 256")]
    public const int CB_MAX_DISK_NAME = 256;
}
