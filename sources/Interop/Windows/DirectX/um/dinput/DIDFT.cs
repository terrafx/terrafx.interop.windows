// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDFT
{
    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_ALL"]/*' />
    [NativeTypeName("#define DIDFT_ALL 0x00000000")]
    public const int DIDFT_ALL = 0x00000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_RELAXIS"]/*' />
    [NativeTypeName("#define DIDFT_RELAXIS 0x00000001")]
    public const int DIDFT_RELAXIS = 0x00000001;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_ABSAXIS"]/*' />
    [NativeTypeName("#define DIDFT_ABSAXIS 0x00000002")]
    public const int DIDFT_ABSAXIS = 0x00000002;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_AXIS"]/*' />
    [NativeTypeName("#define DIDFT_AXIS 0x00000003")]
    public const int DIDFT_AXIS = 0x00000003;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_PSHBUTTON"]/*' />
    [NativeTypeName("#define DIDFT_PSHBUTTON 0x00000004")]
    public const int DIDFT_PSHBUTTON = 0x00000004;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_TGLBUTTON"]/*' />
    [NativeTypeName("#define DIDFT_TGLBUTTON 0x00000008")]
    public const int DIDFT_TGLBUTTON = 0x00000008;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_BUTTON"]/*' />
    [NativeTypeName("#define DIDFT_BUTTON 0x0000000C")]
    public const int DIDFT_BUTTON = 0x0000000C;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_POV"]/*' />
    [NativeTypeName("#define DIDFT_POV 0x00000010")]
    public const int DIDFT_POV = 0x00000010;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_COLLECTION"]/*' />
    [NativeTypeName("#define DIDFT_COLLECTION 0x00000040")]
    public const int DIDFT_COLLECTION = 0x00000040;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_NODATA"]/*' />
    [NativeTypeName("#define DIDFT_NODATA 0x00000080")]
    public const int DIDFT_NODATA = 0x00000080;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_ANYINSTANCE"]/*' />
    [NativeTypeName("#define DIDFT_ANYINSTANCE 0x00FFFF00")]
    public const int DIDFT_ANYINSTANCE = 0x00FFFF00;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_INSTANCEMASK"]/*' />
    [NativeTypeName("#define DIDFT_INSTANCEMASK DIDFT_ANYINSTANCE")]
    public const int DIDFT_INSTANCEMASK = 0x00FFFF00;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_FFACTUATOR"]/*' />
    [NativeTypeName("#define DIDFT_FFACTUATOR 0x01000000")]
    public const int DIDFT_FFACTUATOR = 0x01000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_FFEFFECTTRIGGER"]/*' />
    [NativeTypeName("#define DIDFT_FFEFFECTTRIGGER 0x02000000")]
    public const int DIDFT_FFEFFECTTRIGGER = 0x02000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_OUTPUT"]/*' />
    [NativeTypeName("#define DIDFT_OUTPUT 0x10000000")]
    public const int DIDFT_OUTPUT = 0x10000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_VENDORDEFINED"]/*' />
    [NativeTypeName("#define DIDFT_VENDORDEFINED 0x04000000")]
    public const int DIDFT_VENDORDEFINED = 0x04000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_ALIAS"]/*' />
    [NativeTypeName("#define DIDFT_ALIAS 0x08000000")]
    public const int DIDFT_ALIAS = 0x08000000;

    /// <include file='DIDFT.xml' path='doc/member[@name="DIDFT.DIDFT_NOCOLLECTION"]/*' />
    [NativeTypeName("#define DIDFT_NOCOLLECTION 0x00FFFF00")]
    public const int DIDFT_NOCOLLECTION = 0x00FFFF00;
}
