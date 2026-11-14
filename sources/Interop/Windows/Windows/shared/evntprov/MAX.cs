// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_DATA_DESCRIPTORS"]/*' />
    [NativeTypeName("#define MAX_EVENT_DATA_DESCRIPTORS (128)")]
    public const int MAX_EVENT_DATA_DESCRIPTORS = (128);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTER_DATA_SIZE"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTER_DATA_SIZE (1024)")]
    public const int MAX_EVENT_FILTER_DATA_SIZE = (1024);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTER_PAYLOAD_SIZE"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTER_PAYLOAD_SIZE (4096)")]
    public const int MAX_EVENT_FILTER_PAYLOAD_SIZE = (4096);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTER_EVENT_NAME_SIZE"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTER_EVENT_NAME_SIZE (4096)")]
    public const int MAX_EVENT_FILTER_EVENT_NAME_SIZE = (4096);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTERS_COUNT"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTERS_COUNT (13)")]
    public const int MAX_EVENT_FILTERS_COUNT = (13);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTER_PID_COUNT"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTER_PID_COUNT (8)")]
    public const int MAX_EVENT_FILTER_PID_COUNT = (8);

    /// <include file='MAX.xml' path='doc/member[@name="MAX.MAX_EVENT_FILTER_EVENT_ID_COUNT"]/*' />
    [NativeTypeName("#define MAX_EVENT_FILTER_EVENT_ID_COUNT (64)")]
    public const int MAX_EVENT_FILTER_EVENT_ID_COUNT = (64);
}
