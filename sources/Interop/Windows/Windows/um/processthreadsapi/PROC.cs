// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROC
{
    /// <include file='PROC.xml' path='doc/member[@name="PROC.PROC_THREAD_ATTRIBUTE_REPLACE_VALUE"]/*' />
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_REPLACE_VALUE 0x00000001")]
    public const int PROC_THREAD_ATTRIBUTE_REPLACE_VALUE = 0x00000001;
}
