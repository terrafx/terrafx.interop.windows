// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_TRANSACTION_DESCRIPTION_LENGTH"]/*' />
    [NativeTypeName("#define MAX_TRANSACTION_DESCRIPTION_LENGTH 64")]
    public const int MAX_TRANSACTION_DESCRIPTION_LENGTH = 64;

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH"]/*' />
    [NativeTypeName("#define MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH 64")]
    public const int MAX_RESOURCEMANAGER_DESCRIPTION_LENGTH = 64;
}
