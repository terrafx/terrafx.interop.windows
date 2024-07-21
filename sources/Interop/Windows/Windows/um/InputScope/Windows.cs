// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InputScope.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInputScope"]/*' />
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScope(HWND hwnd, InputScope inputscope);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInputScopes"]/*' />
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopes(HWND hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, uint cInputScopes, [NativeTypeName("PWSTR *")] char** ppszPhraseList, uint cPhrases, [NativeTypeName("PWSTR")] char* pszRegExp, [NativeTypeName("PWSTR")] char* pszSRGS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInputScopeXML"]/*' />
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopeXML(HWND hwnd, [NativeTypeName("PWSTR")] char* pszXML);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetInputScopes2"]/*' />
    [DllImport("msctf", ExactSpelling = true)]
    public static extern HRESULT SetInputScopes2(HWND hwnd, [NativeTypeName("const InputScope *")] InputScope* pInputScopes, uint cInputScopes, IEnumString* pEnumString, [NativeTypeName("PWSTR")] char* pszRegExp, [NativeTypeName("PWSTR")] char* pszSRGS);
}
