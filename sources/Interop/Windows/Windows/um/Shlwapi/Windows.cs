// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrChrA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("WORD")] ushort wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrChrW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("WCHAR")] char wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrChrIA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("WORD")] ushort wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrChrIW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("WCHAR")] char wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrNW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrChrNW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("WCHAR")] char wMatch, uint cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrNIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrChrNIW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("WCHAR")] char wMatch, uint cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNIA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNIW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpnA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnA([NativeTypeName("PCSTR")] sbyte* pszStr, [NativeTypeName("PCSTR")] sbyte* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpnW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnW([NativeTypeName("PCWSTR")] char* pszStr, [NativeTypeName("PCWSTR")] char* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpnIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnIA([NativeTypeName("PCSTR")] sbyte* pszStr, [NativeTypeName("PCSTR")] sbyte* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpnIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCSpnIW([NativeTypeName("PCWSTR")] char* pszStr, [NativeTypeName("PCWSTR")] char* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrDupA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrDupA([NativeTypeName("PCSTR")] sbyte* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrDupW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrDupW([NativeTypeName("PCWSTR")] char* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSizeEx"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrFormatByteSizeEx([NativeTypeName("ULONGLONG")] ulong ull, [NativeTypeName("SFBS_FLAGS")] int flags, [NativeTypeName("PWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSizeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatByteSizeA([NativeTypeName("DWORD")] uint dw, [NativeTypeName("PSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSize64A"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatByteSize64A([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSizeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrFormatByteSizeW([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatKBSizeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrFormatKBSizeW([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatKBSizeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrFormatKBSizeA([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFromTimeIntervalA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrFromTimeIntervalA([NativeTypeName("PSTR")] sbyte* pszOut, uint cchMax, [NativeTypeName("DWORD")] uint dwTimeMS, int digits);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFromTimeIntervalW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrFromTimeIntervalW([NativeTypeName("PWSTR")] char* pszOut, uint cchMax, [NativeTypeName("DWORD")] uint dwTimeMS, int digits);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrIsIntlEqualA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrIsIntlEqualA(BOOL fCaseSens, [NativeTypeName("PCSTR")] sbyte* pszString1, [NativeTypeName("PCSTR")] sbyte* pszString2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrIsIntlEqualW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrIsIntlEqualW(BOOL fCaseSens, [NativeTypeName("PCWSTR")] char* pszString1, [NativeTypeName("PCWSTR")] char* pszString2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCatA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrNCatA([NativeTypeName("PSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCatW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrNCatW([NativeTypeName("PWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2, int cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrPBrkA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrPBrkA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrPBrkW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrPBrkW([NativeTypeName("PCWSTR")] char* psz, [NativeTypeName("PCWSTR")] char* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChrA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRChrA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("PCSTR")] sbyte* pszEnd, [NativeTypeName("WORD")] ushort wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChrW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrRChrW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("PCWSTR")] char* pszEnd, [NativeTypeName("WCHAR")] char wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChrIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRChrIA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("PCSTR")] sbyte* pszEnd, [NativeTypeName("WORD")] ushort wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChrIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrRChrIW([NativeTypeName("PCWSTR")] char* pszStart, [NativeTypeName("PCWSTR")] char* pszEnd, [NativeTypeName("WCHAR")] char wMatch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRStrIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrRStrIA([NativeTypeName("PCSTR")] sbyte* pszSource, [NativeTypeName("PCSTR")] sbyte* pszLast, [NativeTypeName("PCSTR")] sbyte* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRStrIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrRStrIW([NativeTypeName("PCWSTR")] char* pszSource, [NativeTypeName("PCWSTR")] char* pszLast, [NativeTypeName("PCWSTR")] char* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrSpnA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrSpnA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrSpnW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrSpnW([NativeTypeName("PCWSTR")] char* psz, [NativeTypeName("PCWSTR")] char* pszSet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrStrA([NativeTypeName("PCSTR")] sbyte* pszFirst, [NativeTypeName("PCSTR")] sbyte* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrStrW([NativeTypeName("PCWSTR")] char* pszFirst, [NativeTypeName("PCWSTR")] char* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrStrIA([NativeTypeName("PCSTR")] sbyte* pszFirst, [NativeTypeName("PCSTR")] sbyte* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrStrIW([NativeTypeName("PCWSTR")] char* pszFirst, [NativeTypeName("PCWSTR")] char* pszSrch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrNW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrStrNW([NativeTypeName("PCWSTR")] char* pszFirst, [NativeTypeName("PCWSTR")] char* pszSrch, uint cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrNIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrStrNIW([NativeTypeName("PCWSTR")] char* pszFirst, [NativeTypeName("PCWSTR")] char* pszSrch, uint cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToIntA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrToIntA([NativeTypeName("PCSTR")] sbyte* pszSrc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToIntW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrToIntW([NativeTypeName("PCWSTR")] char* pszSrc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToIntExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToIntExA([NativeTypeName("PCSTR")] sbyte* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, int* piRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToIntExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToIntExW([NativeTypeName("PCWSTR")] char* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, int* piRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToInt64ExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToInt64ExA([NativeTypeName("PCSTR")] sbyte* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, [NativeTypeName("LONGLONG *")] long* pllRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToInt64ExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrToInt64ExW([NativeTypeName("PCWSTR")] char* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, [NativeTypeName("LONGLONG *")] long* pllRet);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrTrimA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrTrimA([NativeTypeName("PSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszTrimChars);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrTrimW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL StrTrimW([NativeTypeName("PWSTR")] char* psz, [NativeTypeName("PCWSTR")] char* pszTrimChars);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrCatW([NativeTypeName("PWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpIW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrCpyW([NativeTypeName("PWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpyNW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrCpyNW([NativeTypeName("PWSTR")] char* pszDst, [NativeTypeName("PCWSTR")] char* pszSrc, int cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatBuffW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PWSTR")]
    public static extern char* StrCatBuffW([NativeTypeName("PWSTR")] char* pszDest, [NativeTypeName("PCWSTR")] char* pszSrc, int cchDestBuffSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatBuffA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("PSTR")]
    public static extern sbyte* StrCatBuffA([NativeTypeName("PSTR")] sbyte* pszDest, [NativeTypeName("PCSTR")] sbyte* pszSrc, int cchDestBuffSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChrCmpIA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL ChrCmpIA([NativeTypeName("WORD")] ushort w1, [NativeTypeName("WORD")] ushort w2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChrCmpIW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL ChrCmpIW([NativeTypeName("WCHAR")] char w1, [NativeTypeName("WCHAR")] char w2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.wvnsprintfA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int wvnsprintfA([NativeTypeName("PSTR")] sbyte* pszDest, int cchDest, [NativeTypeName("PCSTR")] sbyte* pszFmt, [NativeTypeName("va_list")] sbyte* arglist);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.wvnsprintfW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int wvnsprintfW([NativeTypeName("PWSTR")] char* pszDest, int cchDest, [NativeTypeName("PCWSTR")] char* pszFmt, [NativeTypeName("va_list")] sbyte* arglist);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToStrA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToStrA(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR *")] sbyte** ppsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToStrW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToStrW(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR *")] char** ppsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToBufA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBufA(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToBufW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBufW(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStrDupA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHStrDupA([NativeTypeName("LPCSTR")] sbyte* psz, [NativeTypeName("LPWSTR *")] char** ppwsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStrDupW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHStrDupW([NativeTypeName("LPCWSTR")] char* psz, [NativeTypeName("LPWSTR *")] char** ppwsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLocalStrDupW"]/*' />
    public static HRESULT SHLocalStrDupW([NativeTypeName("PCWSTR")] char* psz, [NativeTypeName("PWSTR *")] char** ppsz)
    {
        *ppsz = StrDupW(psz);
        return (*ppsz) != null ? ((HRESULT)(0)) : ((HRESULT)(0x8007000E));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLocalStrDupA"]/*' />
    public static HRESULT SHLocalStrDupA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PSTR *")] sbyte** ppsz)
    {
        *ppsz = StrDupA(psz);
        return (*ppsz) != null ? ((HRESULT)(0)) : ((HRESULT)(0x8007000E));
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpLogicalW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpLogicalW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatChainW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint StrCatChainW([NativeTypeName("PWSTR")] char* pszDst, [NativeTypeName("DWORD")] uint cchDst, [NativeTypeName("DWORD")] uint ichAt, [NativeTypeName("PCWSTR")] char* pszSrc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToBSTR"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT StrRetToBSTR(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("BSTR *")] char** pbstr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLoadIndirectString"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHLoadIndirectString([NativeTypeName("PCWSTR")] char* pszSource, [NativeTypeName("PWSTR")] char* pszOutBuf, uint cchOutBuf, void** ppvReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharSpaceA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsCharSpaceA([NativeTypeName("CHAR")] sbyte wch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharSpaceW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsCharSpaceW([NativeTypeName("WCHAR")] char wch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpCA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpCA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpCW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpCW([NativeTypeName("LPCWSTR")] char* pszStr1, [NativeTypeName("LPCWSTR")] char* pszStr2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpICA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpICA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpICW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpICW([NativeTypeName("LPCWSTR")] char* pszStr1, [NativeTypeName("LPCWSTR")] char* pszStr2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNCA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNCA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNCW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNCW([NativeTypeName("LPCWSTR")] char* pszStr1, [NativeTypeName("LPCWSTR")] char* pszStr2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNICA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNICA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNICW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int StrCmpNICW([NativeTypeName("LPCWSTR")] char* pszStr1, [NativeTypeName("LPCWSTR")] char* pszStr2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqWorkerA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IntlStrEqWorkerA(BOOL fCaseSens, [NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IntlStrEqWorkerW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IntlStrEqWorkerW(BOOL fCaseSens, [NativeTypeName("LPCWSTR")] char* lpString1, [NativeTypeName("LPCWSTR")] char* lpString2, int nChar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddBackslashA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathAddBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddBackslashW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathAddBackslashW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddExtensionA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAddExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddExtensionW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAddExtensionW([NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("LPCWSTR")] char* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAppendA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAppendA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAppendW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathAppendW([NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("LPCWSTR")] char* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathBuildRootA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathBuildRootA([NativeTypeName("LPSTR")] sbyte* pszRoot, int iDrive);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathBuildRootW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathBuildRootW([NativeTypeName("LPWSTR")] char* pszRoot, int iDrive);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCanonicalizeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathCanonicalizeA([NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCanonicalizeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathCanonicalizeW([NativeTypeName("LPWSTR")] char* pszBuf, [NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCombineA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathCombineA([NativeTypeName("LPSTR")] sbyte* pszDest, [NativeTypeName("LPCSTR")] sbyte* pszDir, [NativeTypeName("LPCSTR")] sbyte* pszFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCombineW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathCombineW([NativeTypeName("LPWSTR")] char* pszDest, [NativeTypeName("LPCWSTR")] char* pszDir, [NativeTypeName("LPCWSTR")] char* pszFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathA(HDC hDC, [NativeTypeName("LPSTR")] sbyte* pszPath, uint dx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathW(HDC hDC, [NativeTypeName("LPWSTR")] char* pszPath, uint dx);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPathExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathExA([NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("LPCSTR")] sbyte* pszSrc, uint cchMax, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPathExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathCompactPathExW([NativeTypeName("LPWSTR")] char* pszOut, [NativeTypeName("LPCWSTR")] char* pszSrc, uint cchMax, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCommonPrefixA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathCommonPrefixA([NativeTypeName("LPCSTR")] sbyte* pszFile1, [NativeTypeName("LPCSTR")] sbyte* pszFile2, [NativeTypeName("LPSTR")] sbyte* achPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCommonPrefixW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathCommonPrefixW([NativeTypeName("LPCWSTR")] char* pszFile1, [NativeTypeName("LPCWSTR")] char* pszFile2, [NativeTypeName("LPWSTR")] char* achPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFileExistsA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathFileExistsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFileExistsW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL PathFileExistsW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindExtensionA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindExtensionA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindExtensionW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathFindExtensionW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindFileNameA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindFileNameA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindFileNameW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathFindFileNameW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindNextComponentA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathFindNextComponentA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindNextComponentW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathFindNextComponentW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindOnPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathFindOnPathA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("PZPCSTR")] sbyte** ppszOtherDirs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindOnPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathFindOnPathW([NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("PZPCWSTR")] char** ppszOtherDirs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindSuffixArrayA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* PathFindSuffixArrayA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("const LPCSTR *")] sbyte** apszSuffix, int iArraySize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindSuffixArrayW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCWSTR")]
    public static extern char* PathFindSuffixArrayW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("const LPCWSTR *")] char** apszSuffix, int iArraySize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetArgsA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathGetArgsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetArgsW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathGetArgsW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsLFNFileSpecA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsLFNFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsLFNFileSpecW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsLFNFileSpecW([NativeTypeName("LPCWSTR")] char* pszName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetCharTypeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint PathGetCharTypeA([NativeTypeName("UCHAR")] byte ch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetCharTypeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint PathGetCharTypeW([NativeTypeName("WCHAR")] char ch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetDriveNumberA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathGetDriveNumberA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetDriveNumberW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathGetDriveNumberW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectoryA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectoryW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectoryEmptyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryEmptyA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectoryEmptyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsDirectoryEmptyW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsFileSpecA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsFileSpecW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsFileSpecW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsPrefixA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsPrefixA([NativeTypeName("LPCSTR")] sbyte* pszPrefix, [NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsPrefixW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsPrefixW([NativeTypeName("LPCWSTR")] char* pszPrefix, [NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRelativeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRelativeA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRelativeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRelativeW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRootA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRootW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsRootW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSameRootA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSameRootA([NativeTypeName("LPCSTR")] sbyte* pszPath1, [NativeTypeName("LPCSTR")] sbyte* pszPath2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSameRootW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSameRootW([NativeTypeName("LPCWSTR")] char* pszPath1, [NativeTypeName("LPCWSTR")] char* pszPath2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsNetworkPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsNetworkPathA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsNetworkPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsNetworkPathW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServerA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServerW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServerShareA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerShareA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServerShareW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsUNCServerShareW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsContentTypeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsContentTypeA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszContentType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsContentTypeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsContentTypeW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("LPCWSTR")] char* pszContentType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsURLA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsURLA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsURLW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsURLW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakePrettyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakePrettyA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakePrettyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakePrettyW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpecA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMatchSpecA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("LPCSTR")] sbyte* pszSpec);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpecW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMatchSpecW([NativeTypeName("LPCWSTR")] char* pszFile, [NativeTypeName("LPCWSTR")] char* pszSpec);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpecExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathMatchSpecExA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("LPCSTR")] sbyte* pszSpec, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpecExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathMatchSpecExW([NativeTypeName("LPCWSTR")] char* pszFile, [NativeTypeName("LPCWSTR")] char* pszSpec, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathParseIconLocationA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathParseIconLocationA([NativeTypeName("LPSTR")] sbyte* pszIconFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathParseIconLocationW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int PathParseIconLocationW([NativeTypeName("LPWSTR")] char* pszIconFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathQuoteSpacesA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathQuoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathQuoteSpacesW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathQuoteSpacesW([NativeTypeName("LPWSTR")] char* lpsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRelativePathToA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRelativePathToA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszFrom, [NativeTypeName("DWORD")] uint dwAttrFrom, [NativeTypeName("LPCSTR")] sbyte* pszTo, [NativeTypeName("DWORD")] uint dwAttrTo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRelativePathToW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRelativePathToW([NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("LPCWSTR")] char* pszFrom, [NativeTypeName("DWORD")] uint dwAttrFrom, [NativeTypeName("LPCWSTR")] char* pszTo, [NativeTypeName("DWORD")] uint dwAttrTo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveArgsA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveArgsA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveArgsW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveArgsW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBackslashA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathRemoveBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBackslashW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathRemoveBackslashW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBlanksA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveBlanksA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBlanksW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveBlanksW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveExtensionA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveExtensionW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathRemoveExtensionW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveFileSpecA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRemoveFileSpecA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveFileSpecW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRemoveFileSpecW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRenameExtensionA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRenameExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRenameExtensionW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathRenameExtensionW([NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("LPCWSTR")] char* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSearchAndQualifyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathSearchAndQualifyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSearchAndQualifyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathSearchAndQualifyW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("LPWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSetDlgItemPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathSetDlgItemPathA(HWND hDlg, int id, [NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSetDlgItemPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathSetDlgItemPathW(HWND hDlg, int id, [NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSkipRootA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* PathSkipRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSkipRootW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern char* PathSkipRootW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathStripPathA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathStripPathW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripToRootA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathStripToRootA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripToRootW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathStripToRootW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnquoteSpacesA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnquoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnquoteSpacesW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnquoteSpacesW([NativeTypeName("LPWSTR")] char* lpsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakeSystemFolderA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakeSystemFolderW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathMakeSystemFolderW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnmakeSystemFolderA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnmakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnmakeSystemFolderW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnmakeSystemFolderW([NativeTypeName("LPCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSystemFolderA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwAttrb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSystemFolderW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathIsSystemFolderW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("DWORD")] uint dwAttrb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUndecorateA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathUndecorateA([NativeTypeName("LPSTR")] sbyte* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUndecorateW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void PathUndecorateW([NativeTypeName("LPWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnExpandEnvStringsA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnExpandEnvStringsA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnExpandEnvStringsW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL PathUnExpandEnvStringsW([NativeTypeName("LPCWSTR")] char* pszPath, [NativeTypeName("LPWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCompareA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int UrlCompareA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, BOOL fIgnoreSlash);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCompareW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int UrlCompareW([NativeTypeName("PCWSTR")] char* psz1, [NativeTypeName("PCWSTR")] char* psz2, BOOL fIgnoreSlash);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCombineA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCombineA([NativeTypeName("PCSTR")] sbyte* pszBase, [NativeTypeName("PCSTR")] sbyte* pszRelative, [NativeTypeName("PSTR")] sbyte* pszCombined, [NativeTypeName("DWORD *")] uint* pcchCombined, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCombineW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCombineW([NativeTypeName("PCWSTR")] char* pszBase, [NativeTypeName("PCWSTR")] char* pszRelative, [NativeTypeName("PWSTR")] char* pszCombined, [NativeTypeName("DWORD *")] uint* pcchCombined, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCanonicalizeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCanonicalizeA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszCanonicalized, [NativeTypeName("DWORD *")] uint* pcchCanonicalized, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCanonicalizeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCanonicalizeW([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszCanonicalized, [NativeTypeName("DWORD *")] uint* pcchCanonicalized, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsOpaqueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsOpaqueA([NativeTypeName("PCSTR")] sbyte* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsOpaqueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsOpaqueW([NativeTypeName("PCWSTR")] char* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsNoHistoryA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsNoHistoryA([NativeTypeName("PCSTR")] sbyte* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsNoHistoryW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsNoHistoryW([NativeTypeName("PCWSTR")] char* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsA([NativeTypeName("PCSTR")] sbyte* pszUrl, URLIS UrlIs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL UrlIsW([NativeTypeName("PCWSTR")] char* pszUrl, URLIS UrlIs);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetLocationA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* UrlGetLocationA([NativeTypeName("PCSTR")] sbyte* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetLocationW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LPCWSTR")]
    public static extern char* UrlGetLocationW([NativeTypeName("PCWSTR")] char* pszURL);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlUnescapeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlUnescapeA([NativeTypeName("PSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszUnescaped, [NativeTypeName("DWORD *")] uint* pcchUnescaped, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlUnescapeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlUnescapeW([NativeTypeName("PWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszUnescaped, [NativeTypeName("DWORD *")] uint* pcchUnescaped, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlEscapeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlEscapeA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszEscaped, [NativeTypeName("DWORD *")] uint* pcchEscaped, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlEscapeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlEscapeW([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszEscaped, [NativeTypeName("DWORD *")] uint* pcchEscaped, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCreateFromPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCreateFromPathA([NativeTypeName("PCSTR")] sbyte* pszPath, [NativeTypeName("PSTR")] sbyte* pszUrl, [NativeTypeName("DWORD *")] uint* pcchUrl, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCreateFromPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlCreateFromPathW([NativeTypeName("PCWSTR")] char* pszPath, [NativeTypeName("PWSTR")] char* pszUrl, [NativeTypeName("DWORD *")] uint* pcchUrl, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCreateFromUrlA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszPath, [NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCreateFromUrlW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlW([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszPath, [NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCreateFromUrlAlloc"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT PathCreateFromUrlAlloc([NativeTypeName("PCWSTR")] char* pszIn, [NativeTypeName("PWSTR *")] char** ppszOut, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlHashA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlHashA([NativeTypeName("PCSTR")] sbyte* pszUrl, byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlHashW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlHashW([NativeTypeName("PCWSTR")] char* pszUrl, byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetPartW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlGetPartW([NativeTypeName("PCWSTR")] char* pszIn, [NativeTypeName("PWSTR")] char* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwPart, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetPartA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlGetPartA([NativeTypeName("PCSTR")] sbyte* pszIn, [NativeTypeName("PSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwPart, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlApplySchemeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlApplySchemeA([NativeTypeName("PCSTR")] sbyte* pszIn, [NativeTypeName("PSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlApplySchemeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlApplySchemeW([NativeTypeName("PCWSTR")] char* pszIn, [NativeTypeName("PWSTR")] char* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HashData"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT HashData(byte* pbData, [NativeTypeName("DWORD")] uint cbData, byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlFixupW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT UrlFixupW([NativeTypeName("PCWSTR")] char* pcszUrl, [NativeTypeName("PWSTR")] char* pszTranslatedUrl, [NativeTypeName("DWORD")] uint cchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ParseURLA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ParseURLA([NativeTypeName("LPCSTR")] sbyte* pcszURL, PARSEDURLA* ppu);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ParseURLW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ParseURLW([NativeTypeName("LPCWSTR")] char* pcszURL, PARSEDURLW* ppu);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteEmptyKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteEmptyKeyA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteEmptyKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteEmptyKeyW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteKeyA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteKeyW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDuplicateHKey"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HKEY SHRegDuplicateHKey(HKEY hkey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteValueA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHDeleteValueW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHGetValueA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHGetValueW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHSetValueA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* pvData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHSetValueW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* pvData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetValueFromHKCUHKLM"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetValueFromHKCUHKLM([NativeTypeName("PCWSTR")] char* pwszKey, [NativeTypeName("PCWSTR")] char* pwszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetBoolValueFromHKCUHKLM"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolValueFromHKCUHKLM([NativeTypeName("PCWSTR")] char* pszKey, [NativeTypeName("PCWSTR")] char* pszValue, BOOL fDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryValueExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryValueExA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryValueExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryValueExW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumKeyExA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumKeyExA(HKEY hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszName, [NativeTypeName("LPDWORD")] uint* pcchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumKeyExW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumKeyExW(HKEY hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pszName, [NativeTypeName("LPDWORD")] uint* pcchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumValueA(HKEY hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("PSTR")] sbyte* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHEnumValueW(HKEY hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("PWSTR")] char* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryInfoKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryInfoKeyA(HKEY hkey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryInfoKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHQueryInfoKeyW(HKEY hkey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCopyKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHCopyKeyA(HKEY hkeySrc, [NativeTypeName("LPCSTR")] sbyte* pszSrcSubKey, HKEY hkeyDest, [NativeTypeName("DWORD")] uint fReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCopyKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHCopyKeyW(HKEY hkeySrc, [NativeTypeName("LPCWSTR")] char* pszSrcSubKey, HKEY hkeyDest, [NativeTypeName("DWORD")] uint fReserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetPathA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* pcszSubKey, [NativeTypeName("LPCSTR")] sbyte* pcszValue, [NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetPathW(HKEY hKey, [NativeTypeName("LPCWSTR")] char* pcszSubKey, [NativeTypeName("LPCWSTR")] char* pcszValue, [NativeTypeName("LPWSTR")] char* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetPathA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetPathA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* pcszSubKey, [NativeTypeName("LPCSTR")] sbyte* pcszValue, [NativeTypeName("LPCSTR")] sbyte* pcszPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetPathW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetPathW(HKEY hKey, [NativeTypeName("LPCWSTR")] char* pcszSubKey, [NativeTypeName("LPCWSTR")] char* pcszValue, [NativeTypeName("LPCWSTR")] char* pcszPath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegCreateUSKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCreateUSKeyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("REGSAM")] uint samDesired, HUSKEY hRelativeUSKey, [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegCreateUSKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCreateUSKeyW([NativeTypeName("LPCWSTR")] char* pwzPath, [NativeTypeName("REGSAM")] uint samDesired, HUSKEY hRelativeUSKey, [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegOpenUSKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegOpenUSKeyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("REGSAM")] uint samDesired, HUSKEY hRelativeUSKey, [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey, BOOL fIgnoreHKCU);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegOpenUSKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegOpenUSKeyW([NativeTypeName("LPCWSTR")] char* pwzPath, [NativeTypeName("REGSAM")] uint samDesired, HUSKEY hRelativeUSKey, [NativeTypeName("PHUSKEY")] HUSKEY* phNewUSKey, BOOL fIgnoreHKCU);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryUSValueA(HUSKEY hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryUSValueW(HUSKEY hUSKey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegWriteUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegWriteUSValueA(HUSKEY hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegWriteUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegWriteUSValueW(HUSKEY hUSKey, [NativeTypeName("LPCWSTR")] char* pwzValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteUSValueA(HUSKEY hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, SHREGDEL_FLAGS delRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteUSValueW(HUSKEY hUSKey, [NativeTypeName("LPCWSTR")] char* pwzValue, SHREGDEL_FLAGS delRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteEmptyUSKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteEmptyUSKeyW(HUSKEY hUSKey, [NativeTypeName("LPCWSTR")] char* pwzSubKey, SHREGDEL_FLAGS delRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteEmptyUSKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegDeleteEmptyUSKeyA(HUSKEY hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, SHREGDEL_FLAGS delRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSKeyA(HUSKEY hUSKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszName, [NativeTypeName("LPDWORD")] uint* pcchName, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSKeyW(HUSKEY hUSKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pwzName, [NativeTypeName("LPDWORD")] uint* pcchName, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSValueA(HUSKEY hUSkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegEnumUSValueW(HUSKEY hUSkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] char* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryInfoUSKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryInfoUSKeyA(HUSKEY hUSKey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryInfoUSKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegQueryInfoUSKeyW(HUSKEY hUSKey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen, SHREGENUM_FLAGS enumRegFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegCloseUSKey"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegCloseUSKey(HUSKEY hUSKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegGetUSValueW([NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int SHRegSetUSValueW([NativeTypeName("LPCWSTR")] char* pwzSubKey, [NativeTypeName("LPCWSTR")] char* pwzValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetIntW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHRegGetIntW(HKEY hk, [NativeTypeName("PCWSTR")] char* pwzKey, int iDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetBoolUSValueA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, BOOL fIgnoreHKCU, BOOL fDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetBoolUSValueW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHRegGetBoolUSValueW([NativeTypeName("LPCWSTR")] char* pszSubKey, [NativeTypeName("LPCWSTR")] char* pszValue, BOOL fIgnoreHKCU, BOOL fDefault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocCreate"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocCreate([NativeTypeName("CLSID")] Guid clsid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetAssocKeys"]/*' />
    [DllImport("windows.storage", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint SHGetAssocKeys(IQueryAssociations* pqa, HKEY* rgKeys, [NativeTypeName("DWORD")] uint cKeys);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryStringA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringA([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCSTR")] sbyte* pszAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, [NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryStringW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringW([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] char* pszAssoc, [NativeTypeName("LPCWSTR")] char* pszExtra, [NativeTypeName("LPWSTR")] char* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryStringByKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringByKeyA([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, HKEY hkAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, [NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryStringByKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryStringByKeyW([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, HKEY hkAssoc, [NativeTypeName("LPCWSTR")] char* pszExtra, [NativeTypeName("LPWSTR")] char* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryKeyA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryKeyA([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCSTR")] sbyte* pszAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, HKEY* phkeyOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryKeyW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocQueryKeyW([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] char* pszAssoc, [NativeTypeName("LPCWSTR")] char* pszExtra, HKEY* phkeyOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocIsDangerous"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL AssocIsDangerous([NativeTypeName("PCWSTR")] char* pszAssoc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocGetPerceivedType"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT AssocGetPerceivedType([NativeTypeName("PCWSTR")] char* pszExt, PERCEIVED* ptype, [NativeTypeName("PERCEIVEDFLAG *")] uint* pflag, [NativeTypeName("PWSTR *")] char** ppszType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStreamA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream* SHOpenRegStreamA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint grfMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStreamW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream* SHOpenRegStreamW(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubkey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD")] uint grfMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStream2A"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream* SHOpenRegStream2A(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint grfMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStream2W"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream* SHOpenRegStream2W(HKEY hkey, [NativeTypeName("LPCWSTR")] char* pszSubkey, [NativeTypeName("LPCWSTR")] char* pszValue, [NativeTypeName("DWORD")] uint grfMode);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateStreamOnFileA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("DWORD")] uint grfMode, IStream** ppstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateStreamOnFileW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileW([NativeTypeName("LPCWSTR")] char* pszFile, [NativeTypeName("DWORD")] uint grfMode, IStream** ppstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateStreamOnFileEx"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateStreamOnFileEx([NativeTypeName("LPCWSTR")] char* pszFile, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint dwAttributes, BOOL fCreate, IStream* pstmTemplate, IStream** ppstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateMemStream"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern IStream* SHCreateMemStream([NativeTypeName("const BYTE *")] byte* pInit, uint cbInit);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAcceptLanguagesA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT GetAcceptLanguagesA([NativeTypeName("LPSTR")] sbyte* pszLanguages, [NativeTypeName("DWORD *")] uint* pcchLanguages);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAcceptLanguagesW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT GetAcceptLanguagesW([NativeTypeName("LPWSTR")] char* pszLanguages, [NativeTypeName("DWORD *")] uint* pcchLanguages);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_Set"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void IUnknown_Set(IUnknown** ppunk, IUnknown* punk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_AtomicRelease"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void IUnknown_AtomicRelease(void** ppunk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_GetWindow"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_GetWindow(IUnknown* punk, HWND* phwnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_SetSite"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_SetSite(IUnknown* punk, IUnknown* punkSite);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_GetSite"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_GetSite(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IUnknown_QueryService"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IUnknown_QueryService(IUnknown* punk, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_Read"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Read(IStream* pstm, void* pv, [NativeTypeName("ULONG")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_Write"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Write(IStream* pstm, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_Reset"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Reset(IStream* pstm);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_Size"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Size(IStream* pstm, ULARGE_INTEGER* pui);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ConnectToConnectionPoint"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT ConnectToConnectionPoint(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riidEvent, BOOL fConnect, IUnknown* punkTarget, [NativeTypeName("DWORD *")] uint* pdwCookie, IConnectionPoint** ppcpOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_ReadPidl"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_ReadPidl(IStream* pstm, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_WritePidl"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_WritePidl(IStream* pstm, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlWrite);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_ReadStr"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_ReadStr(IStream* pstm, [NativeTypeName("PWSTR *")] char** ppsz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_WriteStr"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_WriteStr(IStream* pstm, [NativeTypeName("PCWSTR")] char* psz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IStream_Copy"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT IStream_Copy(IStream* pstmFrom, IStream* pstmTo, [NativeTypeName("DWORD")] uint cb);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetViewStatePropertyBag"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetViewStatePropertyBag([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("PCWSTR")] char* pszBagName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFormatDateTimeA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHFormatDateTimeA([NativeTypeName("const __unaligned FILETIME *")] FILETIME* pft, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPSTR")] sbyte* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFormatDateTimeW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHFormatDateTimeW([NativeTypeName("const __unaligned FILETIME *")] FILETIME* pft, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPWSTR")] char* pszBuf, uint cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAnsiToUnicode"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHAnsiToUnicode([NativeTypeName("PCSTR")] sbyte* pszSrc, [NativeTypeName("PWSTR")] char* pwszDst, int cwchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAnsiToAnsi"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHAnsiToAnsi([NativeTypeName("PCSTR")] sbyte* pszSrc, [NativeTypeName("PSTR")] sbyte* pszDst, int cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUnicodeToAnsi"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHUnicodeToAnsi([NativeTypeName("PCWSTR")] char* pwszSrc, [NativeTypeName("PSTR")] sbyte* pszDst, int cchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUnicodeToUnicode"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHUnicodeToUnicode([NativeTypeName("PCWSTR")] char* pwzSrc, [NativeTypeName("PWSTR")] char* pwzDst, int cwchBuf);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHMessageBoxCheckA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHMessageBoxCheckA(HWND hwnd, [NativeTypeName("LPCSTR")] sbyte* pszText, [NativeTypeName("LPCSTR")] sbyte* pszCaption, uint uType, int iDefault, [NativeTypeName("LPCSTR")] sbyte* pszRegVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHMessageBoxCheckW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int SHMessageBoxCheckW(HWND hwnd, [NativeTypeName("LPCWSTR")] char* pszText, [NativeTypeName("LPCWSTR")] char* pszCaption, uint uType, int iDefault, [NativeTypeName("LPCWSTR")] char* pszRegVal);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSendMessageBroadcastA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern LRESULT SHSendMessageBroadcastA(uint uMsg, WPARAM wParam, LPARAM lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSendMessageBroadcastW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern LRESULT SHSendMessageBroadcastW(uint uMsg, WPARAM wParam, LPARAM lParam);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStripMneumonicA"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("CHAR")]
    public static extern sbyte SHStripMneumonicA([NativeTypeName("LPSTR")] sbyte* pszMenu);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStripMneumonicW"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [return: NativeTypeName("WCHAR")]
    public static extern char SHStripMneumonicW([NativeTypeName("LPWSTR")] char* pszMenu);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsOS"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsOS([NativeTypeName("DWORD")] uint dwOS);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAllocShared"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HANDLE SHAllocShared([NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwProcessId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFreeShared"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHFreeShared(HANDLE hData, [NativeTypeName("DWORD")] uint dwProcessId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLockShared"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void* SHLockShared(HANDLE hData, [NativeTypeName("DWORD")] uint dwProcessId);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHUnlockShared"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHUnlockShared(void* pvData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WhichPlatform"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern uint WhichPlatform();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QISearch"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT QISearch(void* that, [NativeTypeName("LPCQITAB")] QITAB* pqit, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHIsLowMemoryMachine"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHIsLowMemoryMachine([NativeTypeName("DWORD")] uint dwType);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetMenuPosFromID"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern int GetMenuPosFromID(HMENU hmenu, uint id);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetInverseCMAP"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetInverseCMAP(byte* pbMap, [NativeTypeName("ULONG")] uint cbMap);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAutoComplete"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHAutoComplete(HWND hwndEdit, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateThreadRef"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHCreateThreadRef([NativeTypeName("LONG *")] int* pcRef, IUnknown** ppunk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetThreadRef"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHSetThreadRef(IUnknown* punk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetThreadRef"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHGetThreadRef(IUnknown** ppunk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSkipJunction"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHSkipJunction(IBindCtx* pbc, [NativeTypeName("const CLSID *")] Guid* pclsid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateThread"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SHCreateThread([NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc, void* pData, [NativeTypeName("SHCT_FLAGS")] uint flags, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateThreadWithHandle"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL SHCreateThreadWithHandle([NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc, void* pData, [NativeTypeName("SHCT_FLAGS")] uint flags, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback, HANDLE* pHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessReference"]/*' />
    [DllImport("api-ms-win-shcore-thread-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void SetProcessReference(IUnknown* punk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessReference"]/*' />
    [DllImport("api-ms-win-shcore-thread-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT GetProcessReference(IUnknown** punk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHReleaseThreadRef"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HRESULT SHReleaseThreadRef();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellPalette"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern HPALETTE SHCreateShellPalette(HDC hdc);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorRGBToHLS"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern void ColorRGBToHLS(COLORREF clrRGB, [NativeTypeName("WORD *")] ushort* pwHue, [NativeTypeName("WORD *")] ushort* pwLuminance, [NativeTypeName("WORD *")] ushort* pwSaturation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorHLSToRGB"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern COLORREF ColorHLSToRGB([NativeTypeName("WORD")] ushort wHue, [NativeTypeName("WORD")] ushort wLuminance, [NativeTypeName("WORD")] ushort wSaturation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ColorAdjustLuma"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern COLORREF ColorAdjustLuma(COLORREF clrRGB, int n, BOOL fScale);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsInternetESCEnabled"]/*' />
    [DllImport("shlwapi", ExactSpelling = true)]
    public static extern BOOL IsInternetESCEnabled();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STIF_DEFAULT"]/*' />
    [NativeTypeName("#define STIF_DEFAULT 0x00000000L")]
    public const int STIF_DEFAULT = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STIF_SUPPORT_HEX"]/*' />
    [NativeTypeName("#define STIF_SUPPORT_HEX 0x00000001L")]
    public const int STIF_SUPPORT_HEX = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToStr"]/*' />
    [NativeTypeName("#define StrRetToStr StrRetToStrW")]
    public static delegate*<STRRET*, ITEMIDLIST*, char**, HRESULT> StrRetToStr => &StrRetToStrW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRetToBuf"]/*' />
    [NativeTypeName("#define StrRetToBuf StrRetToBufW")]
    public static delegate*<STRRET*, ITEMIDLIST*, char*, uint, HRESULT> StrRetToBuf => &StrRetToBufW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStrDup"]/*' />
    [NativeTypeName("#define SHStrDup SHStrDupW")]
    public static delegate*<char*, char**, HRESULT> SHStrDup => &SHStrDupW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHLocalStrDup"]/*' />
    [NativeTypeName("#define SHLocalStrDup SHLocalStrDupW")]
    public static delegate*<char*, char**, HRESULT> SHLocalStrDup => &SHLocalStrDupW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IsCharSpace"]/*' />
    [NativeTypeName("#define IsCharSpace IsCharSpaceW")]
    public static delegate*<char, BOOL> IsCharSpace => &IsCharSpaceW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpC"]/*' />
    [NativeTypeName("#define StrCmpC StrCmpCW")]
    public static delegate*<char*, char*, int> StrCmpC => &StrCmpCW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpIC"]/*' />
    [NativeTypeName("#define StrCmpIC StrCmpICW")]
    public static delegate*<char*, char*, int> StrCmpIC => &StrCmpICW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChr"]/*' />
    [NativeTypeName("#define StrChr StrChrW")]
    public static delegate*<char*, char, char*> StrChr => &StrChrW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChr"]/*' />
    [NativeTypeName("#define StrRChr StrRChrW")]
    public static delegate*<char*, char*, char, char*> StrRChr => &StrRChrW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrChrI"]/*' />
    [NativeTypeName("#define StrChrI StrChrIW")]
    public static delegate*<char*, char, char*> StrChrI => &StrChrIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRChrI"]/*' />
    [NativeTypeName("#define StrRChrI StrRChrIW")]
    public static delegate*<char*, char*, char, char*> StrRChrI => &StrRChrIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpN"]/*' />
    [NativeTypeName("#define StrCmpN StrCmpNW")]
    public static delegate*<char*, char*, int, int> StrCmpN => &StrCmpNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNI"]/*' />
    [NativeTypeName("#define StrCmpNI StrCmpNIW")]
    public static delegate*<char*, char*, int, int> StrCmpNI => &StrCmpNIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStr"]/*' />
    [NativeTypeName("#define StrStr StrStrW")]
    public static delegate*<char*, char*, char*> StrStr => &StrStrW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrStrI"]/*' />
    [NativeTypeName("#define StrStrI StrStrIW")]
    public static delegate*<char*, char*, char*> StrStrI => &StrStrIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrDup"]/*' />
    [NativeTypeName("#define StrDup StrDupW")]
    public static delegate*<char*, char*> StrDup => &StrDupW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrRStrI"]/*' />
    [NativeTypeName("#define StrRStrI StrRStrIW")]
    public static delegate*<char*, char*, char*, char*> StrRStrI => &StrRStrIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpn"]/*' />
    [NativeTypeName("#define StrCSpn StrCSpnW")]
    public static delegate*<char*, char*, int> StrCSpn => &StrCSpnW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCSpnI"]/*' />
    [NativeTypeName("#define StrCSpnI StrCSpnIW")]
    public static delegate*<char*, char*, int> StrCSpnI => &StrCSpnIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrSpn"]/*' />
    [NativeTypeName("#define StrSpn StrSpnW")]
    public static delegate*<char*, char*, int> StrSpn => &StrSpnW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToInt"]/*' />
    [NativeTypeName("#define StrToInt StrToIntW")]
    public static delegate*<char*, int> StrToInt => &StrToIntW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrPBrk"]/*' />
    [NativeTypeName("#define StrPBrk StrPBrkW")]
    public static delegate*<char*, char*, char*> StrPBrk => &StrPBrkW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToIntEx"]/*' />
    [NativeTypeName("#define StrToIntEx StrToIntExW")]
    public static delegate*<char*, int, int*, BOOL> StrToIntEx => &StrToIntExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToInt64Ex"]/*' />
    [NativeTypeName("#define StrToInt64Ex StrToInt64ExW")]
    public static delegate*<char*, int, long*, BOOL> StrToInt64Ex => &StrToInt64ExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFromTimeInterval"]/*' />
    [NativeTypeName("#define StrFromTimeInterval StrFromTimeIntervalW")]
    public static delegate*<char*, uint, uint, int, int> StrFromTimeInterval => &StrFromTimeIntervalW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSize"]/*' />
    [NativeTypeName("#define StrFormatByteSize StrFormatByteSizeW")]
    public static delegate*<long, char*, uint, char*> StrFormatByteSize => &StrFormatByteSizeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatByteSize64"]/*' />
    [NativeTypeName("#define StrFormatByteSize64 StrFormatByteSizeW")]
    public static delegate*<long, char*, uint, char*> StrFormatByteSize64 => &StrFormatByteSizeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrFormatKBSize"]/*' />
    [NativeTypeName("#define StrFormatKBSize StrFormatKBSizeW")]
    public static delegate*<long, char*, uint, char*> StrFormatKBSize => &StrFormatKBSizeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCat"]/*' />
    [NativeTypeName("#define StrNCat StrNCatW")]
    public static delegate*<char*, char*, int, char*> StrNCat => &StrNCatW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrTrim"]/*' />
    [NativeTypeName("#define StrTrim StrTrimW")]
    public static delegate*<char*, char*, BOOL> StrTrim => &StrTrimW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatBuff"]/*' />
    [NativeTypeName("#define StrCatBuff StrCatBuffW")]
    public static delegate*<char*, char*, int, char*> StrCatBuff => &StrCatBuffW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ChrCmpI"]/*' />
    [NativeTypeName("#define ChrCmpI ChrCmpIW")]
    public static delegate*<char, char, BOOL> ChrCmpI => &ChrCmpIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.wvnsprintf"]/*' />
    [NativeTypeName("#define wvnsprintf wvnsprintfW")]
    public static delegate*<char*, int, char*, sbyte*, int> wvnsprintf => &wvnsprintfW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrIsIntlEqual"]/*' />
    [NativeTypeName("#define StrIsIntlEqual StrIsIntlEqualW")]
    public static delegate*<BOOL, char*, char*, int, BOOL> StrIsIntlEqual => &StrIsIntlEqualW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNC"]/*' />
    [NativeTypeName("#define StrCmpNC StrCmpNCW")]
    public static delegate*<char*, char*, int, int> StrCmpNC => &StrCmpNCW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpNIC"]/*' />
    [NativeTypeName("#define StrCmpNIC StrCmpNICW")]
    public static delegate*<char*, char*, int, int> StrCmpNIC => &StrCmpNICW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatA"]/*' />
    [NativeTypeName("#define StrCatA lstrcatA")]
    public static delegate*<sbyte*, sbyte*, sbyte*> StrCatA => &lstrcatA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpA"]/*' />
    [NativeTypeName("#define StrCmpA lstrcmpA")]
    public static delegate*<sbyte*, sbyte*, int> StrCmpA => &lstrcmpA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpIA"]/*' />
    [NativeTypeName("#define StrCmpIA lstrcmpiA")]
    public static delegate*<sbyte*, sbyte*, int> StrCmpIA => &lstrcmpiA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpyA"]/*' />
    [NativeTypeName("#define StrCpyA lstrcpyA")]
    public static delegate*<sbyte*, sbyte*, sbyte*> StrCpyA => &lstrcpyA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpyNA"]/*' />
    [NativeTypeName("#define StrCpyNA lstrcpynA")]
    public static delegate*<sbyte*, sbyte*, int, sbyte*> StrCpyNA => &lstrcpynA;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrToLong"]/*' />
    [NativeTypeName("#define StrToLong StrToInt")]
    public static delegate*<char*, int> StrToLong => &StrToIntW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCmp"]/*' />
    [NativeTypeName("#define StrNCmp StrCmpN")]
    public static delegate*<char*, char*, int, int> StrNCmp => &StrCmpNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCmpI"]/*' />
    [NativeTypeName("#define StrNCmpI StrCmpNI")]
    public static delegate*<char*, char*, int, int> StrNCmpI => &StrCmpNIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrNCpy"]/*' />
    [NativeTypeName("#define StrNCpy StrCpyN")]
    public static delegate*<char*, char*, int, char*> StrNCpy => &StrCpyNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCatN"]/*' />
    [NativeTypeName("#define StrCatN StrNCat")]
    public static delegate*<char*, char*, int, char*> StrCatN => &StrNCatW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCat"]/*' />
    [NativeTypeName("#define StrCat StrCatW")]
    public static delegate*<char*, char*, char*> StrCat => &StrCatW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmp"]/*' />
    [NativeTypeName("#define StrCmp StrCmpW")]
    public static delegate*<char*, char*, int> StrCmp => &StrCmpW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCmpI"]/*' />
    [NativeTypeName("#define StrCmpI StrCmpIW")]
    public static delegate*<char*, char*, int> StrCmpI => &StrCmpIW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpy"]/*' />
    [NativeTypeName("#define StrCpy StrCpyW")]
    public static delegate*<char*, char*, char*> StrCpy => &StrCpyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StrCpyN"]/*' />
    [NativeTypeName("#define StrCpyN StrCpyNW")]
    public static delegate*<char*, char*, int, char*> StrCpyN => &StrCpyNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddBackslash"]/*' />
    [NativeTypeName("#define PathAddBackslash PathAddBackslashW")]
    public static delegate*<char*, char*> PathAddBackslash => &PathAddBackslashW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAddExtension"]/*' />
    [NativeTypeName("#define PathAddExtension PathAddExtensionW")]
    public static delegate*<char*, char*, BOOL> PathAddExtension => &PathAddExtensionW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathBuildRoot"]/*' />
    [NativeTypeName("#define PathBuildRoot PathBuildRootW")]
    public static delegate*<char*, int, char*> PathBuildRoot => &PathBuildRootW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCombine"]/*' />
    [NativeTypeName("#define PathCombine PathCombineW")]
    public static delegate*<char*, char*, char*, char*> PathCombine => &PathCombineW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFileExists"]/*' />
    [NativeTypeName("#define PathFileExists PathFileExistsW")]
    public static delegate*<char*, BOOL> PathFileExists => &PathFileExistsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindExtension"]/*' />
    [NativeTypeName("#define PathFindExtension PathFindExtensionW")]
    public static delegate*<char*, char*> PathFindExtension => &PathFindExtensionW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindFileName"]/*' />
    [NativeTypeName("#define PathFindFileName PathFindFileNameW")]
    public static delegate*<char*, char*> PathFindFileName => &PathFindFileNameW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindNextComponent"]/*' />
    [NativeTypeName("#define PathFindNextComponent PathFindNextComponentW")]
    public static delegate*<char*, char*> PathFindNextComponent => &PathFindNextComponentW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindSuffixArray"]/*' />
    [NativeTypeName("#define PathFindSuffixArray PathFindSuffixArrayW")]
    public static delegate*<char*, char**, int, char*> PathFindSuffixArray => &PathFindSuffixArrayW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetArgs"]/*' />
    [NativeTypeName("#define PathGetArgs PathGetArgsW")]
    public static delegate*<char*, char*> PathGetArgs => &PathGetArgsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsLFNFileSpec"]/*' />
    [NativeTypeName("#define PathIsLFNFileSpec PathIsLFNFileSpecW")]
    public static delegate*<char*, BOOL> PathIsLFNFileSpec => &PathIsLFNFileSpecW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCT_INVALID"]/*' />
    [NativeTypeName("#define GCT_INVALID 0x0000")]
    public const int GCT_INVALID = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCT_LFNCHAR"]/*' />
    [NativeTypeName("#define GCT_LFNCHAR 0x0001")]
    public const int GCT_LFNCHAR = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCT_SHORTCHAR"]/*' />
    [NativeTypeName("#define GCT_SHORTCHAR 0x0002")]
    public const int GCT_SHORTCHAR = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCT_WILD"]/*' />
    [NativeTypeName("#define GCT_WILD 0x0004")]
    public const int GCT_WILD = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GCT_SEPARATOR"]/*' />
    [NativeTypeName("#define GCT_SEPARATOR 0x0008")]
    public const int GCT_SEPARATOR = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetDriveNumber"]/*' />
    [NativeTypeName("#define PathGetDriveNumber PathGetDriveNumberW")]
    public static delegate*<char*, int> PathGetDriveNumber => &PathGetDriveNumberW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectory"]/*' />
    [NativeTypeName("#define PathIsDirectory PathIsDirectoryW")]
    public static delegate*<char*, BOOL> PathIsDirectory => &PathIsDirectoryW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsDirectoryEmpty"]/*' />
    [NativeTypeName("#define PathIsDirectoryEmpty PathIsDirectoryEmptyW")]
    public static delegate*<char*, BOOL> PathIsDirectoryEmpty => &PathIsDirectoryEmptyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsFileSpec"]/*' />
    [NativeTypeName("#define PathIsFileSpec PathIsFileSpecW")]
    public static delegate*<char*, BOOL> PathIsFileSpec => &PathIsFileSpecW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsPrefix"]/*' />
    [NativeTypeName("#define PathIsPrefix PathIsPrefixW")]
    public static delegate*<char*, char*, BOOL> PathIsPrefix => &PathIsPrefixW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRelative"]/*' />
    [NativeTypeName("#define PathIsRelative PathIsRelativeW")]
    public static delegate*<char*, BOOL> PathIsRelative => &PathIsRelativeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsRoot"]/*' />
    [NativeTypeName("#define PathIsRoot PathIsRootW")]
    public static delegate*<char*, BOOL> PathIsRoot => &PathIsRootW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSameRoot"]/*' />
    [NativeTypeName("#define PathIsSameRoot PathIsSameRootW")]
    public static delegate*<char*, char*, BOOL> PathIsSameRoot => &PathIsSameRootW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNC"]/*' />
    [NativeTypeName("#define PathIsUNC PathIsUNCW")]
    public static delegate*<char*, BOOL> PathIsUNC => &PathIsUNCW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsNetworkPath"]/*' />
    [NativeTypeName("#define PathIsNetworkPath PathIsNetworkPathW")]
    public static delegate*<char*, BOOL> PathIsNetworkPath => &PathIsNetworkPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServer"]/*' />
    [NativeTypeName("#define PathIsUNCServer PathIsUNCServerW")]
    public static delegate*<char*, BOOL> PathIsUNCServer => &PathIsUNCServerW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCServerShare"]/*' />
    [NativeTypeName("#define PathIsUNCServerShare PathIsUNCServerShareW")]
    public static delegate*<char*, BOOL> PathIsUNCServerShare => &PathIsUNCServerShareW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsURL"]/*' />
    [NativeTypeName("#define PathIsURL PathIsURLW")]
    public static delegate*<char*, BOOL> PathIsURL => &PathIsURLW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PMSF_NORMAL"]/*' />
    [NativeTypeName("#define PMSF_NORMAL 0x00000000")]
    public const int PMSF_NORMAL = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PMSF_MULTIPLE"]/*' />
    [NativeTypeName("#define PMSF_MULTIPLE 0x00000001")]
    public const int PMSF_MULTIPLE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PMSF_DONT_STRIP_SPACES"]/*' />
    [NativeTypeName("#define PMSF_DONT_STRIP_SPACES 0x00010000")]
    public const int PMSF_DONT_STRIP_SPACES = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBackslash"]/*' />
    [NativeTypeName("#define PathRemoveBackslash PathRemoveBackslashW")]
    public static delegate*<char*, char*> PathRemoveBackslash => &PathRemoveBackslashW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSkipRoot"]/*' />
    [NativeTypeName("#define PathSkipRoot PathSkipRootW")]
    public static delegate*<char*, char*> PathSkipRoot => &PathSkipRootW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripPath"]/*' />
    [NativeTypeName("#define PathStripPath PathStripPathW")]
    public static delegate*<char*, void> PathStripPath => &PathStripPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathStripToRoot"]/*' />
    [NativeTypeName("#define PathStripToRoot PathStripToRootW")]
    public static delegate*<char*, BOOL> PathStripToRoot => &PathStripToRootW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakeSystemFolder"]/*' />
    [NativeTypeName("#define PathMakeSystemFolder PathMakeSystemFolderW")]
    public static delegate*<char*, BOOL> PathMakeSystemFolder => &PathMakeSystemFolderW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnmakeSystemFolder"]/*' />
    [NativeTypeName("#define PathUnmakeSystemFolder PathUnmakeSystemFolderW")]
    public static delegate*<char*, BOOL> PathUnmakeSystemFolder => &PathUnmakeSystemFolderW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSystemFolder"]/*' />
    [NativeTypeName("#define PathIsSystemFolder PathIsSystemFolderW")]
    public static delegate*<char*, uint, BOOL> PathIsSystemFolder => &PathIsSystemFolderW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUndecorate"]/*' />
    [NativeTypeName("#define PathUndecorate PathUndecorateW")]
    public static delegate*<char*, void> PathUndecorate => &PathUndecorateW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnExpandEnvStrings"]/*' />
    [NativeTypeName("#define PathUnExpandEnvStrings PathUnExpandEnvStringsW")]
    public static delegate*<char*, char*, uint, BOOL> PathUnExpandEnvStrings => &PathUnExpandEnvStringsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAppend"]/*' />
    [NativeTypeName("#define PathAppend PathAppendW")]
    public static delegate*<char*, char*, BOOL> PathAppend => &PathAppendW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCanonicalize"]/*' />
    [NativeTypeName("#define PathCanonicalize PathCanonicalizeW")]
    public static delegate*<char*, char*, BOOL> PathCanonicalize => &PathCanonicalizeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPath"]/*' />
    [NativeTypeName("#define PathCompactPath PathCompactPathW")]
    public static delegate*<HDC, char*, uint, BOOL> PathCompactPath => &PathCompactPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCompactPathEx"]/*' />
    [NativeTypeName("#define PathCompactPathEx PathCompactPathExW")]
    public static delegate*<char*, char*, uint, uint, BOOL> PathCompactPathEx => &PathCompactPathExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCommonPrefix"]/*' />
    [NativeTypeName("#define PathCommonPrefix PathCommonPrefixW")]
    public static delegate*<char*, char*, char*, int> PathCommonPrefix => &PathCommonPrefixW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathFindOnPath"]/*' />
    [NativeTypeName("#define PathFindOnPath PathFindOnPathW")]
    public static delegate*<char*, char**, BOOL> PathFindOnPath => &PathFindOnPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathGetCharType"]/*' />
    [NativeTypeName("#define PathGetCharType PathGetCharTypeW")]
    public static delegate*<char, uint> PathGetCharType => &PathGetCharTypeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsContentType"]/*' />
    [NativeTypeName("#define PathIsContentType PathIsContentTypeW")]
    public static delegate*<char*, char*, BOOL> PathIsContentType => &PathIsContentTypeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMakePretty"]/*' />
    [NativeTypeName("#define PathMakePretty PathMakePrettyW")]
    public static delegate*<char*, BOOL> PathMakePretty => &PathMakePrettyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpec"]/*' />
    [NativeTypeName("#define PathMatchSpec PathMatchSpecW")]
    public static delegate*<char*, char*, BOOL> PathMatchSpec => &PathMatchSpecW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathMatchSpecEx"]/*' />
    [NativeTypeName("#define PathMatchSpecEx PathMatchSpecExW")]
    public static delegate*<char*, char*, uint, HRESULT> PathMatchSpecEx => &PathMatchSpecExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathParseIconLocation"]/*' />
    [NativeTypeName("#define PathParseIconLocation PathParseIconLocationW")]
    public static delegate*<char*, int> PathParseIconLocation => &PathParseIconLocationW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathQuoteSpaces"]/*' />
    [NativeTypeName("#define PathQuoteSpaces PathQuoteSpacesW")]
    public static delegate*<char*, BOOL> PathQuoteSpaces => &PathQuoteSpacesW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRelativePathTo"]/*' />
    [NativeTypeName("#define PathRelativePathTo PathRelativePathToW")]
    public static delegate*<char*, char*, uint, char*, uint, BOOL> PathRelativePathTo => &PathRelativePathToW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveArgs"]/*' />
    [NativeTypeName("#define PathRemoveArgs PathRemoveArgsW")]
    public static delegate*<char*, void> PathRemoveArgs => &PathRemoveArgsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveBlanks"]/*' />
    [NativeTypeName("#define PathRemoveBlanks PathRemoveBlanksW")]
    public static delegate*<char*, void> PathRemoveBlanks => &PathRemoveBlanksW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveExtension"]/*' />
    [NativeTypeName("#define PathRemoveExtension PathRemoveExtensionW")]
    public static delegate*<char*, void> PathRemoveExtension => &PathRemoveExtensionW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRemoveFileSpec"]/*' />
    [NativeTypeName("#define PathRemoveFileSpec PathRemoveFileSpecW")]
    public static delegate*<char*, BOOL> PathRemoveFileSpec => &PathRemoveFileSpecW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathRenameExtension"]/*' />
    [NativeTypeName("#define PathRenameExtension PathRenameExtensionW")]
    public static delegate*<char*, char*, BOOL> PathRenameExtension => &PathRenameExtensionW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSearchAndQualify"]/*' />
    [NativeTypeName("#define PathSearchAndQualify PathSearchAndQualifyW")]
    public static delegate*<char*, char*, uint, BOOL> PathSearchAndQualify => &PathSearchAndQualifyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathSetDlgItemPath"]/*' />
    [NativeTypeName("#define PathSetDlgItemPath PathSetDlgItemPathW")]
    public static delegate*<HWND, int, char*, void> PathSetDlgItemPath => &PathSetDlgItemPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathUnquoteSpaces"]/*' />
    [NativeTypeName("#define PathUnquoteSpaces PathUnquoteSpacesW")]
    public static delegate*<char*, BOOL> PathUnquoteSpaces => &PathUnquoteSpacesW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCompare"]/*' />
    [NativeTypeName("#define UrlCompare UrlCompareW")]
    public static delegate*<char*, char*, BOOL, int> UrlCompare => &UrlCompareW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCombine"]/*' />
    [NativeTypeName("#define UrlCombine UrlCombineW")]
    public static delegate*<char*, char*, char*, uint*, uint, HRESULT> UrlCombine => &UrlCombineW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCanonicalize"]/*' />
    [NativeTypeName("#define UrlCanonicalize UrlCanonicalizeW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> UrlCanonicalize => &UrlCanonicalizeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIsOpaque"]/*' />
    [NativeTypeName("#define UrlIsOpaque UrlIsOpaqueW")]
    public static delegate*<char*, BOOL> UrlIsOpaque => &UrlIsOpaqueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetLocation"]/*' />
    [NativeTypeName("#define UrlGetLocation UrlGetLocationW")]
    public static delegate*<char*, char*> UrlGetLocation => &UrlGetLocationW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlUnescape"]/*' />
    [NativeTypeName("#define UrlUnescape UrlUnescapeW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> UrlUnescape => &UrlUnescapeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlEscape"]/*' />
    [NativeTypeName("#define UrlEscape UrlEscapeW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> UrlEscape => &UrlEscapeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlCreateFromPath"]/*' />
    [NativeTypeName("#define UrlCreateFromPath UrlCreateFromPathW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> UrlCreateFromPath => &UrlCreateFromPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCreateFromUrl"]/*' />
    [NativeTypeName("#define PathCreateFromUrl PathCreateFromUrlW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> PathCreateFromUrl => &PathCreateFromUrlW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlHash"]/*' />
    [NativeTypeName("#define UrlHash UrlHashW")]
    public static delegate*<char*, byte*, uint, HRESULT> UrlHash => &UrlHashW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlGetPart"]/*' />
    [NativeTypeName("#define UrlGetPart UrlGetPartW")]
    public static delegate*<char*, char*, uint*, uint, uint, HRESULT> UrlGetPart => &UrlGetPartW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlApplyScheme"]/*' />
    [NativeTypeName("#define UrlApplyScheme UrlApplySchemeW")]
    public static delegate*<char*, char*, uint*, uint, HRESULT> UrlApplyScheme => &UrlApplySchemeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlIs"]/*' />
    [NativeTypeName("#define UrlIs UrlIsW")]
    public static delegate*<char*, URLIS, BOOL> UrlIs => &UrlIsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UrlFixup"]/*' />
    [NativeTypeName("#define UrlFixup UrlFixupW")]
    public static delegate*<char*, char*, uint, HRESULT> UrlFixup => &UrlFixupW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ParseURL"]/*' />
    [NativeTypeName("#define ParseURL ParseURLW")]
    public static delegate*<char*, PARSEDURLW*, HRESULT> ParseURL => &ParseURLW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteEmptyKey"]/*' />
    [NativeTypeName("#define SHDeleteEmptyKey SHDeleteEmptyKeyW")]
    public static delegate*<HKEY, char*, int> SHDeleteEmptyKey => &SHDeleteEmptyKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteKey"]/*' />
    [NativeTypeName("#define SHDeleteKey SHDeleteKeyW")]
    public static delegate*<HKEY, char*, int> SHDeleteKey => &SHDeleteKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHDeleteValue"]/*' />
    [NativeTypeName("#define SHDeleteValue SHDeleteValueW")]
    public static delegate*<HKEY, char*, char*, int> SHDeleteValue => &SHDeleteValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetValue"]/*' />
    [NativeTypeName("#define SHGetValue SHGetValueW")]
    public static delegate*<HKEY, char*, char*, uint*, void*, uint*, int> SHGetValue => &SHGetValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetValue"]/*' />
    [NativeTypeName("#define SHSetValue SHSetValueW")]
    public static delegate*<HKEY, char*, char*, uint, void*, uint, int> SHSetValue => &SHSetValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetValue"]/*' />
    [NativeTypeName("#define SHRegGetValue SHRegGetValueW")]
    public static delegate*<HKEY, char*, char*, int, uint*, void*, uint*, int> SHRegGetValue => &SHRegGetValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryValueEx"]/*' />
    [NativeTypeName("#define SHQueryValueEx SHQueryValueExW")]
    public static delegate*<HKEY, char*, uint*, uint*, void*, uint*, int> SHQueryValueEx => &SHQueryValueExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumKeyEx"]/*' />
    [NativeTypeName("#define SHEnumKeyEx SHEnumKeyExW")]
    public static delegate*<HKEY, uint, char*, uint*, int> SHEnumKeyEx => &SHEnumKeyExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHEnumValue"]/*' />
    [NativeTypeName("#define SHEnumValue SHEnumValueW")]
    public static delegate*<HKEY, uint, char*, uint*, uint*, void*, uint*, int> SHEnumValue => &SHEnumValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHQueryInfoKey"]/*' />
    [NativeTypeName("#define SHQueryInfoKey SHQueryInfoKeyW")]
    public static delegate*<HKEY, uint*, uint*, uint*, uint*, int> SHQueryInfoKey => &SHQueryInfoKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCopyKey"]/*' />
    [NativeTypeName("#define SHCopyKey SHCopyKeyW")]
    public static delegate*<HKEY, char*, HKEY, uint, int> SHCopyKey => &SHCopyKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetPath"]/*' />
    [NativeTypeName("#define SHRegGetPath SHRegGetPathW")]
    public static delegate*<HKEY, char*, char*, char*, uint, int> SHRegGetPath => &SHRegGetPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetPath"]/*' />
    [NativeTypeName("#define SHRegSetPath SHRegSetPathW")]
    public static delegate*<HKEY, char*, char*, char*, uint, int> SHRegSetPath => &SHRegSetPathW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHREGSET_HKCU"]/*' />
    [NativeTypeName("#define SHREGSET_HKCU 0x00000001")]
    public const int SHREGSET_HKCU = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHREGSET_FORCE_HKCU"]/*' />
    [NativeTypeName("#define SHREGSET_FORCE_HKCU 0x00000002")]
    public const int SHREGSET_FORCE_HKCU = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHREGSET_HKLM"]/*' />
    [NativeTypeName("#define SHREGSET_HKLM 0x00000004")]
    public const int SHREGSET_HKLM = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHREGSET_FORCE_HKLM"]/*' />
    [NativeTypeName("#define SHREGSET_FORCE_HKLM 0x00000008")]
    public const int SHREGSET_FORCE_HKLM = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHREGSET_DEFAULT"]/*' />
    [NativeTypeName("#define SHREGSET_DEFAULT (SHREGSET_FORCE_HKCU | SHREGSET_HKLM)")]
    public const int SHREGSET_DEFAULT = (0x00000002 | 0x00000004);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegCreateUSKey"]/*' />
    [NativeTypeName("#define SHRegCreateUSKey SHRegCreateUSKeyW")]
    public static delegate*<char*, uint, HUSKEY, HUSKEY*, uint, int> SHRegCreateUSKey => &SHRegCreateUSKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegOpenUSKey"]/*' />
    [NativeTypeName("#define SHRegOpenUSKey SHRegOpenUSKeyW")]
    public static delegate*<char*, uint, HUSKEY, HUSKEY*, BOOL, int> SHRegOpenUSKey => &SHRegOpenUSKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryUSValue"]/*' />
    [NativeTypeName("#define SHRegQueryUSValue SHRegQueryUSValueW")]
    public static delegate*<HUSKEY, char*, uint*, void*, uint*, BOOL, void*, uint, int> SHRegQueryUSValue => &SHRegQueryUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegWriteUSValue"]/*' />
    [NativeTypeName("#define SHRegWriteUSValue SHRegWriteUSValueW")]
    public static delegate*<HUSKEY, char*, uint, void*, uint, uint, int> SHRegWriteUSValue => &SHRegWriteUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteUSValue"]/*' />
    [NativeTypeName("#define SHRegDeleteUSValue SHRegDeleteUSValueW")]
    public static delegate*<HUSKEY, char*, SHREGDEL_FLAGS, int> SHRegDeleteUSValue => &SHRegDeleteUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegDeleteEmptyUSKey"]/*' />
    [NativeTypeName("#define SHRegDeleteEmptyUSKey SHRegDeleteEmptyUSKeyW")]
    public static delegate*<HUSKEY, char*, SHREGDEL_FLAGS, int> SHRegDeleteEmptyUSKey => &SHRegDeleteEmptyUSKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSKey"]/*' />
    [NativeTypeName("#define SHRegEnumUSKey SHRegEnumUSKeyW")]
    public static delegate*<HUSKEY, uint, char*, uint*, SHREGENUM_FLAGS, int> SHRegEnumUSKey => &SHRegEnumUSKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegEnumUSValue"]/*' />
    [NativeTypeName("#define SHRegEnumUSValue SHRegEnumUSValueW")]
    public static delegate*<HUSKEY, uint, char*, uint*, uint*, void*, uint*, SHREGENUM_FLAGS, int> SHRegEnumUSValue => &SHRegEnumUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegQueryInfoUSKey"]/*' />
    [NativeTypeName("#define SHRegQueryInfoUSKey SHRegQueryInfoUSKeyW")]
    public static delegate*<HUSKEY, uint*, uint*, uint*, uint*, SHREGENUM_FLAGS, int> SHRegQueryInfoUSKey => &SHRegQueryInfoUSKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetUSValue"]/*' />
    [NativeTypeName("#define SHRegGetUSValue SHRegGetUSValueW")]
    public static delegate*<char*, char*, uint*, void*, uint*, BOOL, void*, uint, int> SHRegGetUSValue => &SHRegGetUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegSetUSValue"]/*' />
    [NativeTypeName("#define SHRegSetUSValue SHRegSetUSValueW")]
    public static delegate*<char*, char*, uint, void*, uint, uint, int> SHRegSetUSValue => &SHRegSetUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetInt"]/*' />
    [NativeTypeName("#define SHRegGetInt SHRegGetIntW")]
    public static delegate*<HKEY, char*, int, int> SHRegGetInt => &SHRegGetIntW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHRegGetBoolUSValue"]/*' />
    [NativeTypeName("#define SHRegGetBoolUSValue SHRegGetBoolUSValueW")]
    public static delegate*<char*, char*, BOOL, BOOL, BOOL> SHRegGetBoolUSValue => &SHRegGetBoolUSValueW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryString"]/*' />
    [NativeTypeName("#define AssocQueryString AssocQueryStringW")]
    public static delegate*<uint, ASSOCSTR, char*, char*, char*, uint*, HRESULT> AssocQueryString => &AssocQueryStringW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryStringByKey"]/*' />
    [NativeTypeName("#define AssocQueryStringByKey AssocQueryStringByKeyW")]
    public static delegate*<uint, ASSOCSTR, HKEY, char*, char*, uint*, HRESULT> AssocQueryStringByKey => &AssocQueryStringByKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AssocQueryKey"]/*' />
    [NativeTypeName("#define AssocQueryKey AssocQueryKeyW")]
    public static delegate*<uint, ASSOCKEY, char*, char*, HKEY*, HRESULT> AssocQueryKey => &AssocQueryKeyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStream"]/*' />
    [NativeTypeName("#define SHOpenRegStream SHOpenRegStreamW")]
    public static delegate*<HKEY, char*, char*, uint, IStream*> SHOpenRegStream => &SHOpenRegStreamW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenRegStream2"]/*' />
    [NativeTypeName("#define SHOpenRegStream2 SHOpenRegStream2W")]
    public static delegate*<HKEY, char*, char*, uint, IStream*> SHOpenRegStream2 => &SHOpenRegStream2W;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateStreamOnFile"]/*' />
    [NativeTypeName("#define SHCreateStreamOnFile SHCreateStreamOnFileW")]
    public static delegate*<char*, uint, IStream**, HRESULT> SHCreateStreamOnFile => &SHCreateStreamOnFileW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetAcceptLanguages"]/*' />
    [NativeTypeName("#define GetAcceptLanguages GetAcceptLanguagesW")]
    public static delegate*<char*, uint*, HRESULT> GetAcceptLanguages => &GetAcceptLanguagesW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_SHORTTIME"]/*' />
    [NativeTypeName("#define FDTF_SHORTTIME 0x00000001")]
    public const int FDTF_SHORTTIME = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_SHORTDATE"]/*' />
    [NativeTypeName("#define FDTF_SHORTDATE 0x00000002")]
    public const int FDTF_SHORTDATE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_DEFAULT"]/*' />
    [NativeTypeName("#define FDTF_DEFAULT (FDTF_SHORTDATE | FDTF_SHORTTIME)")]
    public const int FDTF_DEFAULT = (0x00000002 | 0x00000001);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_LONGDATE"]/*' />
    [NativeTypeName("#define FDTF_LONGDATE 0x00000004")]
    public const int FDTF_LONGDATE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_LONGTIME"]/*' />
    [NativeTypeName("#define FDTF_LONGTIME 0x00000008")]
    public const int FDTF_LONGTIME = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_RELATIVE"]/*' />
    [NativeTypeName("#define FDTF_RELATIVE 0x00000010")]
    public const int FDTF_RELATIVE = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_LTRDATE"]/*' />
    [NativeTypeName("#define FDTF_LTRDATE 0x00000100")]
    public const int FDTF_LTRDATE = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_RTLDATE"]/*' />
    [NativeTypeName("#define FDTF_RTLDATE 0x00000200")]
    public const int FDTF_RTLDATE = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FDTF_NOAUTOREADINGORDER"]/*' />
    [NativeTypeName("#define FDTF_NOAUTOREADINGORDER 0x00000400")]
    public const int FDTF_NOAUTOREADINGORDER = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHFormatDateTime"]/*' />
    [NativeTypeName("#define SHFormatDateTime SHFormatDateTimeW")]
    public static delegate*<FILETIME*, uint*, char*, uint, int> SHFormatDateTime => &SHFormatDateTimeW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHMessageBoxCheck"]/*' />
    [NativeTypeName("#define SHMessageBoxCheck SHMessageBoxCheckW")]
    public static delegate*<HWND, char*, char*, uint, int, char*, int> SHMessageBoxCheck => &SHMessageBoxCheckW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSendMessageBroadcast"]/*' />
    [NativeTypeName("#define SHSendMessageBroadcast SHSendMessageBroadcastW")]
    public static delegate*<uint, WPARAM, LPARAM, LRESULT> SHSendMessageBroadcast => &SHSendMessageBroadcastW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHStripMneumonic"]/*' />
    [NativeTypeName("#define SHStripMneumonic SHStripMneumonicW")]
    public static delegate*<char*, char> SHStripMneumonic => &SHStripMneumonicW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLATFORM_UNKNOWN"]/*' />
    [NativeTypeName("#define PLATFORM_UNKNOWN 0")]
    public const int PLATFORM_UNKNOWN = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLATFORM_IE3"]/*' />
    [NativeTypeName("#define PLATFORM_IE3 1")]
    public const int PLATFORM_IE3 = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLATFORM_BROWSERONLY"]/*' />
    [NativeTypeName("#define PLATFORM_BROWSERONLY 1")]
    public const int PLATFORM_BROWSERONLY = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PLATFORM_INTEGRATED"]/*' />
    [NativeTypeName("#define PLATFORM_INTEGRATED 2")]
    public const int PLATFORM_INTEGRATED = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILMM_IE4"]/*' />
    [NativeTypeName("#define ILMM_IE4 0")]
    public const int ILMM_IE4 = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_PLATFORM_WINDOWS"]/*' />
    [NativeTypeName("#define DLLVER_PLATFORM_WINDOWS 0x00000001")]
    public const int DLLVER_PLATFORM_WINDOWS = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_PLATFORM_NT"]/*' />
    [NativeTypeName("#define DLLVER_PLATFORM_NT 0x00000002")]
    public const int DLLVER_PLATFORM_NT = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_MAJOR_MASK"]/*' />
    [NativeTypeName("#define DLLVER_MAJOR_MASK 0xFFFF000000000000")]
    public const ulong DLLVER_MAJOR_MASK = 0xFFFF000000000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_MINOR_MASK"]/*' />
    [NativeTypeName("#define DLLVER_MINOR_MASK 0x0000FFFF00000000")]
    public const long DLLVER_MINOR_MASK = 0x0000FFFF00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_BUILD_MASK"]/*' />
    [NativeTypeName("#define DLLVER_BUILD_MASK 0x00000000FFFF0000")]
    public const uint DLLVER_BUILD_MASK = 0x00000000FFFF0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DLLVER_QFE_MASK"]/*' />
    [NativeTypeName("#define DLLVER_QFE_MASK 0x000000000000FFFF")]
    public const int DLLVER_QFE_MASK = 0x000000000000FFFF;
}
