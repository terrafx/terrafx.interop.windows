// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CRYPT_PROVUI_FUNCS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("struct _CRYPT_PROVUI_DATA *")]
        public CRYPT_PROVUI_DATA* psUIData;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnMoreInfoClick;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnMoreInfoClickDefault;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnAdvancedClick;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnAdvancedClickDefault;
    }
}
