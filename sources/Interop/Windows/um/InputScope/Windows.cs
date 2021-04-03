// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetInputScope([NativeTypeName("HWND")] IntPtr hwnd, InputScope inputscope);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetInputScopes([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, [NativeTypeName("UINT")] uint cInputScopes, [NativeTypeName("PWSTR *")] ushort** ppszPhraseList, [NativeTypeName("UINT")] uint cPhrases, [NativeTypeName("PWSTR")] ushort* pszRegExp, [NativeTypeName("PWSTR")] ushort* pszSRGS);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetInputScopeXML([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("PWSTR")] ushort* pszXML);

        [DllImport("msctf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetInputScopes2([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, [NativeTypeName("UINT")] uint cInputScopes, IEnumString* pEnumString, [NativeTypeName("PWSTR")] ushort* pszRegExp, [NativeTypeName("PWSTR")] ushort* pszSRGS);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ITfInputScope = new Guid(0xfde1eaee, 0x6924, 0x4cdf, 0x91, 0xe7, 0xda, 0x38, 0xcf, 0xf5, 0x55, 0x9d);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_ITfInputScope2 = new Guid(0x5731eaa0, 0x6bc2, 0x4681, 0xa5, 0x32, 0x92, 0xfb, 0xb7, 0x4d, 0x7c, 0x41);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_PROP_INPUTSCOPE = new Guid(0x1713dd5a, 0x68e7, 0x4a5b, 0x9a, 0xf6, 0x59, 0x2a, 0x59, 0x5c, 0x77, 0x8d);
    }
}
