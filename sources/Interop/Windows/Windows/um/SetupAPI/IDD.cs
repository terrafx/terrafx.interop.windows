// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IDD
{
    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_FIRSTPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_FIRSTPAGE 10000")]
    public const int IDD_DYNAWIZ_FIRSTPAGE = 10000;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_SELECT_PREVPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_SELECT_PREVPAGE 10001")]
    public const int IDD_DYNAWIZ_SELECT_PREVPAGE = 10001;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_SELECT_NEXTPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_SELECT_NEXTPAGE 10002")]
    public const int IDD_DYNAWIZ_SELECT_NEXTPAGE = 10002;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_ANALYZE_PREVPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_ANALYZE_PREVPAGE 10003")]
    public const int IDD_DYNAWIZ_ANALYZE_PREVPAGE = 10003;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_ANALYZE_NEXTPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_ANALYZE_NEXTPAGE 10004")]
    public const int IDD_DYNAWIZ_ANALYZE_NEXTPAGE = 10004;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_SELECTDEV_PAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_SELECTDEV_PAGE 10009")]
    public const int IDD_DYNAWIZ_SELECTDEV_PAGE = 10009;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_ANALYZEDEV_PAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_ANALYZEDEV_PAGE 10010")]
    public const int IDD_DYNAWIZ_ANALYZEDEV_PAGE = 10010;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE 10011")]
    public const int IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE = 10011;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_SELECTCLASS_PAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_SELECTCLASS_PAGE 10012")]
    public const int IDD_DYNAWIZ_SELECTCLASS_PAGE = 10012;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE 10006")]
    public const int IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE = 10006;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE 10007")]
    public const int IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE = 10007;

    /// <include file='IDD.xml' path='doc/member[@name="IDD.IDD_DYNAWIZ_INSTALLDETECTED_NODEVS"]/*' />
    [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_NODEVS 10008")]
    public const int IDD_DYNAWIZ_INSTALLDETECTED_NODEVS = 10008;
}
