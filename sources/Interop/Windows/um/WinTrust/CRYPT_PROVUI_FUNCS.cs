// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVUI_FUNCS
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("struct _CRYPT_PROVUI_DATA *")]
        public CRYPT_PROVUI_DATA* psUIData;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* stdcall<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClick;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* stdcall<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnMoreInfoClickDefault;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* stdcall<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClick;

        [NativeTypeName("PFN_PROVUI_CALL")]
        public delegate* stdcall<IntPtr, CRYPT_PROVIDER_DATA*, int> pfnOnAdvancedClickDefault;
    }
}
