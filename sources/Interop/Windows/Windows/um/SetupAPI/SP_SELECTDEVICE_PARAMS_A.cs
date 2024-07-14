// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A"]/*' />
public partial struct SP_SELECTDEVICE_PARAMS_A
{
    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.Title"]/*' />
    [NativeTypeName("CHAR[60]")]
    public _Title_e__FixedBuffer Title;

    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.Instructions"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _Instructions_e__FixedBuffer Instructions;

    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.ListLabel"]/*' />
    [NativeTypeName("CHAR[30]")]
    public _ListLabel_e__FixedBuffer ListLabel;

    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.SubTitle"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _SubTitle_e__FixedBuffer SubTitle;

    /// <include file='SP_SELECTDEVICE_PARAMS_A.xml' path='doc/member[@name="SP_SELECTDEVICE_PARAMS_A.Reserved"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Title_e__FixedBuffer.xml' path='doc/member[@name="_Title_e__FixedBuffer"]/*' />
    [InlineArray(60)]
    public partial struct _Title_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_Instructions_e__FixedBuffer.xml' path='doc/member[@name="_Instructions_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Instructions_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_ListLabel_e__FixedBuffer.xml' path='doc/member[@name="_ListLabel_e__FixedBuffer"]/*' />
    [InlineArray(30)]
    public partial struct _ListLabel_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_SubTitle_e__FixedBuffer.xml' path='doc/member[@name="_SubTitle_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _SubTitle_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
