// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PDC
{
    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ARRIVAL"]/*' />
    [NativeTypeName("#define PDC_ARRIVAL 0x001")]
    public const int PDC_ARRIVAL = 0x001;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_REMOVAL"]/*' />
    [NativeTypeName("#define PDC_REMOVAL 0x002")]
    public const int PDC_REMOVAL = 0x002;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ORIENTATION_0"]/*' />
    [NativeTypeName("#define PDC_ORIENTATION_0 0x004")]
    public const int PDC_ORIENTATION_0 = 0x004;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ORIENTATION_90"]/*' />
    [NativeTypeName("#define PDC_ORIENTATION_90 0x008")]
    public const int PDC_ORIENTATION_90 = 0x008;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ORIENTATION_180"]/*' />
    [NativeTypeName("#define PDC_ORIENTATION_180 0x010")]
    public const int PDC_ORIENTATION_180 = 0x010;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ORIENTATION_270"]/*' />
    [NativeTypeName("#define PDC_ORIENTATION_270 0x020")]
    public const int PDC_ORIENTATION_270 = 0x020;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_MODE_DEFAULT"]/*' />
    [NativeTypeName("#define PDC_MODE_DEFAULT 0x040")]
    public const int PDC_MODE_DEFAULT = 0x040;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_MODE_CENTERED"]/*' />
    [NativeTypeName("#define PDC_MODE_CENTERED 0x080")]
    public const int PDC_MODE_CENTERED = 0x080;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_MAPPING_CHANGE"]/*' />
    [NativeTypeName("#define PDC_MAPPING_CHANGE 0x100")]
    public const int PDC_MAPPING_CHANGE = 0x100;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_RESOLUTION"]/*' />
    [NativeTypeName("#define PDC_RESOLUTION 0x200")]
    public const int PDC_RESOLUTION = 0x200;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_ORIGIN"]/*' />
    [NativeTypeName("#define PDC_ORIGIN 0x400")]
    public const int PDC_ORIGIN = 0x400;

    /// <include file='PDC.xml' path='doc/member[@name="PDC.PDC_MODE_ASPECTRATIOPRESERVED"]/*' />
    [NativeTypeName("#define PDC_MODE_ASPECTRATIOPRESERVED 0x800")]
    public const int PDC_MODE_ASPECTRATIOPRESERVED = 0x800;
}
