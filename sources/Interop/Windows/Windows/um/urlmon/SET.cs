// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SET
{
    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD 0x00000001")]
    public const int SET_FEATURE_ON_THREAD = 0x00000001;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_PROCESS"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_PROCESS 0x00000002")]
    public const int SET_FEATURE_ON_PROCESS = 0x00000002;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_IN_REGISTRY"]/*' />
    [NativeTypeName("#define SET_FEATURE_IN_REGISTRY 0x00000004")]
    public const int SET_FEATURE_IN_REGISTRY = 0x00000004;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD_LOCALMACHINE"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD_LOCALMACHINE 0x00000008")]
    public const int SET_FEATURE_ON_THREAD_LOCALMACHINE = 0x00000008;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD_INTRANET"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTRANET 0x00000010")]
    public const int SET_FEATURE_ON_THREAD_INTRANET = 0x00000010;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD_TRUSTED"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD_TRUSTED 0x00000020")]
    public const int SET_FEATURE_ON_THREAD_TRUSTED = 0x00000020;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD_INTERNET"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD_INTERNET 0x00000040")]
    public const int SET_FEATURE_ON_THREAD_INTERNET = 0x00000040;

    /// <include file='SET.xml' path='doc/member[@name="SET.SET_FEATURE_ON_THREAD_RESTRICTED"]/*' />
    [NativeTypeName("#define SET_FEATURE_ON_THREAD_RESTRICTED 0x00000080")]
    public const int SET_FEATURE_ON_THREAD_RESTRICTED = 0x00000080;
}
