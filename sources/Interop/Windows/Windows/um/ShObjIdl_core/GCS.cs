// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GCS
{
    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VERBA"]/*' />
    [NativeTypeName("#define GCS_VERBA 0x00000000")]
    public const int GCS_VERBA = 0x00000000;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_HELPTEXTA"]/*' />
    [NativeTypeName("#define GCS_HELPTEXTA 0x00000001")]
    public const int GCS_HELPTEXTA = 0x00000001;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VALIDATEA"]/*' />
    [NativeTypeName("#define GCS_VALIDATEA 0x00000002")]
    public const int GCS_VALIDATEA = 0x00000002;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VERBW"]/*' />
    [NativeTypeName("#define GCS_VERBW 0x00000004")]
    public const int GCS_VERBW = 0x00000004;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_HELPTEXTW"]/*' />
    [NativeTypeName("#define GCS_HELPTEXTW 0x00000005")]
    public const int GCS_HELPTEXTW = 0x00000005;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VALIDATEW"]/*' />
    [NativeTypeName("#define GCS_VALIDATEW 0x00000006")]
    public const int GCS_VALIDATEW = 0x00000006;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VERBICONW"]/*' />
    [NativeTypeName("#define GCS_VERBICONW 0x00000014")]
    public const int GCS_VERBICONW = 0x00000014;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_UNICODE"]/*' />
    [NativeTypeName("#define GCS_UNICODE 0x00000004")]
    public const int GCS_UNICODE = 0x00000004;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VERB"]/*' />
    [NativeTypeName("#define GCS_VERB GCS_VERBW")]
    public const int GCS_VERB = 0x00000004;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_HELPTEXT"]/*' />
    [NativeTypeName("#define GCS_HELPTEXT GCS_HELPTEXTW")]
    public const int GCS_HELPTEXT = 0x00000005;

    /// <include file='GCS.xml' path='doc/member[@name="GCS.GCS_VALIDATE"]/*' />
    [NativeTypeName("#define GCS_VALIDATE GCS_VALIDATEW")]
    public const int GCS_VALIDATE = 0x00000006;
}
