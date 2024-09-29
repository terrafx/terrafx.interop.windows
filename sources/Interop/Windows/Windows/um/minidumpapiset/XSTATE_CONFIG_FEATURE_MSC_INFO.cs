// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSTATE_CONFIG_FEATURE_MSC_INFO.xml' path='doc/member[@name="XSTATE_CONFIG_FEATURE_MSC_INFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct XSTATE_CONFIG_FEATURE_MSC_INFO
{
    /// <include file='XSTATE_CONFIG_FEATURE_MSC_INFO.xml' path='doc/member[@name="XSTATE_CONFIG_FEATURE_MSC_INFO.SizeOfInfo"]/*' />
    [NativeTypeName("ULONG32")]
    public uint SizeOfInfo;

    /// <include file='XSTATE_CONFIG_FEATURE_MSC_INFO.xml' path='doc/member[@name="XSTATE_CONFIG_FEATURE_MSC_INFO.ContextSize"]/*' />
    [NativeTypeName("ULONG32")]
    public uint ContextSize;

    /// <include file='XSTATE_CONFIG_FEATURE_MSC_INFO.xml' path='doc/member[@name="XSTATE_CONFIG_FEATURE_MSC_INFO.EnabledFeatures"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong EnabledFeatures;

    /// <include file='XSTATE_CONFIG_FEATURE_MSC_INFO.xml' path='doc/member[@name="XSTATE_CONFIG_FEATURE_MSC_INFO.Features"]/*' />
    [NativeTypeName("XSTATE_FEATURE[64]")]
    public _Features_e__FixedBuffer Features;

    /// <include file='_Features_e__FixedBuffer.xml' path='doc/member[@name="_Features_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [InlineArray(64)]
    public partial struct _Features_e__FixedBuffer
    {
        public XSTATE_FEATURE e0;
    }
}
