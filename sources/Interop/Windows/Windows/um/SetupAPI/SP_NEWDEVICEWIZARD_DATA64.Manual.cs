// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public partial struct SP_NEWDEVICEWIZARD_DATA64
{
    public SP_CLASSINSTALL_HEADER64 ClassInstallHeader;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("HPROPSHEETPAGE[20]")]
    public _DynamicPages_e__FixedBuffer DynamicPages;

    [NativeTypeName("DWORD")]
    public uint NumDynamicPages;

    public HWND hwndWizardDlg;

    [InlineArray(20)]
    public partial struct _DynamicPages_e__FixedBuffer
    {
        public HPROPSHEETPAGE e0;
    }
}
