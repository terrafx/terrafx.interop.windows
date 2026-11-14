// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

public partial struct SID
{
    /// <include file='SID.xml' path='doc/member[@name="SID.SID_IBindHost"]/*' />
    [NativeTypeName("#define SID_IBindHost IID_IBindHost")]
    public static ref readonly Guid SID_IBindHost => ref IID_IBindHost;

    /// <include file='SID.xml' path='doc/member[@name="SID.SID_SBindHost"]/*' />
    [NativeTypeName("#define SID_SBindHost IID_IBindHost")]
    public static ref readonly Guid SID_SBindHost => ref IID_IBindHost;

    /// <include file='SID.xml' path='doc/member[@name="SID.SID_SInternetSecurityManager"]/*' />
    [NativeTypeName("#define SID_SInternetSecurityManager IID_IInternetSecurityManager")]
    public static ref readonly Guid SID_SInternetSecurityManager => ref IID_IInternetSecurityManager;

    /// <include file='SID.xml' path='doc/member[@name="SID.SID_SInternetSecurityManagerEx"]/*' />
    [NativeTypeName("#define SID_SInternetSecurityManagerEx IID_IInternetSecurityManagerEx")]
    public static ref readonly Guid SID_SInternetSecurityManagerEx => ref IID_IInternetSecurityManagerEx;

    /// <include file='SID.xml' path='doc/member[@name="SID.SID_SInternetSecurityManagerEx2"]/*' />
    [NativeTypeName("#define SID_SInternetSecurityManagerEx2 IID_IInternetSecurityManagerEx2")]
    public static ref readonly Guid SID_SInternetSecurityManagerEx2 => ref IID_IInternetSecurityManagerEx2;

    /// <include file='SID.xml' path='doc/member[@name="SID.SID_SInternetHostSecurityManager"]/*' />
    [NativeTypeName("#define SID_SInternetHostSecurityManager IID_IInternetHostSecurityManager")]
    public static ref readonly Guid SID_SInternetHostSecurityManager => ref IID_IInternetHostSecurityManager;
}
