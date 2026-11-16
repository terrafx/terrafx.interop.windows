// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STORAGE
{
    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_READY"]/*' />
    [NativeTypeName("#define STORAGE_READY 0x80")]
    public const int STORAGE_READY = 0x80;

    /// <include file='STORAGE.xml' path='doc/member[@name="STORAGE.STORAGE_FULL"]/*' />
    [NativeTypeName("#define STORAGE_FULL 0x100")]
    public const int STORAGE_FULL = 0x100;
}
