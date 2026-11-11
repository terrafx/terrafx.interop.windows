// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISPID
{
    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_UNKNOWN"]/*' />
    [NativeTypeName("#define DISPID_UNKNOWN ( -1 )")]
    public const int DISPID_UNKNOWN = (-1);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_VALUE"]/*' />
    [NativeTypeName("#define DISPID_VALUE ( 0 )")]
    public const int DISPID_VALUE = (0);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_PROPERTYPUT"]/*' />
    [NativeTypeName("#define DISPID_PROPERTYPUT ( -3 )")]
    public const int DISPID_PROPERTYPUT = (-3);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_NEWENUM"]/*' />
    [NativeTypeName("#define DISPID_NEWENUM ( -4 )")]
    public const int DISPID_NEWENUM = (-4);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EVALUATE"]/*' />
    [NativeTypeName("#define DISPID_EVALUATE ( -5 )")]
    public const int DISPID_EVALUATE = (-5);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_CONSTRUCTOR"]/*' />
    [NativeTypeName("#define DISPID_CONSTRUCTOR ( -6 )")]
    public const int DISPID_CONSTRUCTOR = (-6);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_DESTRUCTOR"]/*' />
    [NativeTypeName("#define DISPID_DESTRUCTOR ( -7 )")]
    public const int DISPID_DESTRUCTOR = (-7);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_COLLECT"]/*' />
    [NativeTypeName("#define DISPID_COLLECT ( -8 )")]
    public const int DISPID_COLLECT = (-8);
}
