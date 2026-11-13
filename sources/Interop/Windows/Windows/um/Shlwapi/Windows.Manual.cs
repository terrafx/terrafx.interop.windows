// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqNA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL IntlStrEqNA([NativeTypeName("LPCSTR")] sbyte* s1, [NativeTypeName("LPCSTR")] sbyte* s2, int nChar)
        => IntlStrEqWorkerA(BOOL.TRUE, s1, s2, nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqNIA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL IntlStrEqNIA([NativeTypeName("LPCSTR")] sbyte* s1, [NativeTypeName("LPCSTR")] sbyte* s2, int nChar)
        => IntlStrEqWorkerA(BOOL.FALSE, s1, s2, nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqNIW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL IntlStrEqNIW([NativeTypeName("LPCWSTR")] char* s1, [NativeTypeName("LPCWSTR")] char* s2, int nChar)
        => IntlStrEqWorkerW(BOOL.FALSE, s1, s2, nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqNW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL IntlStrEqNW([NativeTypeName("LPCWSTR")] char* s1, [NativeTypeName("LPCWSTR")] char* s2, int nChar)
        => IntlStrEqWorkerW(BOOL.TRUE, s1, s2, nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAKEDLLVERULL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong MAKEDLLVERULL(uint major, uint minor, uint build, uint qfe)
        => ((ulong)major << 48) | ((ulong)minor << 32) | ((ulong)build << 16) | qfe;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsHTMLFileA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL PathIsHTMLFileA([NativeTypeName("LPCSTR")] sbyte* pszPath)
    {
        fixed (byte* pszContentType = SZ.SZ_CONTENTTYPE_HTMLA)
        {
            return PathIsContentTypeA(pszPath, (sbyte*)pszContentType);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsHTMLFileW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL PathIsHTMLFileW([NativeTypeName("LPCWSTR")] char* pszPath)
    {
        fixed (char* pszContentType = SZ.SZ_CONTENTTYPE_HTMLW)
        {
            return PathIsContentTypeW(pszPath, pszContentType);
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlEscapeSpaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SHAnsiToTChar([NativeTypeName("PCSTR")] sbyte* pszSrc, [NativeTypeName("PWSTR")] char* pwszDst, int cwchBuf)
        => SHAnsiToUnicode(pszSrc, pwszDst, cwchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsFileUrlA"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SHTCharToAnsi([NativeTypeName("PCWSTR")] char* pwszSrc, [NativeTypeName("PSTR")] sbyte* pszDst, int cchBuf)
        => SHUnicodeToAnsi(pwszSrc, pszDst, cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsFileUrlW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SHTCharToUnicode([NativeTypeName("PCWSTR")] char* pwszSrc, [NativeTypeName("PWSTR")] char* pwszDst, int cwchBuf)
        => SHUnicodeToUnicode(pwszSrc, pwszDst, cwchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlUnescapeInPlace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SHUnicodeToTChar([NativeTypeName("PCWSTR")] char* pwszSrc, [NativeTypeName("PWSTR")] char* pwszDst, int cwchBuf)
        => SHUnicodeToUnicode(pwszSrc, pwszDst, cwchBuf);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL StrIntlEqNA([NativeTypeName("LPCSTR")] sbyte* s1, [NativeTypeName("LPCSTR")] sbyte* s2, int nChar)
        => StrIsIntlEqualA(BOOL.TRUE, s1, s2, nChar);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL StrIntlEqNIA([NativeTypeName("LPCSTR")] sbyte* s1, [NativeTypeName("LPCSTR")] sbyte* s2, int nChar)
        => StrIsIntlEqualA(BOOL.FALSE, s1, s2, nChar);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL StrIntlEqNIW([NativeTypeName("LPCWSTR")] char* s1, [NativeTypeName("LPCWSTR")] char* s2, int nChar)
        => StrIsIntlEqualW(BOOL.FALSE, s1, s2, nChar);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL StrIntlEqNW([NativeTypeName("LPCWSTR")] char* s1, [NativeTypeName("LPCWSTR")] char* s2, int nChar)
        => StrIsIntlEqualW(BOOL.TRUE, s1, s2, nChar);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HRESULT UrlEscapeSpaces([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszEscaped, [NativeTypeName("DWORD *")] uint* pcchEscaped)
        => UrlCanonicalizeW(pszUrl, pszEscaped, pcchEscaped, (uint)(URL.URL_ESCAPE_SPACES_ONLY | URL.URL_DONT_ESCAPE_EXTRA_INFO));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL UrlIsFileUrlA([NativeTypeName("PCSTR")] sbyte* pszURL)
        => UrlIsA(pszURL, URLIS.URLIS_FILEURL);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static BOOL UrlIsFileUrlW([NativeTypeName("PCWSTR")] char* pszURL)
        => UrlIsW(pszURL, URLIS.URLIS_FILEURL);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HRESULT UrlUnescapeInPlace([NativeTypeName("PWSTR")] char* pszUrl, [NativeTypeName("DWORD")] uint dwFlags)
        => UrlUnescapeW(pszUrl, null, null, dwFlags | (uint)(URL.URL_UNESCAPE_INPLACE));
}
