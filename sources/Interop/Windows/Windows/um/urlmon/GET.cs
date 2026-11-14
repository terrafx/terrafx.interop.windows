// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GET
{
    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD 0x00000001")]
    public const int GET_FEATURE_FROM_THREAD = 0x00000001;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_PROCESS"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_PROCESS 0x00000002")]
    public const int GET_FEATURE_FROM_PROCESS = 0x00000002;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_REGISTRY"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_REGISTRY 0x00000004")]
    public const int GET_FEATURE_FROM_REGISTRY = 0x00000004;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD_LOCALMACHINE"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD_LOCALMACHINE 0x00000008")]
    public const int GET_FEATURE_FROM_THREAD_LOCALMACHINE = 0x00000008;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD_INTRANET"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTRANET 0x00000010")]
    public const int GET_FEATURE_FROM_THREAD_INTRANET = 0x00000010;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD_TRUSTED"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD_TRUSTED 0x00000020")]
    public const int GET_FEATURE_FROM_THREAD_TRUSTED = 0x00000020;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD_INTERNET"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD_INTERNET 0x00000040")]
    public const int GET_FEATURE_FROM_THREAD_INTERNET = 0x00000040;

    /// <include file='GET.xml' path='doc/member[@name="GET.GET_FEATURE_FROM_THREAD_RESTRICTED"]/*' />
    [NativeTypeName("#define GET_FEATURE_FROM_THREAD_RESTRICTED 0x00000080")]
    public const int GET_FEATURE_FROM_THREAD_RESTRICTED = 0x00000080;
}
