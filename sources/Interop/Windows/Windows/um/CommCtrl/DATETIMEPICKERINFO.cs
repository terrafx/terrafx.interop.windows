// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct DATETIMEPICKERINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcCheck;

        [NativeTypeName("DWORD")]
        public uint stateCheck;

        public RECT rcButton;

        [NativeTypeName("DWORD")]
        public uint stateButton;

        public HWND hwndEdit;

        public HWND hwndUD;

        public HWND hwndDropDown;
    }
}
