// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SystemInterruptTime.xml' path='doc/member[@name="SystemInterruptTime"]/*' />
public partial struct SystemInterruptTime
{
    /// <include file='SystemInterruptTime.xml' path='doc/member[@name="SystemInterruptTime.value"]/*' />
    [NativeTypeName("UINT64")]
    public ulong value;
}
