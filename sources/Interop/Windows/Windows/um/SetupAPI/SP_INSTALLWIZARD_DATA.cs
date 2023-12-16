// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA"]/*' />
public partial struct SP_INSTALLWIZARD_DATA
{
    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.DynamicPages"]/*' />
    [NativeTypeName("HPROPSHEETPAGE[20]")]
    public _DynamicPages_e__FixedBuffer DynamicPages;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.NumDynamicPages"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumDynamicPages;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.DynamicPageFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint DynamicPageFlags;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.PrivateFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint PrivateFlags;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.PrivateData"]/*' />
    public LPARAM PrivateData;

    /// <include file='SP_INSTALLWIZARD_DATA.xml' path='doc/member[@name="SP_INSTALLWIZARD_DATA.hwndWizardDlg"]/*' />
    public HWND hwndWizardDlg;

    /// <include file='_DynamicPages_e__FixedBuffer.xml' path='doc/member[@name="_DynamicPages_e__FixedBuffer"]/*' />
    public unsafe partial struct _DynamicPages_e__FixedBuffer
    {
        public HPROPSHEETPAGE e0;
        public HPROPSHEETPAGE e1;
        public HPROPSHEETPAGE e2;
        public HPROPSHEETPAGE e3;
        public HPROPSHEETPAGE e4;
        public HPROPSHEETPAGE e5;
        public HPROPSHEETPAGE e6;
        public HPROPSHEETPAGE e7;
        public HPROPSHEETPAGE e8;
        public HPROPSHEETPAGE e9;
        public HPROPSHEETPAGE e10;
        public HPROPSHEETPAGE e11;
        public HPROPSHEETPAGE e12;
        public HPROPSHEETPAGE e13;
        public HPROPSHEETPAGE e14;
        public HPROPSHEETPAGE e15;
        public HPROPSHEETPAGE e16;
        public HPROPSHEETPAGE e17;
        public HPROPSHEETPAGE e18;
        public HPROPSHEETPAGE e19;

        public ref HPROPSHEETPAGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (HPROPSHEETPAGE* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
