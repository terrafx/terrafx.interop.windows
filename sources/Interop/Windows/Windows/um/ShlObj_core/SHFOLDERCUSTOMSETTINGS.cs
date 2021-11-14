// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SHFOLDERCUSTOMSETTINGS
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("SHELLVIEWID *")]
        public Guid* pvid;

        [NativeTypeName("LPWSTR")]
        public ushort* pszWebViewTemplate;

        [NativeTypeName("DWORD")]
        public uint cchWebViewTemplate;

        [NativeTypeName("LPWSTR")]
        public ushort* pszWebViewTemplateVersion;

        [NativeTypeName("LPWSTR")]
        public ushort* pszInfoTip;

        [NativeTypeName("DWORD")]
        public uint cchInfoTip;

        [NativeTypeName("CLSID *")]
        public Guid* pclsid;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPWSTR")]
        public ushort* pszIconFile;

        [NativeTypeName("DWORD")]
        public uint cchIconFile;

        public int iIconIndex;

        [NativeTypeName("LPWSTR")]
        public ushort* pszLogo;

        [NativeTypeName("DWORD")]
        public uint cchLogo;
    }
}
