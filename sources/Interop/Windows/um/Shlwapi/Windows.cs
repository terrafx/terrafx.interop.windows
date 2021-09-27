// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrChrA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("WORD")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrChrW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("WCHAR")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrChrIA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("WORD")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrChrIW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("WCHAR")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrChrNW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("WCHAR")] ushort wMatch, [NativeTypeName("UINT")] uint cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrChrNIW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("WCHAR")] ushort wMatch, [NativeTypeName("UINT")] uint cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNIA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNIW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCSpnA([NativeTypeName("PCSTR")] sbyte* pszStr, [NativeTypeName("PCSTR")] sbyte* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCSpnW([NativeTypeName("PCWSTR")] ushort* pszStr, [NativeTypeName("PCWSTR")] ushort* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCSpnIA([NativeTypeName("PCSTR")] sbyte* pszStr, [NativeTypeName("PCSTR")] sbyte* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCSpnIW([NativeTypeName("PCWSTR")] ushort* pszStr, [NativeTypeName("PCWSTR")] ushort* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrDupA([NativeTypeName("PCSTR")] sbyte* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrDupW([NativeTypeName("PCWSTR")] ushort* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrFormatByteSizeEx([NativeTypeName("ULONGLONG")] ulong ull, [NativeTypeName("SFBS_FLAGS")] int flags, [NativeTypeName("PWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrFormatByteSizeA([NativeTypeName("DWORD")] uint dw, [NativeTypeName("PSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrFormatByteSize64A([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrFormatByteSizeW([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrFormatKBSizeW([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrFormatKBSizeA([NativeTypeName("LONGLONG")] long qdw, [NativeTypeName("PSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrFromTimeIntervalA([NativeTypeName("PSTR")] sbyte* pszOut, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("DWORD")] uint dwTimeMS, int digits);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrFromTimeIntervalW([NativeTypeName("PWSTR")] ushort* pszOut, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("DWORD")] uint dwTimeMS, int digits);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrIsIntlEqualA([NativeTypeName("BOOL")] int fCaseSens, [NativeTypeName("PCSTR")] sbyte* pszString1, [NativeTypeName("PCSTR")] sbyte* pszString2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrIsIntlEqualW([NativeTypeName("BOOL")] int fCaseSens, [NativeTypeName("PCWSTR")] ushort* pszString1, [NativeTypeName("PCWSTR")] ushort* pszString2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrNCatA([NativeTypeName("PSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, int cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrNCatW([NativeTypeName("PWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2, int cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrPBrkA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrPBrkW([NativeTypeName("PCWSTR")] ushort* psz, [NativeTypeName("PCWSTR")] ushort* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrRChrA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("PCSTR")] sbyte* pszEnd, [NativeTypeName("WORD")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrRChrW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("PCWSTR")] ushort* pszEnd, [NativeTypeName("WCHAR")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrRChrIA([NativeTypeName("PCSTR")] sbyte* pszStart, [NativeTypeName("PCSTR")] sbyte* pszEnd, [NativeTypeName("WORD")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrRChrIW([NativeTypeName("PCWSTR")] ushort* pszStart, [NativeTypeName("PCWSTR")] ushort* pszEnd, [NativeTypeName("WCHAR")] ushort wMatch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrRStrIA([NativeTypeName("PCSTR")] sbyte* pszSource, [NativeTypeName("PCSTR")] sbyte* pszLast, [NativeTypeName("PCSTR")] sbyte* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrRStrIW([NativeTypeName("PCWSTR")] ushort* pszSource, [NativeTypeName("PCWSTR")] ushort* pszLast, [NativeTypeName("PCWSTR")] ushort* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrSpnA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrSpnW([NativeTypeName("PCWSTR")] ushort* psz, [NativeTypeName("PCWSTR")] ushort* pszSet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrStrA([NativeTypeName("PCSTR")] sbyte* pszFirst, [NativeTypeName("PCSTR")] sbyte* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrStrW([NativeTypeName("PCWSTR")] ushort* pszFirst, [NativeTypeName("PCWSTR")] ushort* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrStrIA([NativeTypeName("PCSTR")] sbyte* pszFirst, [NativeTypeName("PCSTR")] sbyte* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrStrIW([NativeTypeName("PCWSTR")] ushort* pszFirst, [NativeTypeName("PCWSTR")] ushort* pszSrch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrStrNW([NativeTypeName("PCWSTR")] ushort* pszFirst, [NativeTypeName("PCWSTR")] ushort* pszSrch, [NativeTypeName("UINT")] uint cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrStrNIW([NativeTypeName("PCWSTR")] ushort* pszFirst, [NativeTypeName("PCWSTR")] ushort* pszSrch, [NativeTypeName("UINT")] uint cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrToIntA([NativeTypeName("PCSTR")] sbyte* pszSrc);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrToIntW([NativeTypeName("PCWSTR")] ushort* pszSrc);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrToIntExA([NativeTypeName("PCSTR")] sbyte* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, int* piRet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrToIntExW([NativeTypeName("PCWSTR")] ushort* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, int* piRet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrToInt64ExA([NativeTypeName("PCSTR")] sbyte* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, [NativeTypeName("LONGLONG *")] long* pllRet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrToInt64ExW([NativeTypeName("PCWSTR")] ushort* pszString, [NativeTypeName("STIF_FLAGS")] int dwFlags, [NativeTypeName("LONGLONG *")] long* pllRet);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrTrimA([NativeTypeName("PSTR")] sbyte* psz, [NativeTypeName("PCSTR")] sbyte* pszTrimChars);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int StrTrimW([NativeTypeName("PWSTR")] ushort* psz, [NativeTypeName("PCWSTR")] ushort* pszTrimChars);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrCatW([NativeTypeName("PWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpIW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrCpyW([NativeTypeName("PWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrCpyNW([NativeTypeName("PWSTR")] ushort* pszDst, [NativeTypeName("PCWSTR")] ushort* pszSrc, int cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PWSTR")]
        public static extern ushort* StrCatBuffW([NativeTypeName("PWSTR")] ushort* pszDest, [NativeTypeName("PCWSTR")] ushort* pszSrc, int cchDestBuffSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("PSTR")]
        public static extern sbyte* StrCatBuffA([NativeTypeName("PSTR")] sbyte* pszDest, [NativeTypeName("PCSTR")] sbyte* pszSrc, int cchDestBuffSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChrCmpIA([NativeTypeName("WORD")] ushort w1, [NativeTypeName("WORD")] ushort w2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ChrCmpIW([NativeTypeName("WCHAR")] ushort w1, [NativeTypeName("WCHAR")] ushort w2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int wvnsprintfA([NativeTypeName("PSTR")] sbyte* pszDest, int cchDest, [NativeTypeName("PCSTR")] sbyte* pszFmt, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int wvnsprintfW([NativeTypeName("PWSTR")] ushort* pszDest, int cchDest, [NativeTypeName("PCWSTR")] ushort* pszFmt, [NativeTypeName("va_list")] sbyte* arglist);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int wnsprintfA([NativeTypeName("PSTR")] sbyte* pszDest, int cchDest, [NativeTypeName("PCSTR")] sbyte* pszFmt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int wnsprintfW([NativeTypeName("PWSTR")] ushort* pszDest, int cchDest, [NativeTypeName("PCWSTR")] ushort* pszFmt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrRetToStrA(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR *")] sbyte** ppsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrRetToStrW(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR *")] ushort** ppsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrRetToBufA(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrRetToBufW(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHStrDupA([NativeTypeName("LPCSTR")] sbyte* psz, [NativeTypeName("LPWSTR *")] ushort** ppwsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHStrDupW([NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPWSTR *")] ushort** ppwsz);

        [return: NativeTypeName("HRESULT")]
        public static int SHLocalStrDupW([NativeTypeName("PCWSTR")] ushort* psz, [NativeTypeName("PWSTR *")] ushort** ppsz)
        {
            *ppsz = StrDupW(psz);
            return (*ppsz) != null ? ((int)(0)) : unchecked((int)(0x8007000E));
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHLocalStrDupA([NativeTypeName("PCSTR")] sbyte* psz, [NativeTypeName("PSTR *")] sbyte** ppsz)
        {
            *ppsz = StrDupA(psz);
            return (*ppsz) != null ? ((int)(0)) : unchecked((int)(0x8007000E));
        }

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpLogicalW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint StrCatChainW([NativeTypeName("PWSTR")] ushort* pszDst, [NativeTypeName("DWORD")] uint cchDst, [NativeTypeName("DWORD")] uint ichAt, [NativeTypeName("PCWSTR")] ushort* pszSrc);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StrRetToBSTR(STRRET* pstr, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("BSTR *")] ushort** pbstr);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHLoadIndirectString([NativeTypeName("PCWSTR")] ushort* pszSource, [NativeTypeName("PWSTR")] ushort* pszOutBuf, [NativeTypeName("UINT")] uint cchOutBuf, void** ppvReserved);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharSpaceA([NativeTypeName("CHAR")] sbyte wch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsCharSpaceW([NativeTypeName("WCHAR")] ushort wch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpCA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpCW([NativeTypeName("LPCWSTR")] ushort* pszStr1, [NativeTypeName("LPCWSTR")] ushort* pszStr2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpICA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpICW([NativeTypeName("LPCWSTR")] ushort* pszStr1, [NativeTypeName("LPCWSTR")] ushort* pszStr2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNCA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNCW([NativeTypeName("LPCWSTR")] ushort* pszStr1, [NativeTypeName("LPCWSTR")] ushort* pszStr2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNICA([NativeTypeName("LPCSTR")] sbyte* pszStr1, [NativeTypeName("LPCSTR")] sbyte* pszStr2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int StrCmpNICW([NativeTypeName("LPCWSTR")] ushort* pszStr1, [NativeTypeName("LPCWSTR")] ushort* pszStr2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntlStrEqWorkerA([NativeTypeName("BOOL")] int fCaseSens, [NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IntlStrEqWorkerW([NativeTypeName("BOOL")] int fCaseSens, [NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2, int nChar);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathAddBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathAddBackslashW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathAddExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszExt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathAddExtensionW([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("LPCWSTR")] ushort* pszExt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathAppendA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszMore);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathAppendW([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("LPCWSTR")] ushort* pszMore);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathBuildRootA([NativeTypeName("LPSTR")] sbyte* pszRoot, int iDrive);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathBuildRootW([NativeTypeName("LPWSTR")] ushort* pszRoot, int iDrive);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCanonicalizeA([NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCanonicalizeW([NativeTypeName("LPWSTR")] ushort* pszBuf, [NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathCombineA([NativeTypeName("LPSTR")] sbyte* pszDest, [NativeTypeName("LPCSTR")] sbyte* pszDir, [NativeTypeName("LPCSTR")] sbyte* pszFile);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathCombineW([NativeTypeName("LPWSTR")] ushort* pszDest, [NativeTypeName("LPCWSTR")] ushort* pszDir, [NativeTypeName("LPCWSTR")] ushort* pszFile);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCompactPathA([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("UINT")] uint dx);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCompactPathW([NativeTypeName("HDC")] IntPtr hDC, [NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("UINT")] uint dx);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCompactPathExA([NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("LPCSTR")] sbyte* pszSrc, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCompactPathExW([NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("LPCWSTR")] ushort* pszSrc, [NativeTypeName("UINT")] uint cchMax, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathCommonPrefixA([NativeTypeName("LPCSTR")] sbyte* pszFile1, [NativeTypeName("LPCSTR")] sbyte* pszFile2, [NativeTypeName("LPSTR")] sbyte* achPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathCommonPrefixW([NativeTypeName("LPCWSTR")] ushort* pszFile1, [NativeTypeName("LPCWSTR")] ushort* pszFile2, [NativeTypeName("LPWSTR")] ushort* achPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathFileExistsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathFileExistsW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathFindExtensionA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathFindExtensionW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathFindFileNameA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathFindFileNameW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathFindNextComponentA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathFindNextComponentW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathFindOnPathA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("PZPCSTR")] sbyte** ppszOtherDirs);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathFindOnPathW([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("PZPCWSTR")] ushort** ppszOtherDirs);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* PathFindSuffixArrayA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("const LPCSTR *")] sbyte** apszSuffix, int iArraySize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPCWSTR")]
        public static extern ushort* PathFindSuffixArrayW([NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("const LPCWSTR *")] ushort** apszSuffix, int iArraySize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathGetArgsA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathGetArgsW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsLFNFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszName);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsLFNFileSpecW([NativeTypeName("LPCWSTR")] ushort* pszName);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PathGetCharTypeA([NativeTypeName("UCHAR")] byte ch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint PathGetCharTypeW([NativeTypeName("WCHAR")] ushort ch);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathGetDriveNumberA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathGetDriveNumberW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsDirectoryA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsDirectoryW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsDirectoryEmptyA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsDirectoryEmptyW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsFileSpecA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsFileSpecW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsPrefixA([NativeTypeName("LPCSTR")] sbyte* pszPrefix, [NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsPrefixW([NativeTypeName("LPCWSTR")] ushort* pszPrefix, [NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsRelativeA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsRelativeW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsRootW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsSameRootA([NativeTypeName("LPCSTR")] sbyte* pszPath1, [NativeTypeName("LPCSTR")] sbyte* pszPath2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsSameRootW([NativeTypeName("LPCWSTR")] ushort* pszPath1, [NativeTypeName("LPCWSTR")] ushort* pszPath2);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsNetworkPathA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsNetworkPathW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCServerA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCServerW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCServerShareA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCServerShareW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsContentTypeA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszContentType);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsContentTypeW([NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("LPCWSTR")] ushort* pszContentType);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsURLA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsURLW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMakePrettyA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMakePrettyW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMatchSpecA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("LPCSTR")] sbyte* pszSpec);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMatchSpecW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("LPCWSTR")] ushort* pszSpec);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathMatchSpecExA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("LPCSTR")] sbyte* pszSpec, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathMatchSpecExW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("LPCWSTR")] ushort* pszSpec, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathParseIconLocationA([NativeTypeName("LPSTR")] sbyte* pszIconFile);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int PathParseIconLocationW([NativeTypeName("LPWSTR")] ushort* pszIconFile);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathQuoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathQuoteSpacesW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRelativePathToA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszFrom, [NativeTypeName("DWORD")] uint dwAttrFrom, [NativeTypeName("LPCSTR")] sbyte* pszTo, [NativeTypeName("DWORD")] uint dwAttrTo);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRelativePathToW([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("LPCWSTR")] ushort* pszFrom, [NativeTypeName("DWORD")] uint dwAttrFrom, [NativeTypeName("LPCWSTR")] ushort* pszTo, [NativeTypeName("DWORD")] uint dwAttrTo);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveArgsA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveArgsW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathRemoveBackslashA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathRemoveBackslashW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveBlanksA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveBlanksW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathRemoveExtensionW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRemoveFileSpecA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRemoveFileSpecW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRenameExtensionA([NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("LPCSTR")] sbyte* pszExt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathRenameExtensionW([NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("LPCWSTR")] ushort* pszExt);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathSearchAndQualifyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathSearchAndQualifyW([NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("LPWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathSetDlgItemPathA([NativeTypeName("HWND")] IntPtr hDlg, int id, [NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathSetDlgItemPathW([NativeTypeName("HWND")] IntPtr hDlg, int id, [NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* PathSkipRootA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* PathSkipRootW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathStripPathA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathStripPathW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathStripToRootA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathStripToRootW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnquoteSpacesA([NativeTypeName("LPSTR")] sbyte* lpsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnquoteSpacesW([NativeTypeName("LPWSTR")] ushort* lpsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathMakeSystemFolderW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnmakeSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnmakeSystemFolderW([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsSystemFolderA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwAttrb);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsSystemFolderW([NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwAttrb);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathUndecorateA([NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void PathUndecorateW([NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnExpandEnvStringsA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathUnExpandEnvStringsW([NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("LPWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int UrlCompareA([NativeTypeName("PCSTR")] sbyte* psz1, [NativeTypeName("PCSTR")] sbyte* psz2, [NativeTypeName("BOOL")] int fIgnoreSlash);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int UrlCompareW([NativeTypeName("PCWSTR")] ushort* psz1, [NativeTypeName("PCWSTR")] ushort* psz2, [NativeTypeName("BOOL")] int fIgnoreSlash);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCombineA([NativeTypeName("PCSTR")] sbyte* pszBase, [NativeTypeName("PCSTR")] sbyte* pszRelative, [NativeTypeName("PSTR")] sbyte* pszCombined, [NativeTypeName("DWORD *")] uint* pcchCombined, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCombineW([NativeTypeName("PCWSTR")] ushort* pszBase, [NativeTypeName("PCWSTR")] ushort* pszRelative, [NativeTypeName("PWSTR")] ushort* pszCombined, [NativeTypeName("DWORD *")] uint* pcchCombined, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCanonicalizeA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszCanonicalized, [NativeTypeName("DWORD *")] uint* pcchCanonicalized, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCanonicalizeW([NativeTypeName("PCWSTR")] ushort* pszUrl, [NativeTypeName("PWSTR")] ushort* pszCanonicalized, [NativeTypeName("DWORD *")] uint* pcchCanonicalized, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsOpaqueA([NativeTypeName("PCSTR")] sbyte* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsOpaqueW([NativeTypeName("PCWSTR")] ushort* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsNoHistoryA([NativeTypeName("PCSTR")] sbyte* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsNoHistoryW([NativeTypeName("PCWSTR")] ushort* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsA([NativeTypeName("PCSTR")] sbyte* pszUrl, URLIS UrlIs);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UrlIsW([NativeTypeName("PCWSTR")] ushort* pszUrl, URLIS UrlIs);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPCSTR")]
        public static extern sbyte* UrlGetLocationA([NativeTypeName("PCSTR")] sbyte* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LPCWSTR")]
        public static extern ushort* UrlGetLocationW([NativeTypeName("PCWSTR")] ushort* pszURL);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlUnescapeA([NativeTypeName("PSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszUnescaped, [NativeTypeName("DWORD *")] uint* pcchUnescaped, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlUnescapeW([NativeTypeName("PWSTR")] ushort* pszUrl, [NativeTypeName("PWSTR")] ushort* pszUnescaped, [NativeTypeName("DWORD *")] uint* pcchUnescaped, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlEscapeA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszEscaped, [NativeTypeName("DWORD *")] uint* pcchEscaped, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlEscapeW([NativeTypeName("PCWSTR")] ushort* pszUrl, [NativeTypeName("PWSTR")] ushort* pszEscaped, [NativeTypeName("DWORD *")] uint* pcchEscaped, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCreateFromPathA([NativeTypeName("PCSTR")] sbyte* pszPath, [NativeTypeName("PSTR")] sbyte* pszUrl, [NativeTypeName("DWORD *")] uint* pcchUrl, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlCreateFromPathW([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PWSTR")] ushort* pszUrl, [NativeTypeName("DWORD *")] uint* pcchUrl, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCreateFromUrlA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("PSTR")] sbyte* pszPath, [NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCreateFromUrlW([NativeTypeName("PCWSTR")] ushort* pszUrl, [NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("DWORD *")] uint* pcchPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCreateFromUrlAlloc([NativeTypeName("PCWSTR")] ushort* pszIn, [NativeTypeName("PWSTR *")] ushort** ppszOut, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlHashA([NativeTypeName("PCSTR")] sbyte* pszUrl, [NativeTypeName("BYTE *")] byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlHashW([NativeTypeName("PCWSTR")] ushort* pszUrl, [NativeTypeName("BYTE *")] byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlGetPartW([NativeTypeName("PCWSTR")] ushort* pszIn, [NativeTypeName("PWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwPart, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlGetPartA([NativeTypeName("PCSTR")] sbyte* pszIn, [NativeTypeName("PSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwPart, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlApplySchemeA([NativeTypeName("PCSTR")] sbyte* pszIn, [NativeTypeName("PSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlApplySchemeW([NativeTypeName("PCWSTR")] ushort* pszIn, [NativeTypeName("PWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HashData([NativeTypeName("BYTE *")] byte* pbData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("BYTE *")] byte* pbHash, [NativeTypeName("DWORD")] uint cbHash);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UrlFixupW([NativeTypeName("PCWSTR")] ushort* pcszUrl, [NativeTypeName("PWSTR")] ushort* pszTranslatedUrl, [NativeTypeName("DWORD")] uint cchMax);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ParseURLA([NativeTypeName("LPCSTR")] sbyte* pcszURL, PARSEDURLA* ppu);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ParseURLW([NativeTypeName("LPCWSTR")] ushort* pcszURL, PARSEDURLW* ppu);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteEmptyKeyA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteEmptyKeyW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteKeyA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteKeyW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SHRegDuplicateHKey([NativeTypeName("HKEY")] IntPtr hkey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHDeleteValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHGetValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHGetValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHSetValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* pvData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHSetValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* pvData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegSetValue([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* pvData, [NativeTypeName("DWORD")] uint cbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetValueFromHKCUHKLM([NativeTypeName("PCWSTR")] ushort* pwszKey, [NativeTypeName("PCWSTR")] ushort* pwszValue, [NativeTypeName("SRRF")] int srrfFlags, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHRegGetBoolValueFromHKCUHKLM([NativeTypeName("PCWSTR")] ushort* pszKey, [NativeTypeName("PCWSTR")] ushort* pszValue, [NativeTypeName("BOOL")] int fDefault);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHQueryValueExA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHQueryValueExW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD *")] uint* pdwReserved, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHEnumKeyExA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszName, [NativeTypeName("LPDWORD")] uint* pcchName);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHEnumKeyExW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("LPDWORD")] uint* pcchName);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHEnumValueA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("PSTR")] sbyte* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHEnumValueW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("PWSTR")] ushort* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHQueryInfoKeyA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHQueryInfoKeyW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHCopyKeyA([NativeTypeName("HKEY")] IntPtr hkeySrc, [NativeTypeName("LPCSTR")] sbyte* pszSrcSubKey, [NativeTypeName("HKEY")] IntPtr hkeyDest, [NativeTypeName("DWORD")] uint fReserved);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHCopyKeyW([NativeTypeName("HKEY")] IntPtr hkeySrc, [NativeTypeName("LPCWSTR")] ushort* pszSrcSubKey, [NativeTypeName("HKEY")] IntPtr hkeyDest, [NativeTypeName("DWORD")] uint fReserved);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetPathA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* pcszSubKey, [NativeTypeName("LPCSTR")] sbyte* pcszValue, [NativeTypeName("LPSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetPathW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* pcszSubKey, [NativeTypeName("LPCWSTR")] ushort* pcszValue, [NativeTypeName("LPWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegSetPathA([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCSTR")] sbyte* pcszSubKey, [NativeTypeName("LPCSTR")] sbyte* pcszValue, [NativeTypeName("LPCSTR")] sbyte* pcszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegSetPathW([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("LPCWSTR")] ushort* pcszSubKey, [NativeTypeName("LPCWSTR")] ushort* pcszValue, [NativeTypeName("LPCWSTR")] ushort* pcszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegCreateUSKeyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HUSKEY")] IntPtr hRelativeUSKey, [NativeTypeName("PHUSKEY")] IntPtr* phNewUSKey, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegCreateUSKeyW([NativeTypeName("LPCWSTR")] ushort* pwzPath, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HUSKEY")] IntPtr hRelativeUSKey, [NativeTypeName("PHUSKEY")] IntPtr* phNewUSKey, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegOpenUSKeyA([NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HUSKEY")] IntPtr hRelativeUSKey, [NativeTypeName("PHUSKEY")] IntPtr* phNewUSKey, [NativeTypeName("BOOL")] int fIgnoreHKCU);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegOpenUSKeyW([NativeTypeName("LPCWSTR")] ushort* pwzPath, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HUSKEY")] IntPtr hRelativeUSKey, [NativeTypeName("PHUSKEY")] IntPtr* phNewUSKey, [NativeTypeName("BOOL")] int fIgnoreHKCU);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegQueryUSValueA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegQueryUSValueW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegWriteUSValueA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegWriteUSValueW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCWSTR")] ushort* pwzValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegDeleteUSValueA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, SHREGDEL_FLAGS delRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegDeleteUSValueW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCWSTR")] ushort* pwzValue, SHREGDEL_FLAGS delRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegDeleteEmptyUSKeyW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCWSTR")] ushort* pwzSubKey, SHREGDEL_FLAGS delRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegDeleteEmptyUSKeyA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPCSTR")] sbyte* pszSubKey, SHREGDEL_FLAGS delRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegEnumUSKeyA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszName, [NativeTypeName("LPDWORD")] uint* pcchName, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegEnumUSKeyW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pwzName, [NativeTypeName("LPDWORD")] uint* pcchName, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegEnumUSValueA([NativeTypeName("HUSKEY")] IntPtr hUSkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegEnumUSValueW([NativeTypeName("HUSKEY")] IntPtr hUSkey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* pszValueName, [NativeTypeName("LPDWORD")] uint* pcchValueName, [NativeTypeName("LPDWORD")] uint* pdwType, void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegQueryInfoUSKeyA([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegQueryInfoUSKeyW([NativeTypeName("HUSKEY")] IntPtr hUSKey, [NativeTypeName("LPDWORD")] uint* pcSubKeys, [NativeTypeName("LPDWORD")] uint* pcchMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* pcValues, [NativeTypeName("LPDWORD")] uint* pcchMaxValueNameLen, SHREGENUM_FLAGS enumRegFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegCloseUSKey([NativeTypeName("HUSKEY")] IntPtr hUSKey);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegGetUSValueW([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD *")] uint* pdwType, void* pvData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BOOL")] int fIgnoreHKCU, void* pvDefaultData, [NativeTypeName("DWORD")] uint dwDefaultDataSize);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegSetUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LSTATUS")]
        public static extern int SHRegSetUSValueW([NativeTypeName("LPCWSTR")] ushort* pwzSubKey, [NativeTypeName("LPCWSTR")] ushort* pwzValue, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHRegGetIntW([NativeTypeName("HKEY")] IntPtr hk, [NativeTypeName("PCWSTR")] ushort* pwzKey, int iDefault);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHRegGetBoolUSValueA([NativeTypeName("LPCSTR")] sbyte* pszSubKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("BOOL")] int fIgnoreHKCU, [NativeTypeName("BOOL")] int fDefault);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHRegGetBoolUSValueW([NativeTypeName("LPCWSTR")] ushort* pszSubKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("BOOL")] int fIgnoreHKCU, [NativeTypeName("BOOL")] int fDefault);

        public const int ASSOCF_NONE = 0x00000000;
        public const int ASSOCF_INIT_NOREMAPCLSID = 0x00000001;
        public const int ASSOCF_INIT_BYEXENAME = 0x00000002;
        public const int ASSOCF_OPEN_BYEXENAME = 0x00000002;
        public const int ASSOCF_INIT_DEFAULTTOSTAR = 0x00000004;
        public const int ASSOCF_INIT_DEFAULTTOFOLDER = 0x00000008;
        public const int ASSOCF_NOUSERSETTINGS = 0x00000010;
        public const int ASSOCF_NOTRUNCATE = 0x00000020;
        public const int ASSOCF_VERIFY = 0x00000040;
        public const int ASSOCF_REMAPRUNDLL = 0x00000080;
        public const int ASSOCF_NOFIXUPS = 0x00000100;
        public const int ASSOCF_IGNOREBASECLASS = 0x00000200;
        public const int ASSOCF_INIT_IGNOREUNKNOWN = 0x00000400;
        public const int ASSOCF_INIT_FIXED_PROGID = 0x00000800;
        public const int ASSOCF_IS_PROTOCOL = 0x00001000;
        public const int ASSOCF_INIT_FOR_FILE = 0x00002000;
        public const int ASSOCF_IS_FULL_URI = 0x00004000;
        public const int ASSOCF_PER_MACHINE_ONLY = 0x00008000;
        public const int ASSOCF_APP_TO_APP = 0x00010000;

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocCreate([NativeTypeName("CLSID")] Guid clsid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SHGetAssocKeys(IQueryAssociations* pqa, [NativeTypeName("HKEY *")] IntPtr* rgKeys, [NativeTypeName("DWORD")] uint cKeys);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryStringA([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCSTR")] sbyte* pszAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, [NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryStringW([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryStringByKeyA([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("HKEY")] IntPtr hkAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, [NativeTypeName("LPSTR")] sbyte* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryStringByKeyW([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("HKEY")] IntPtr hkAssoc, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryKeyA([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCSTR")] sbyte* pszAssoc, [NativeTypeName("LPCSTR")] sbyte* pszExtra, [NativeTypeName("HKEY *")] IntPtr* phkeyOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocQueryKeyW([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("HKEY *")] IntPtr* phkeyOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AssocIsDangerous([NativeTypeName("PCWSTR")] ushort* pszAssoc);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int AssocGetPerceivedType([NativeTypeName("PCWSTR")] ushort* pszExt, PERCEIVED* ptype, [NativeTypeName("PERCEIVEDFLAG *")] uint* pflag, [NativeTypeName("PWSTR *")] ushort** ppszType);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern IStream* SHOpenRegStreamA([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint grfMode);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern IStream* SHOpenRegStreamW([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubkey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint grfMode);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern IStream* SHOpenRegStream2A([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCSTR")] sbyte* pszSubkey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("DWORD")] uint grfMode);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern IStream* SHOpenRegStream2W([NativeTypeName("HKEY")] IntPtr hkey, [NativeTypeName("LPCWSTR")] ushort* pszSubkey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint grfMode);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateStreamOnFileA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("DWORD")] uint grfMode, IStream** ppstm);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateStreamOnFileW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("DWORD")] uint grfMode, IStream** ppstm);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateStreamOnFileEx([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("BOOL")] int fCreate, IStream* pstmTemplate, IStream** ppstm);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern IStream* SHCreateMemStream([NativeTypeName("const BYTE *")] byte* pInit, [NativeTypeName("UINT")] uint cbInit);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetAcceptLanguagesA([NativeTypeName("LPSTR")] sbyte* pszLanguages, [NativeTypeName("DWORD *")] uint* pcchLanguages);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetAcceptLanguagesW([NativeTypeName("LPWSTR")] ushort* pszLanguages, [NativeTypeName("DWORD *")] uint* pcchLanguages);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void IUnknown_Set(IUnknown** ppunk, IUnknown* punk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void IUnknown_AtomicRelease(void** ppunk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IUnknown_GetWindow(IUnknown* punk, [NativeTypeName("HWND *")] IntPtr* phwnd);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IUnknown_SetSite(IUnknown* punk, IUnknown* punkSite);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IUnknown_GetSite(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IUnknown_QueryService(IUnknown* punk, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Read(IStream* pstm, void* pv, [NativeTypeName("ULONG")] uint cb);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Write(IStream* pstm, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Reset(IStream* pstm);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Size(IStream* pstm, ULARGE_INTEGER* pui);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ConnectToConnectionPoint(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riidEvent, [NativeTypeName("BOOL")] int fConnect, IUnknown* punkTarget, [NativeTypeName("DWORD *")] uint* pdwCookie, IConnectionPoint** ppcpOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_ReadPidl(IStream* pstm, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_WritePidl(IStream* pstm, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlWrite);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_ReadStr(IStream* pstm, [NativeTypeName("PWSTR *")] ushort** ppsz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_WriteStr(IStream* pstm, [NativeTypeName("PCWSTR")] ushort* psz);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IStream_Copy(IStream* pstmFrom, IStream* pstmTo, [NativeTypeName("DWORD")] uint cb);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetViewStatePropertyBag([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("PCWSTR")] ushort* pszBagName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHFormatDateTimeA([NativeTypeName("const FILETIME *")] FILETIME* pft, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPSTR")] sbyte* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHFormatDateTimeW([NativeTypeName("const FILETIME *")] FILETIME* pft, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPWSTR")] ushort* pszBuf, [NativeTypeName("UINT")] uint cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHAnsiToUnicode([NativeTypeName("PCSTR")] sbyte* pszSrc, [NativeTypeName("PWSTR")] ushort* pwszDst, int cwchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHAnsiToAnsi([NativeTypeName("PCSTR")] sbyte* pszSrc, [NativeTypeName("PSTR")] sbyte* pszDst, int cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHUnicodeToAnsi([NativeTypeName("PCWSTR")] ushort* pwszSrc, [NativeTypeName("PSTR")] sbyte* pszDst, int cchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHUnicodeToUnicode([NativeTypeName("PCWSTR")] ushort* pwzSrc, [NativeTypeName("PWSTR")] ushort* pwzDst, int cwchBuf);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHMessageBoxCheckA([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCSTR")] sbyte* pszText, [NativeTypeName("LPCSTR")] sbyte* pszCaption, [NativeTypeName("UINT")] uint uType, int iDefault, [NativeTypeName("LPCSTR")] sbyte* pszRegVal);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int SHMessageBoxCheckW([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("LPCWSTR")] ushort* pszText, [NativeTypeName("LPCWSTR")] ushort* pszCaption, [NativeTypeName("UINT")] uint uType, int iDefault, [NativeTypeName("LPCWSTR")] ushort* pszRegVal);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SHSendMessageBroadcastA([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SHSendMessageBroadcastW([NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("CHAR")]
        public static extern sbyte SHStripMneumonicA([NativeTypeName("LPSTR")] sbyte* pszMenu);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("WCHAR")]
        public static extern ushort SHStripMneumonicW([NativeTypeName("LPWSTR")] ushort* pszMenu);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsOS([NativeTypeName("DWORD")] uint dwOS);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SHGlobalCounterGetValue([NativeTypeName("const SHGLOBALCOUNTER")] SHGLOBALCOUNTER id);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SHGlobalCounterIncrement([NativeTypeName("const SHGLOBALCOUNTER")] SHGLOBALCOUNTER id);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SHGlobalCounterDecrement([NativeTypeName("const SHGLOBALCOUNTER")] SHGLOBALCOUNTER id);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr SHAllocShared([NativeTypeName("const void *")] void* pvData, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHFreeShared([NativeTypeName("HANDLE")] IntPtr hData, [NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void* SHLockShared([NativeTypeName("HANDLE")] IntPtr hData, [NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHUnlockShared(void* pvData);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint WhichPlatform();

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int QISearch(void* that, [NativeTypeName("LPCQITAB")] QITAB* pqit, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHIsLowMemoryMachine([NativeTypeName("DWORD")] uint dwType);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern int GetMenuPosFromID([NativeTypeName("HMENU")] IntPtr hmenu, [NativeTypeName("UINT")] uint id);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetInverseCMAP([NativeTypeName("BYTE *")] byte* pbMap, [NativeTypeName("ULONG")] uint cbMap);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHAutoComplete([NativeTypeName("HWND")] IntPtr hwndEdit, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateThreadRef([NativeTypeName("LONG *")] int* pcRef, IUnknown** ppunk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHSetThreadRef(IUnknown* punk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetThreadRef(IUnknown** ppunk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHSkipJunction(IBindCtx* pbc, [NativeTypeName("const CLSID *")] Guid* pclsid);

        public const int CTF_INSIST = 0x00000001;
        public const int CTF_THREAD_REF = 0x00000002;
        public const int CTF_PROCESS_REF = 0x00000004;
        public const int CTF_COINIT_STA = 0x00000008;
        public const int CTF_COINIT = 0x00000008;
        public const int CTF_FREELIBANDEXIT = 0x00000010;
        public const int CTF_REF_COUNTED = 0x00000020;
        public const int CTF_WAIT_ALLOWCOM = 0x00000040;
        public const int CTF_UNUSED = 0x00000080;
        public const int CTF_INHERITWOW64 = 0x00000100;
        public const int CTF_WAIT_NO_REENTRANCY = 0x00000200;
        public const int CTF_KEYBOARD_LOCALE = 0x00000400;
        public const int CTF_OLEINITIALIZE = 0x00000800;
        public const int CTF_COINIT_MTA = 0x00001000;
        public const int CTF_NOADDREFLIB = 0x00002000;

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHCreateThread([NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc, void* pData, [NativeTypeName("SHCT_FLAGS")] uint flags, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SHCreateThreadWithHandle([NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnThreadProc, void* pData, [NativeTypeName("SHCT_FLAGS")] uint flags, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> pfnCallback, [NativeTypeName("HANDLE *")] IntPtr* pHandle);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void SetProcessReference(IUnknown* punk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetProcessReference(IUnknown** punk);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHReleaseThreadRef();

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HPALETTE")]
        public static extern IntPtr SHCreateShellPalette([NativeTypeName("HDC")] IntPtr hdc);

        [DllImport("Shlwapi", ExactSpelling = true)]
        public static extern void ColorRGBToHLS([NativeTypeName("COLORREF")] uint clrRGB, [NativeTypeName("WORD *")] ushort* pwHue, [NativeTypeName("WORD *")] ushort* pwLuminance, [NativeTypeName("WORD *")] ushort* pwSaturation);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint ColorHLSToRGB([NativeTypeName("WORD")] ushort wHue, [NativeTypeName("WORD")] ushort wLuminance, [NativeTypeName("WORD")] ushort wSaturation);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("COLORREF")]
        public static extern uint ColorAdjustLuma([NativeTypeName("COLORREF")] uint clrRGB, int n, [NativeTypeName("BOOL")] int fScale);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllInstall([NativeTypeName("BOOL")] int bInstall, [NativeTypeName("PCWSTR")] ushort* pszCmdLine);

        [DllImport("Shlwapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsInternetESCEnabled();

        [NativeTypeName("#define STIF_DEFAULT 0x00000000L")]
        public const int STIF_DEFAULT = 0x00000000;

        [NativeTypeName("#define STIF_SUPPORT_HEX 0x00000001L")]
        public const int STIF_SUPPORT_HEX = 0x00000001;

        [NativeTypeName("#define StrRetToStr StrRetToStrW")]
        public static delegate*<STRRET*, ITEMIDLIST*, ushort**, int> StrRetToStr => &StrRetToStrW;

        [NativeTypeName("#define StrRetToBuf StrRetToBufW")]
        public static delegate*<STRRET*, ITEMIDLIST*, ushort*, uint, int> StrRetToBuf => &StrRetToBufW;

        [NativeTypeName("#define SHStrDup SHStrDupW")]
        public static delegate*<ushort*, ushort**, int> SHStrDup => &SHStrDupW;

        [NativeTypeName("#define SHLocalStrDup SHLocalStrDupW")]
        public static delegate*<ushort*, ushort**, int> SHLocalStrDup => &SHLocalStrDupW;

        [NativeTypeName("#define IsCharSpace IsCharSpaceW")]
        public static delegate*<ushort, int> IsCharSpace => &IsCharSpaceW;

        [NativeTypeName("#define StrCmpC StrCmpCW")]
        public static delegate*<ushort*, ushort*, int> StrCmpC => &StrCmpCW;

        [NativeTypeName("#define StrCmpIC StrCmpICW")]
        public static delegate*<ushort*, ushort*, int> StrCmpIC => &StrCmpICW;

        [NativeTypeName("#define StrChr StrChrW")]
        public static delegate*<ushort*, ushort, ushort*> StrChr => &StrChrW;

        [NativeTypeName("#define StrRChr StrRChrW")]
        public static delegate*<ushort*, ushort*, ushort, ushort*> StrRChr => &StrRChrW;

        [NativeTypeName("#define StrChrI StrChrIW")]
        public static delegate*<ushort*, ushort, ushort*> StrChrI => &StrChrIW;

        [NativeTypeName("#define StrRChrI StrRChrIW")]
        public static delegate*<ushort*, ushort*, ushort, ushort*> StrRChrI => &StrRChrIW;

        [NativeTypeName("#define StrCmpN StrCmpNW")]
        public static delegate*<ushort*, ushort*, int, int> StrCmpN => &StrCmpNW;

        [NativeTypeName("#define StrCmpNI StrCmpNIW")]
        public static delegate*<ushort*, ushort*, int, int> StrCmpNI => &StrCmpNIW;

        [NativeTypeName("#define StrStr StrStrW")]
        public static delegate*<ushort*, ushort*, ushort*> StrStr => &StrStrW;

        [NativeTypeName("#define StrStrI StrStrIW")]
        public static delegate*<ushort*, ushort*, ushort*> StrStrI => &StrStrIW;

        [NativeTypeName("#define StrDup StrDupW")]
        public static delegate*<ushort*, ushort*> StrDup => &StrDupW;

        [NativeTypeName("#define StrRStrI StrRStrIW")]
        public static delegate*<ushort*, ushort*, ushort*, ushort*> StrRStrI => &StrRStrIW;

        [NativeTypeName("#define StrCSpn StrCSpnW")]
        public static delegate*<ushort*, ushort*, int> StrCSpn => &StrCSpnW;

        [NativeTypeName("#define StrCSpnI StrCSpnIW")]
        public static delegate*<ushort*, ushort*, int> StrCSpnI => &StrCSpnIW;

        [NativeTypeName("#define StrSpn StrSpnW")]
        public static delegate*<ushort*, ushort*, int> StrSpn => &StrSpnW;

        [NativeTypeName("#define StrToInt StrToIntW")]
        public static delegate*<ushort*, int> StrToInt => &StrToIntW;

        [NativeTypeName("#define StrPBrk StrPBrkW")]
        public static delegate*<ushort*, ushort*, ushort*> StrPBrk => &StrPBrkW;

        [NativeTypeName("#define StrToIntEx StrToIntExW")]
        public static delegate*<ushort*, int, int*, int> StrToIntEx => &StrToIntExW;

        [NativeTypeName("#define StrToInt64Ex StrToInt64ExW")]
        public static delegate*<ushort*, int, long*, int> StrToInt64Ex => &StrToInt64ExW;

        [NativeTypeName("#define StrFromTimeInterval StrFromTimeIntervalW")]
        public static delegate*<ushort*, uint, uint, int, int> StrFromTimeInterval => &StrFromTimeIntervalW;

        [NativeTypeName("#define StrFormatByteSize StrFormatByteSizeW")]
        public static delegate*<long, ushort*, uint, ushort*> StrFormatByteSize => &StrFormatByteSizeW;

        [NativeTypeName("#define StrFormatByteSize64 StrFormatByteSizeW")]
        public static delegate*<long, ushort*, uint, ushort*> StrFormatByteSize64 => &StrFormatByteSizeW;

        [NativeTypeName("#define StrFormatKBSize StrFormatKBSizeW")]
        public static delegate*<long, ushort*, uint, ushort*> StrFormatKBSize => &StrFormatKBSizeW;

        [NativeTypeName("#define StrNCat StrNCatW")]
        public static delegate*<ushort*, ushort*, int, ushort*> StrNCat => &StrNCatW;

        [NativeTypeName("#define StrTrim StrTrimW")]
        public static delegate*<ushort*, ushort*, int> StrTrim => &StrTrimW;

        [NativeTypeName("#define StrCatBuff StrCatBuffW")]
        public static delegate*<ushort*, ushort*, int, ushort*> StrCatBuff => &StrCatBuffW;

        [NativeTypeName("#define ChrCmpI ChrCmpIW")]
        public static delegate*<ushort, ushort, int> ChrCmpI => &ChrCmpIW;

        [NativeTypeName("#define wvnsprintf wvnsprintfW")]
        public static delegate*<ushort*, int, ushort*, sbyte*, int> wvnsprintf => &wvnsprintfW;

        [NativeTypeName("#define wnsprintf wnsprintfW")]
        public static delegate*<ushort*, int, ushort*, int> wnsprintf => &wnsprintfW;

        [NativeTypeName("#define StrIsIntlEqual StrIsIntlEqualW")]
        public static delegate*<int, ushort*, ushort*, int, int> StrIsIntlEqual => &StrIsIntlEqualW;

        [NativeTypeName("#define StrCmpNC StrCmpNCW")]
        public static delegate*<ushort*, ushort*, int, int> StrCmpNC => &StrCmpNCW;

        [NativeTypeName("#define StrCmpNIC StrCmpNICW")]
        public static delegate*<ushort*, ushort*, int, int> StrCmpNIC => &StrCmpNICW;

        [NativeTypeName("#define SZ_CONTENTTYPE_HTMLA \"text/html\"")]
        public static ReadOnlySpan<byte> SZ_CONTENTTYPE_HTMLA => new byte[] { 0x74, 0x65, 0x78, 0x74, 0x2F, 0x68, 0x74, 0x6D, 0x6C, 0x00 };

        [NativeTypeName("#define SZ_CONTENTTYPE_HTMLW L\"text/html\"")]
        public const string SZ_CONTENTTYPE_HTMLW = "text/html";

        [NativeTypeName("#define SZ_CONTENTTYPE_CDFA \"application/x-cdf\"")]
        public static ReadOnlySpan<byte> SZ_CONTENTTYPE_CDFA => new byte[] { 0x61, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x2F, 0x78, 0x2D, 0x63, 0x64, 0x66, 0x00 };

        [NativeTypeName("#define SZ_CONTENTTYPE_CDFW L\"application/x-cdf\"")]
        public const string SZ_CONTENTTYPE_CDFW = "application/x-cdf";

        [NativeTypeName("#define SZ_CONTENTTYPE_HTML SZ_CONTENTTYPE_HTMLW")]
        public const string SZ_CONTENTTYPE_HTML = "text/html";

        [NativeTypeName("#define SZ_CONTENTTYPE_CDF SZ_CONTENTTYPE_CDFW")]
        public const string SZ_CONTENTTYPE_CDF = "application/x-cdf";

        [NativeTypeName("#define StrCatA lstrcatA")]
        public static delegate*<sbyte*, sbyte*, sbyte*> StrCatA => &lstrcatA;

        [NativeTypeName("#define StrCmpA lstrcmpA")]
        public static delegate*<sbyte*, sbyte*, int> StrCmpA => &lstrcmpA;

        [NativeTypeName("#define StrCmpIA lstrcmpiA")]
        public static delegate*<sbyte*, sbyte*, int> StrCmpIA => &lstrcmpiA;

        [NativeTypeName("#define StrCpyA lstrcpyA")]
        public static delegate*<sbyte*, sbyte*, sbyte*> StrCpyA => &lstrcpyA;

        [NativeTypeName("#define StrCpyNA lstrcpynA")]
        public static delegate*<sbyte*, sbyte*, int, sbyte*> StrCpyNA => &lstrcpynA;

        [NativeTypeName("#define StrToLong StrToInt")]
        public static delegate*<ushort*, int> StrToLong => &StrToIntW;

        [NativeTypeName("#define StrNCmp StrCmpN")]
        public static delegate*<ushort*, ushort*, int, int> StrNCmp => &StrCmpNW;

        [NativeTypeName("#define StrNCmpI StrCmpNI")]
        public static delegate*<ushort*, ushort*, int, int> StrNCmpI => &StrCmpNIW;

        [NativeTypeName("#define StrNCpy StrCpyN")]
        public static delegate*<ushort*, ushort*, int, ushort*> StrNCpy => &StrCpyNW;

        [NativeTypeName("#define StrCatN StrNCat")]
        public static delegate*<ushort*, ushort*, int, ushort*> StrCatN => &StrNCatW;

        [NativeTypeName("#define StrCat StrCatW")]
        public static delegate*<ushort*, ushort*, ushort*> StrCat => &StrCatW;

        [NativeTypeName("#define StrCmp StrCmpW")]
        public static delegate*<ushort*, ushort*, int> StrCmp => &StrCmpW;

        [NativeTypeName("#define StrCmpI StrCmpIW")]
        public static delegate*<ushort*, ushort*, int> StrCmpI => &StrCmpIW;

        [NativeTypeName("#define StrCpy StrCpyW")]
        public static delegate*<ushort*, ushort*, ushort*> StrCpy => &StrCpyW;

        [NativeTypeName("#define StrCpyN StrCpyNW")]
        public static delegate*<ushort*, ushort*, int, ushort*> StrCpyN => &StrCpyNW;

        [NativeTypeName("#define PathAddBackslash PathAddBackslashW")]
        public static delegate*<ushort*, ushort*> PathAddBackslash => &PathAddBackslashW;

        [NativeTypeName("#define PathAddExtension PathAddExtensionW")]
        public static delegate*<ushort*, ushort*, int> PathAddExtension => &PathAddExtensionW;

        [NativeTypeName("#define PathBuildRoot PathBuildRootW")]
        public static delegate*<ushort*, int, ushort*> PathBuildRoot => &PathBuildRootW;

        [NativeTypeName("#define PathCombine PathCombineW")]
        public static delegate*<ushort*, ushort*, ushort*, ushort*> PathCombine => &PathCombineW;

        [NativeTypeName("#define PathFileExists PathFileExistsW")]
        public static delegate*<ushort*, int> PathFileExists => &PathFileExistsW;

        [NativeTypeName("#define PathFindExtension PathFindExtensionW")]
        public static delegate*<ushort*, ushort*> PathFindExtension => &PathFindExtensionW;

        [NativeTypeName("#define PathFindFileName PathFindFileNameW")]
        public static delegate*<ushort*, ushort*> PathFindFileName => &PathFindFileNameW;

        [NativeTypeName("#define PathFindNextComponent PathFindNextComponentW")]
        public static delegate*<ushort*, ushort*> PathFindNextComponent => &PathFindNextComponentW;

        [NativeTypeName("#define PathFindSuffixArray PathFindSuffixArrayW")]
        public static delegate*<ushort*, ushort**, int, ushort*> PathFindSuffixArray => &PathFindSuffixArrayW;

        [NativeTypeName("#define PathGetArgs PathGetArgsW")]
        public static delegate*<ushort*, ushort*> PathGetArgs => &PathGetArgsW;

        [NativeTypeName("#define PathIsLFNFileSpec PathIsLFNFileSpecW")]
        public static delegate*<ushort*, int> PathIsLFNFileSpec => &PathIsLFNFileSpecW;

        [NativeTypeName("#define GCT_INVALID 0x0000")]
        public const int GCT_INVALID = 0x0000;

        [NativeTypeName("#define GCT_LFNCHAR 0x0001")]
        public const int GCT_LFNCHAR = 0x0001;

        [NativeTypeName("#define GCT_SHORTCHAR 0x0002")]
        public const int GCT_SHORTCHAR = 0x0002;

        [NativeTypeName("#define GCT_WILD 0x0004")]
        public const int GCT_WILD = 0x0004;

        [NativeTypeName("#define GCT_SEPARATOR 0x0008")]
        public const int GCT_SEPARATOR = 0x0008;

        [NativeTypeName("#define PathGetDriveNumber PathGetDriveNumberW")]
        public static delegate*<ushort*, int> PathGetDriveNumber => &PathGetDriveNumberW;

        [NativeTypeName("#define PathIsDirectory PathIsDirectoryW")]
        public static delegate*<ushort*, int> PathIsDirectory => &PathIsDirectoryW;

        [NativeTypeName("#define PathIsDirectoryEmpty PathIsDirectoryEmptyW")]
        public static delegate*<ushort*, int> PathIsDirectoryEmpty => &PathIsDirectoryEmptyW;

        [NativeTypeName("#define PathIsFileSpec PathIsFileSpecW")]
        public static delegate*<ushort*, int> PathIsFileSpec => &PathIsFileSpecW;

        [NativeTypeName("#define PathIsPrefix PathIsPrefixW")]
        public static delegate*<ushort*, ushort*, int> PathIsPrefix => &PathIsPrefixW;

        [NativeTypeName("#define PathIsRelative PathIsRelativeW")]
        public static delegate*<ushort*, int> PathIsRelative => &PathIsRelativeW;

        [NativeTypeName("#define PathIsRoot PathIsRootW")]
        public static delegate*<ushort*, int> PathIsRoot => &PathIsRootW;

        [NativeTypeName("#define PathIsSameRoot PathIsSameRootW")]
        public static delegate*<ushort*, ushort*, int> PathIsSameRoot => &PathIsSameRootW;

        [NativeTypeName("#define PathIsUNC PathIsUNCW")]
        public static delegate*<ushort*, int> PathIsUNC => &PathIsUNCW;

        [NativeTypeName("#define PathIsNetworkPath PathIsNetworkPathW")]
        public static delegate*<ushort*, int> PathIsNetworkPath => &PathIsNetworkPathW;

        [NativeTypeName("#define PathIsUNCServer PathIsUNCServerW")]
        public static delegate*<ushort*, int> PathIsUNCServer => &PathIsUNCServerW;

        [NativeTypeName("#define PathIsUNCServerShare PathIsUNCServerShareW")]
        public static delegate*<ushort*, int> PathIsUNCServerShare => &PathIsUNCServerShareW;

        [NativeTypeName("#define PathIsURL PathIsURLW")]
        public static delegate*<ushort*, int> PathIsURL => &PathIsURLW;

        [NativeTypeName("#define PMSF_NORMAL 0x00000000")]
        public const int PMSF_NORMAL = 0x00000000;

        [NativeTypeName("#define PMSF_MULTIPLE 0x00000001")]
        public const int PMSF_MULTIPLE = 0x00000001;

        [NativeTypeName("#define PMSF_DONT_STRIP_SPACES 0x00010000")]
        public const int PMSF_DONT_STRIP_SPACES = 0x00010000;

        [NativeTypeName("#define PathRemoveBackslash PathRemoveBackslashW")]
        public static delegate*<ushort*, ushort*> PathRemoveBackslash => &PathRemoveBackslashW;

        [NativeTypeName("#define PathSkipRoot PathSkipRootW")]
        public static delegate*<ushort*, ushort*> PathSkipRoot => &PathSkipRootW;

        [NativeTypeName("#define PathStripPath PathStripPathW")]
        public static delegate*<ushort*, void> PathStripPath => &PathStripPathW;

        [NativeTypeName("#define PathStripToRoot PathStripToRootW")]
        public static delegate*<ushort*, int> PathStripToRoot => &PathStripToRootW;

        [NativeTypeName("#define PathMakeSystemFolder PathMakeSystemFolderW")]
        public static delegate*<ushort*, int> PathMakeSystemFolder => &PathMakeSystemFolderW;

        [NativeTypeName("#define PathUnmakeSystemFolder PathUnmakeSystemFolderW")]
        public static delegate*<ushort*, int> PathUnmakeSystemFolder => &PathUnmakeSystemFolderW;

        [NativeTypeName("#define PathIsSystemFolder PathIsSystemFolderW")]
        public static delegate*<ushort*, uint, int> PathIsSystemFolder => &PathIsSystemFolderW;

        [NativeTypeName("#define PathUndecorate PathUndecorateW")]
        public static delegate*<ushort*, void> PathUndecorate => &PathUndecorateW;

        [NativeTypeName("#define PathUnExpandEnvStrings PathUnExpandEnvStringsW")]
        public static delegate*<ushort*, ushort*, uint, int> PathUnExpandEnvStrings => &PathUnExpandEnvStringsW;

        [NativeTypeName("#define PathAppend PathAppendW")]
        public static delegate*<ushort*, ushort*, int> PathAppend => &PathAppendW;

        [NativeTypeName("#define PathCanonicalize PathCanonicalizeW")]
        public static delegate*<ushort*, ushort*, int> PathCanonicalize => &PathCanonicalizeW;

        [NativeTypeName("#define PathCompactPath PathCompactPathW")]
        public static delegate*<IntPtr, ushort*, uint, int> PathCompactPath => &PathCompactPathW;

        [NativeTypeName("#define PathCompactPathEx PathCompactPathExW")]
        public static delegate*<ushort*, ushort*, uint, uint, int> PathCompactPathEx => &PathCompactPathExW;

        [NativeTypeName("#define PathCommonPrefix PathCommonPrefixW")]
        public static delegate*<ushort*, ushort*, ushort*, int> PathCommonPrefix => &PathCommonPrefixW;

        [NativeTypeName("#define PathFindOnPath PathFindOnPathW")]
        public static delegate*<ushort*, ushort**, int> PathFindOnPath => &PathFindOnPathW;

        [NativeTypeName("#define PathGetCharType PathGetCharTypeW")]
        public static delegate*<ushort, uint> PathGetCharType => &PathGetCharTypeW;

        [NativeTypeName("#define PathIsContentType PathIsContentTypeW")]
        public static delegate*<ushort*, ushort*, int> PathIsContentType => &PathIsContentTypeW;

        [NativeTypeName("#define PathMakePretty PathMakePrettyW")]
        public static delegate*<ushort*, int> PathMakePretty => &PathMakePrettyW;

        [NativeTypeName("#define PathMatchSpec PathMatchSpecW")]
        public static delegate*<ushort*, ushort*, int> PathMatchSpec => &PathMatchSpecW;

        [NativeTypeName("#define PathMatchSpecEx PathMatchSpecExW")]
        public static delegate*<ushort*, ushort*, uint, int> PathMatchSpecEx => &PathMatchSpecExW;

        [NativeTypeName("#define PathParseIconLocation PathParseIconLocationW")]
        public static delegate*<ushort*, int> PathParseIconLocation => &PathParseIconLocationW;

        [NativeTypeName("#define PathQuoteSpaces PathQuoteSpacesW")]
        public static delegate*<ushort*, int> PathQuoteSpaces => &PathQuoteSpacesW;

        [NativeTypeName("#define PathRelativePathTo PathRelativePathToW")]
        public static delegate*<ushort*, ushort*, uint, ushort*, uint, int> PathRelativePathTo => &PathRelativePathToW;

        [NativeTypeName("#define PathRemoveArgs PathRemoveArgsW")]
        public static delegate*<ushort*, void> PathRemoveArgs => &PathRemoveArgsW;

        [NativeTypeName("#define PathRemoveBlanks PathRemoveBlanksW")]
        public static delegate*<ushort*, void> PathRemoveBlanks => &PathRemoveBlanksW;

        [NativeTypeName("#define PathRemoveExtension PathRemoveExtensionW")]
        public static delegate*<ushort*, void> PathRemoveExtension => &PathRemoveExtensionW;

        [NativeTypeName("#define PathRemoveFileSpec PathRemoveFileSpecW")]
        public static delegate*<ushort*, int> PathRemoveFileSpec => &PathRemoveFileSpecW;

        [NativeTypeName("#define PathRenameExtension PathRenameExtensionW")]
        public static delegate*<ushort*, ushort*, int> PathRenameExtension => &PathRenameExtensionW;

        [NativeTypeName("#define PathSearchAndQualify PathSearchAndQualifyW")]
        public static delegate*<ushort*, ushort*, uint, int> PathSearchAndQualify => &PathSearchAndQualifyW;

        [NativeTypeName("#define PathSetDlgItemPath PathSetDlgItemPathW")]
        public static delegate*<IntPtr, int, ushort*, void> PathSetDlgItemPath => &PathSetDlgItemPathW;

        [NativeTypeName("#define PathUnquoteSpaces PathUnquoteSpacesW")]
        public static delegate*<ushort*, int> PathUnquoteSpaces => &PathUnquoteSpacesW;

        [NativeTypeName("#define URL_UNESCAPE 0x10000000")]
        public const int URL_UNESCAPE = 0x10000000;

        [NativeTypeName("#define URL_ESCAPE_UNSAFE 0x20000000")]
        public const int URL_ESCAPE_UNSAFE = 0x20000000;

        [NativeTypeName("#define URL_PLUGGABLE_PROTOCOL 0x40000000")]
        public const int URL_PLUGGABLE_PROTOCOL = 0x40000000;

        [NativeTypeName("#define URL_WININET_COMPATIBILITY 0x80000000")]
        public const uint URL_WININET_COMPATIBILITY = 0x80000000;

        [NativeTypeName("#define URL_DONT_ESCAPE_EXTRA_INFO 0x02000000")]
        public const int URL_DONT_ESCAPE_EXTRA_INFO = 0x02000000;

        [NativeTypeName("#define URL_DONT_UNESCAPE_EXTRA_INFO URL_DONT_ESCAPE_EXTRA_INFO")]
        public const int URL_DONT_UNESCAPE_EXTRA_INFO = 0x02000000;

        [NativeTypeName("#define URL_BROWSER_MODE URL_DONT_ESCAPE_EXTRA_INFO")]
        public const int URL_BROWSER_MODE = 0x02000000;

        [NativeTypeName("#define URL_ESCAPE_SPACES_ONLY 0x04000000")]
        public const int URL_ESCAPE_SPACES_ONLY = 0x04000000;

        [NativeTypeName("#define URL_DONT_SIMPLIFY 0x08000000")]
        public const int URL_DONT_SIMPLIFY = 0x08000000;

        [NativeTypeName("#define URL_NO_META URL_DONT_SIMPLIFY")]
        public const int URL_NO_META = 0x08000000;

        [NativeTypeName("#define URL_UNESCAPE_INPLACE 0x00100000")]
        public const int URL_UNESCAPE_INPLACE = 0x00100000;

        [NativeTypeName("#define URL_CONVERT_IF_DOSPATH 0x00200000")]
        public const int URL_CONVERT_IF_DOSPATH = 0x00200000;

        [NativeTypeName("#define URL_UNESCAPE_HIGH_ANSI_ONLY 0x00400000")]
        public const int URL_UNESCAPE_HIGH_ANSI_ONLY = 0x00400000;

        [NativeTypeName("#define URL_INTERNAL_PATH 0x00800000")]
        public const int URL_INTERNAL_PATH = 0x00800000;

        [NativeTypeName("#define URL_FILE_USE_PATHURL 0x00010000")]
        public const int URL_FILE_USE_PATHURL = 0x00010000;

        [NativeTypeName("#define URL_DONT_UNESCAPE 0x00020000")]
        public const int URL_DONT_UNESCAPE = 0x00020000;

        [NativeTypeName("#define URL_ESCAPE_AS_UTF8 0x00040000")]
        public const int URL_ESCAPE_AS_UTF8 = 0x00040000;

        [NativeTypeName("#define URL_UNESCAPE_AS_UTF8 URL_ESCAPE_AS_UTF8")]
        public const int URL_UNESCAPE_AS_UTF8 = 0x00040000;

        [NativeTypeName("#define URL_ESCAPE_ASCII_URI_COMPONENT 0x00080000")]
        public const int URL_ESCAPE_ASCII_URI_COMPONENT = 0x00080000;

        [NativeTypeName("#define URL_ESCAPE_URI_COMPONENT (URL_ESCAPE_ASCII_URI_COMPONENT | URL_ESCAPE_AS_UTF8)")]
        public const int URL_ESCAPE_URI_COMPONENT = (0x00080000 | 0x00040000);

        [NativeTypeName("#define URL_UNESCAPE_URI_COMPONENT URL_UNESCAPE_AS_UTF8")]
        public const int URL_UNESCAPE_URI_COMPONENT = 0x00040000;

        [NativeTypeName("#define URL_ESCAPE_PERCENT 0x00001000")]
        public const int URL_ESCAPE_PERCENT = 0x00001000;

        [NativeTypeName("#define URL_ESCAPE_SEGMENT_ONLY 0x00002000")]
        public const int URL_ESCAPE_SEGMENT_ONLY = 0x00002000;

        [NativeTypeName("#define URL_PARTFLAG_KEEPSCHEME 0x00000001")]
        public const int URL_PARTFLAG_KEEPSCHEME = 0x00000001;

        [NativeTypeName("#define URL_APPLY_DEFAULT 0x00000001")]
        public const int URL_APPLY_DEFAULT = 0x00000001;

        [NativeTypeName("#define URL_APPLY_GUESSSCHEME 0x00000002")]
        public const int URL_APPLY_GUESSSCHEME = 0x00000002;

        [NativeTypeName("#define URL_APPLY_GUESSFILE 0x00000004")]
        public const int URL_APPLY_GUESSFILE = 0x00000004;

        [NativeTypeName("#define URL_APPLY_FORCEAPPLY 0x00000008")]
        public const int URL_APPLY_FORCEAPPLY = 0x00000008;

        [NativeTypeName("#define UrlCompare UrlCompareW")]
        public static delegate*<ushort*, ushort*, int, int> UrlCompare => &UrlCompareW;

        [NativeTypeName("#define UrlCombine UrlCombineW")]
        public static delegate*<ushort*, ushort*, ushort*, uint*, uint, int> UrlCombine => &UrlCombineW;

        [NativeTypeName("#define UrlCanonicalize UrlCanonicalizeW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> UrlCanonicalize => &UrlCanonicalizeW;

        [NativeTypeName("#define UrlIsOpaque UrlIsOpaqueW")]
        public static delegate*<ushort*, int> UrlIsOpaque => &UrlIsOpaqueW;

        [NativeTypeName("#define UrlGetLocation UrlGetLocationW")]
        public static delegate*<ushort*, ushort*> UrlGetLocation => &UrlGetLocationW;

        [NativeTypeName("#define UrlUnescape UrlUnescapeW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> UrlUnescape => &UrlUnescapeW;

        [NativeTypeName("#define UrlEscape UrlEscapeW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> UrlEscape => &UrlEscapeW;

        [NativeTypeName("#define UrlCreateFromPath UrlCreateFromPathW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> UrlCreateFromPath => &UrlCreateFromPathW;

        [NativeTypeName("#define PathCreateFromUrl PathCreateFromUrlW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> PathCreateFromUrl => &PathCreateFromUrlW;

        [NativeTypeName("#define UrlHash UrlHashW")]
        public static delegate*<ushort*, byte*, uint, int> UrlHash => &UrlHashW;

        [NativeTypeName("#define UrlGetPart UrlGetPartW")]
        public static delegate*<ushort*, ushort*, uint*, uint, uint, int> UrlGetPart => &UrlGetPartW;

        [NativeTypeName("#define UrlApplyScheme UrlApplySchemeW")]
        public static delegate*<ushort*, ushort*, uint*, uint, int> UrlApplyScheme => &UrlApplySchemeW;

        [NativeTypeName("#define UrlIs UrlIsW")]
        public static delegate*<ushort*, URLIS, int> UrlIs => &UrlIsW;

        [NativeTypeName("#define UrlFixup UrlFixupW")]
        public static delegate*<ushort*, ushort*, uint, int> UrlFixup => &UrlFixupW;

        [NativeTypeName("#define ParseURL ParseURLW")]
        public static delegate*<ushort*, PARSEDURLW*, int> ParseURL => &ParseURLW;

        [NativeTypeName("#define SHDeleteEmptyKey SHDeleteEmptyKeyW")]
        public static delegate*<IntPtr, ushort*, int> SHDeleteEmptyKey => &SHDeleteEmptyKeyW;

        [NativeTypeName("#define SHDeleteKey SHDeleteKeyW")]
        public static delegate*<IntPtr, ushort*, int> SHDeleteKey => &SHDeleteKeyW;

        [NativeTypeName("#define SHDeleteValue SHDeleteValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, int> SHDeleteValue => &SHDeleteValueW;

        [NativeTypeName("#define SHGetValue SHGetValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint*, void*, uint*, int> SHGetValue => &SHGetValueW;

        [NativeTypeName("#define SHSetValue SHSetValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, void*, uint, int> SHSetValue => &SHSetValueW;

        [NativeTypeName("#define SRRF_RT_REG_NONE 0x00000001")]
        public const int SRRF_RT_REG_NONE = 0x00000001;

        [NativeTypeName("#define SRRF_RT_REG_SZ 0x00000002")]
        public const int SRRF_RT_REG_SZ = 0x00000002;

        [NativeTypeName("#define SRRF_RT_REG_EXPAND_SZ 0x00000004")]
        public const int SRRF_RT_REG_EXPAND_SZ = 0x00000004;

        [NativeTypeName("#define SRRF_RT_REG_BINARY 0x00000008")]
        public const int SRRF_RT_REG_BINARY = 0x00000008;

        [NativeTypeName("#define SRRF_RT_REG_DWORD 0x00000010")]
        public const int SRRF_RT_REG_DWORD = 0x00000010;

        [NativeTypeName("#define SRRF_RT_REG_MULTI_SZ 0x00000020")]
        public const int SRRF_RT_REG_MULTI_SZ = 0x00000020;

        [NativeTypeName("#define SRRF_RT_REG_QWORD 0x00000040")]
        public const int SRRF_RT_REG_QWORD = 0x00000040;

        [NativeTypeName("#define SRRF_RT_DWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_DWORD)")]
        public const int SRRF_RT_DWORD = (0x00000008 | 0x00000010);

        [NativeTypeName("#define SRRF_RT_QWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_QWORD)")]
        public const int SRRF_RT_QWORD = (0x00000008 | 0x00000040);

        [NativeTypeName("#define SRRF_RT_ANY 0x0000ffff")]
        public const int SRRF_RT_ANY = 0x0000ffff;

        [NativeTypeName("#define SRRF_RM_ANY 0x00000000")]
        public const int SRRF_RM_ANY = 0x00000000;

        [NativeTypeName("#define SRRF_RM_NORMAL 0x00010000")]
        public const int SRRF_RM_NORMAL = 0x00010000;

        [NativeTypeName("#define SRRF_RM_SAFE 0x00020000")]
        public const int SRRF_RM_SAFE = 0x00020000;

        [NativeTypeName("#define SRRF_RM_SAFENETWORK 0x00040000")]
        public const int SRRF_RM_SAFENETWORK = 0x00040000;

        [NativeTypeName("#define SRRF_NOEXPAND 0x10000000")]
        public const int SRRF_NOEXPAND = 0x10000000;

        [NativeTypeName("#define SRRF_ZEROONFAILURE 0x20000000")]
        public const int SRRF_ZEROONFAILURE = 0x20000000;

        [NativeTypeName("#define SRRF_NOVIRT 0x40000000")]
        public const int SRRF_NOVIRT = 0x40000000;

        [NativeTypeName("#define SHRegGetValue SHRegGetValueW")]
        public static delegate*<IntPtr, ushort*, ushort*, int, uint*, void*, uint*, int> SHRegGetValue => &SHRegGetValueW;

        [NativeTypeName("#define SHQueryValueEx SHQueryValueExW")]
        public static delegate*<IntPtr, ushort*, uint*, uint*, void*, uint*, int> SHQueryValueEx => &SHQueryValueExW;

        [NativeTypeName("#define SHEnumKeyEx SHEnumKeyExW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, int> SHEnumKeyEx => &SHEnumKeyExW;

        [NativeTypeName("#define SHEnumValue SHEnumValueW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, uint*, void*, uint*, int> SHEnumValue => &SHEnumValueW;

        [NativeTypeName("#define SHQueryInfoKey SHQueryInfoKeyW")]
        public static delegate*<IntPtr, uint*, uint*, uint*, uint*, int> SHQueryInfoKey => &SHQueryInfoKeyW;

        [NativeTypeName("#define SHCopyKey SHCopyKeyW")]
        public static delegate*<IntPtr, ushort*, IntPtr, uint, int> SHCopyKey => &SHCopyKeyW;

        [NativeTypeName("#define SHRegGetPath SHRegGetPathW")]
        public static delegate*<IntPtr, ushort*, ushort*, ushort*, uint, int> SHRegGetPath => &SHRegGetPathW;

        [NativeTypeName("#define SHRegSetPath SHRegSetPathW")]
        public static delegate*<IntPtr, ushort*, ushort*, ushort*, uint, int> SHRegSetPath => &SHRegSetPathW;

        [NativeTypeName("#define SHREGSET_HKCU 0x00000001")]
        public const int SHREGSET_HKCU = 0x00000001;

        [NativeTypeName("#define SHREGSET_FORCE_HKCU 0x00000002")]
        public const int SHREGSET_FORCE_HKCU = 0x00000002;

        [NativeTypeName("#define SHREGSET_HKLM 0x00000004")]
        public const int SHREGSET_HKLM = 0x00000004;

        [NativeTypeName("#define SHREGSET_FORCE_HKLM 0x00000008")]
        public const int SHREGSET_FORCE_HKLM = 0x00000008;

        [NativeTypeName("#define SHREGSET_DEFAULT (SHREGSET_FORCE_HKCU | SHREGSET_HKLM)")]
        public const int SHREGSET_DEFAULT = (0x00000002 | 0x00000004);

        [NativeTypeName("#define SHRegCreateUSKey SHRegCreateUSKeyW")]
        public static delegate*<ushort*, uint, IntPtr, IntPtr*, uint, int> SHRegCreateUSKey => &SHRegCreateUSKeyW;

        [NativeTypeName("#define SHRegOpenUSKey SHRegOpenUSKeyW")]
        public static delegate*<ushort*, uint, IntPtr, IntPtr*, int, int> SHRegOpenUSKey => &SHRegOpenUSKeyW;

        [NativeTypeName("#define SHRegQueryUSValue SHRegQueryUSValueW")]
        public static delegate*<IntPtr, ushort*, uint*, void*, uint*, int, void*, uint, int> SHRegQueryUSValue => &SHRegQueryUSValueW;

        [NativeTypeName("#define SHRegWriteUSValue SHRegWriteUSValueW")]
        public static delegate*<IntPtr, ushort*, uint, void*, uint, uint, int> SHRegWriteUSValue => &SHRegWriteUSValueW;

        [NativeTypeName("#define SHRegDeleteUSValue SHRegDeleteUSValueW")]
        public static delegate*<IntPtr, ushort*, SHREGDEL_FLAGS, int> SHRegDeleteUSValue => &SHRegDeleteUSValueW;

        [NativeTypeName("#define SHRegDeleteEmptyUSKey SHRegDeleteEmptyUSKeyW")]
        public static delegate*<IntPtr, ushort*, SHREGDEL_FLAGS, int> SHRegDeleteEmptyUSKey => &SHRegDeleteEmptyUSKeyW;

        [NativeTypeName("#define SHRegEnumUSKey SHRegEnumUSKeyW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, SHREGENUM_FLAGS, int> SHRegEnumUSKey => &SHRegEnumUSKeyW;

        [NativeTypeName("#define SHRegEnumUSValue SHRegEnumUSValueW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, uint*, void*, uint*, SHREGENUM_FLAGS, int> SHRegEnumUSValue => &SHRegEnumUSValueW;

        [NativeTypeName("#define SHRegQueryInfoUSKey SHRegQueryInfoUSKeyW")]
        public static delegate*<IntPtr, uint*, uint*, uint*, uint*, SHREGENUM_FLAGS, int> SHRegQueryInfoUSKey => &SHRegQueryInfoUSKeyW;

        [NativeTypeName("#define SHRegGetUSValue SHRegGetUSValueW")]
        public static delegate*<ushort*, ushort*, uint*, void*, uint*, int, void*, uint, int> SHRegGetUSValue => &SHRegGetUSValueW;

        [NativeTypeName("#define SHRegSetUSValue SHRegSetUSValueW")]
        public static delegate*<ushort*, ushort*, uint, void*, uint, uint, int> SHRegSetUSValue => &SHRegSetUSValueW;

        [NativeTypeName("#define SHRegGetInt SHRegGetIntW")]
        public static delegate*<IntPtr, ushort*, int, int> SHRegGetInt => &SHRegGetIntW;

        [NativeTypeName("#define SHRegGetBoolUSValue SHRegGetBoolUSValueW")]
        public static delegate*<ushort*, ushort*, int, int, int> SHRegGetBoolUSValue => &SHRegGetBoolUSValueW;

        [NativeTypeName("#define AssocQueryString AssocQueryStringW")]
        public static delegate*<uint, ASSOCSTR, ushort*, ushort*, ushort*, uint*, int> AssocQueryString => &AssocQueryStringW;

        [NativeTypeName("#define AssocQueryStringByKey AssocQueryStringByKeyW")]
        public static delegate*<uint, ASSOCSTR, IntPtr, ushort*, ushort*, uint*, int> AssocQueryStringByKey => &AssocQueryStringByKeyW;

        [NativeTypeName("#define AssocQueryKey AssocQueryKeyW")]
        public static delegate*<uint, ASSOCKEY, ushort*, ushort*, IntPtr*, int> AssocQueryKey => &AssocQueryKeyW;

        [NativeTypeName("#define SHOpenRegStream SHOpenRegStreamW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, IStream*> SHOpenRegStream => &SHOpenRegStreamW;

        [NativeTypeName("#define SHOpenRegStream2 SHOpenRegStream2W")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, IStream*> SHOpenRegStream2 => &SHOpenRegStream2W;

        [NativeTypeName("#define SHCreateStreamOnFile SHCreateStreamOnFileW")]
        public static delegate*<ushort*, uint, IStream**, int> SHCreateStreamOnFile => &SHCreateStreamOnFileW;

        [NativeTypeName("#define GetAcceptLanguages GetAcceptLanguagesW")]
        public static delegate*<ushort*, uint*, int> GetAcceptLanguages => &GetAcceptLanguagesW;

        [NativeTypeName("#define SHGVSPB_PERUSER 0x00000001")]
        public const int SHGVSPB_PERUSER = 0x00000001;

        [NativeTypeName("#define SHGVSPB_ALLUSERS 0x00000002")]
        public const int SHGVSPB_ALLUSERS = 0x00000002;

        [NativeTypeName("#define SHGVSPB_PERFOLDER 0x00000004")]
        public const int SHGVSPB_PERFOLDER = 0x00000004;

        [NativeTypeName("#define SHGVSPB_ALLFOLDERS 0x00000008")]
        public const int SHGVSPB_ALLFOLDERS = 0x00000008;

        [NativeTypeName("#define SHGVSPB_INHERIT 0x00000010")]
        public const int SHGVSPB_INHERIT = 0x00000010;

        [NativeTypeName("#define SHGVSPB_ROAM 0x00000020")]
        public const int SHGVSPB_ROAM = 0x00000020;

        [NativeTypeName("#define SHGVSPB_NOAUTODEFAULTS 0x80000000")]
        public const uint SHGVSPB_NOAUTODEFAULTS = 0x80000000;

        [NativeTypeName("#define SHGVSPB_FOLDER (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER)")]
        public const int SHGVSPB_FOLDER = (0x00000001 | 0x00000004);

        [NativeTypeName("#define SHGVSPB_FOLDERNODEFAULTS (SHGVSPB_PERUSER | SHGVSPB_PERFOLDER | SHGVSPB_NOAUTODEFAULTS)")]
        public const uint SHGVSPB_FOLDERNODEFAULTS = (0x00000001 | 0x00000004 | 0x80000000);

        [NativeTypeName("#define SHGVSPB_USERDEFAULTS (SHGVSPB_PERUSER | SHGVSPB_ALLFOLDERS)")]
        public const int SHGVSPB_USERDEFAULTS = (0x00000001 | 0x00000008);

        [NativeTypeName("#define SHGVSPB_GLOBALDEFAULTS (SHGVSPB_ALLUSERS | SHGVSPB_ALLFOLDERS)")]
        public const int SHGVSPB_GLOBALDEFAULTS = (0x00000002 | 0x00000008);

        [NativeTypeName("#define FDTF_SHORTTIME 0x00000001")]
        public const int FDTF_SHORTTIME = 0x00000001;

        [NativeTypeName("#define FDTF_SHORTDATE 0x00000002")]
        public const int FDTF_SHORTDATE = 0x00000002;

        [NativeTypeName("#define FDTF_DEFAULT (FDTF_SHORTDATE | FDTF_SHORTTIME)")]
        public const int FDTF_DEFAULT = (0x00000002 | 0x00000001);

        [NativeTypeName("#define FDTF_LONGDATE 0x00000004")]
        public const int FDTF_LONGDATE = 0x00000004;

        [NativeTypeName("#define FDTF_LONGTIME 0x00000008")]
        public const int FDTF_LONGTIME = 0x00000008;

        [NativeTypeName("#define FDTF_RELATIVE 0x00000010")]
        public const int FDTF_RELATIVE = 0x00000010;

        [NativeTypeName("#define FDTF_LTRDATE 0x00000100")]
        public const int FDTF_LTRDATE = 0x00000100;

        [NativeTypeName("#define FDTF_RTLDATE 0x00000200")]
        public const int FDTF_RTLDATE = 0x00000200;

        [NativeTypeName("#define FDTF_NOAUTOREADINGORDER 0x00000400")]
        public const int FDTF_NOAUTOREADINGORDER = 0x00000400;

        [NativeTypeName("#define SHFormatDateTime SHFormatDateTimeW")]
        public static delegate*<FILETIME*, uint*, ushort*, uint, int> SHFormatDateTime => &SHFormatDateTimeW;

        [NativeTypeName("#define SHMessageBoxCheck SHMessageBoxCheckW")]
        public static delegate*<IntPtr, ushort*, ushort*, uint, int, ushort*, int> SHMessageBoxCheck => &SHMessageBoxCheckW;

        [NativeTypeName("#define SHSendMessageBroadcast SHSendMessageBroadcastW")]
        public static delegate*<uint, nuint, nint, nint> SHSendMessageBroadcast => &SHSendMessageBroadcastW;

        [NativeTypeName("#define SHStripMneumonic SHStripMneumonicW")]
        public static delegate*<ushort*, ushort> SHStripMneumonic => &SHStripMneumonicW;

        [NativeTypeName("#define OS_WINDOWS 0")]
        public const int OS_WINDOWS = 0;

        [NativeTypeName("#define OS_NT 1")]
        public const int OS_NT = 1;

        [NativeTypeName("#define OS_WIN95ORGREATER 2")]
        public const int OS_WIN95ORGREATER = 2;

        [NativeTypeName("#define OS_NT4ORGREATER 3")]
        public const int OS_NT4ORGREATER = 3;

        [NativeTypeName("#define OS_WIN98ORGREATER 5")]
        public const int OS_WIN98ORGREATER = 5;

        [NativeTypeName("#define OS_WIN98_GOLD 6")]
        public const int OS_WIN98_GOLD = 6;

        [NativeTypeName("#define OS_WIN2000ORGREATER 7")]
        public const int OS_WIN2000ORGREATER = 7;

        [NativeTypeName("#define OS_WIN2000PRO 8")]
        public const int OS_WIN2000PRO = 8;

        [NativeTypeName("#define OS_WIN2000SERVER 9")]
        public const int OS_WIN2000SERVER = 9;

        [NativeTypeName("#define OS_WIN2000ADVSERVER 10")]
        public const int OS_WIN2000ADVSERVER = 10;

        [NativeTypeName("#define OS_WIN2000DATACENTER 11")]
        public const int OS_WIN2000DATACENTER = 11;

        [NativeTypeName("#define OS_WIN2000TERMINAL 12")]
        public const int OS_WIN2000TERMINAL = 12;

        [NativeTypeName("#define OS_EMBEDDED 13")]
        public const int OS_EMBEDDED = 13;

        [NativeTypeName("#define OS_TERMINALCLIENT 14")]
        public const int OS_TERMINALCLIENT = 14;

        [NativeTypeName("#define OS_TERMINALREMOTEADMIN 15")]
        public const int OS_TERMINALREMOTEADMIN = 15;

        [NativeTypeName("#define OS_WIN95_GOLD 16")]
        public const int OS_WIN95_GOLD = 16;

        [NativeTypeName("#define OS_MEORGREATER 17")]
        public const int OS_MEORGREATER = 17;

        [NativeTypeName("#define OS_XPORGREATER 18")]
        public const int OS_XPORGREATER = 18;

        [NativeTypeName("#define OS_HOME 19")]
        public const int OS_HOME = 19;

        [NativeTypeName("#define OS_PROFESSIONAL 20")]
        public const int OS_PROFESSIONAL = 20;

        [NativeTypeName("#define OS_DATACENTER 21")]
        public const int OS_DATACENTER = 21;

        [NativeTypeName("#define OS_ADVSERVER 22")]
        public const int OS_ADVSERVER = 22;

        [NativeTypeName("#define OS_SERVER 23")]
        public const int OS_SERVER = 23;

        [NativeTypeName("#define OS_TERMINALSERVER 24")]
        public const int OS_TERMINALSERVER = 24;

        [NativeTypeName("#define OS_PERSONALTERMINALSERVER 25")]
        public const int OS_PERSONALTERMINALSERVER = 25;

        [NativeTypeName("#define OS_FASTUSERSWITCHING 26")]
        public const int OS_FASTUSERSWITCHING = 26;

        [NativeTypeName("#define OS_WELCOMELOGONUI 27")]
        public const int OS_WELCOMELOGONUI = 27;

        [NativeTypeName("#define OS_DOMAINMEMBER 28")]
        public const int OS_DOMAINMEMBER = 28;

        [NativeTypeName("#define OS_ANYSERVER 29")]
        public const int OS_ANYSERVER = 29;

        [NativeTypeName("#define OS_WOW6432 30")]
        public const int OS_WOW6432 = 30;

        [NativeTypeName("#define OS_WEBSERVER 31")]
        public const int OS_WEBSERVER = 31;

        [NativeTypeName("#define OS_SMALLBUSINESSSERVER 32")]
        public const int OS_SMALLBUSINESSSERVER = 32;

        [NativeTypeName("#define OS_TABLETPC 33")]
        public const int OS_TABLETPC = 33;

        [NativeTypeName("#define OS_SERVERADMINUI 34")]
        public const int OS_SERVERADMINUI = 34;

        [NativeTypeName("#define OS_MEDIACENTER 35")]
        public const int OS_MEDIACENTER = 35;

        [NativeTypeName("#define OS_APPLIANCE 36")]
        public const int OS_APPLIANCE = 36;

        [NativeTypeName("#define PLATFORM_UNKNOWN 0")]
        public const int PLATFORM_UNKNOWN = 0;

        [NativeTypeName("#define PLATFORM_IE3 1")]
        public const int PLATFORM_IE3 = 1;

        [NativeTypeName("#define PLATFORM_BROWSERONLY 1")]
        public const int PLATFORM_BROWSERONLY = 1;

        [NativeTypeName("#define PLATFORM_INTEGRATED 2")]
        public const int PLATFORM_INTEGRATED = 2;

        [NativeTypeName("#define ILMM_IE4 0")]
        public const int ILMM_IE4 = 0;

        [NativeTypeName("#define SHACF_DEFAULT 0x00000000")]
        public const int SHACF_DEFAULT = 0x00000000;

        [NativeTypeName("#define SHACF_FILESYSTEM 0x00000001")]
        public const int SHACF_FILESYSTEM = 0x00000001;

        [NativeTypeName("#define SHACF_URLALL (SHACF_URLHISTORY | SHACF_URLMRU)")]
        public const int SHACF_URLALL = (0x00000002 | 0x00000004);

        [NativeTypeName("#define SHACF_URLHISTORY 0x00000002")]
        public const int SHACF_URLHISTORY = 0x00000002;

        [NativeTypeName("#define SHACF_URLMRU 0x00000004")]
        public const int SHACF_URLMRU = 0x00000004;

        [NativeTypeName("#define SHACF_USETAB 0x00000008")]
        public const int SHACF_USETAB = 0x00000008;

        [NativeTypeName("#define SHACF_FILESYS_ONLY 0x00000010")]
        public const int SHACF_FILESYS_ONLY = 0x00000010;

        [NativeTypeName("#define SHACF_FILESYS_DIRS 0x00000020")]
        public const int SHACF_FILESYS_DIRS = 0x00000020;

        [NativeTypeName("#define SHACF_VIRTUAL_NAMESPACE 0x00000040")]
        public const int SHACF_VIRTUAL_NAMESPACE = 0x00000040;

        [NativeTypeName("#define SHACF_AUTOSUGGEST_FORCE_ON 0x10000000")]
        public const int SHACF_AUTOSUGGEST_FORCE_ON = 0x10000000;

        [NativeTypeName("#define SHACF_AUTOSUGGEST_FORCE_OFF 0x20000000")]
        public const int SHACF_AUTOSUGGEST_FORCE_OFF = 0x20000000;

        [NativeTypeName("#define SHACF_AUTOAPPEND_FORCE_ON 0x40000000")]
        public const int SHACF_AUTOAPPEND_FORCE_ON = 0x40000000;

        [NativeTypeName("#define SHACF_AUTOAPPEND_FORCE_OFF 0x80000000")]
        public const uint SHACF_AUTOAPPEND_FORCE_OFF = 0x80000000;

        [NativeTypeName("#define DLLVER_PLATFORM_WINDOWS 0x00000001")]
        public const int DLLVER_PLATFORM_WINDOWS = 0x00000001;

        [NativeTypeName("#define DLLVER_PLATFORM_NT 0x00000002")]
        public const int DLLVER_PLATFORM_NT = 0x00000002;

        [NativeTypeName("#define DLLVER_MAJOR_MASK 0xFFFF000000000000")]
        public const ulong DLLVER_MAJOR_MASK = 0xFFFF000000000000;

        [NativeTypeName("#define DLLVER_MINOR_MASK 0x0000FFFF00000000")]
        public const long DLLVER_MINOR_MASK = 0x0000FFFF00000000;

        [NativeTypeName("#define DLLVER_BUILD_MASK 0x00000000FFFF0000")]
        public const uint DLLVER_BUILD_MASK = 0x00000000FFFF0000;

        [NativeTypeName("#define DLLVER_QFE_MASK 0x000000000000FFFF")]
        public const int DLLVER_QFE_MASK = 0x000000000000FFFF;

        public static ref readonly Guid IID_IQueryAssociations
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0xA5, 0x6C, 0xC4,
                    0x3F, 0x3C,
                    0xD2, 0x11,
                    0xBE,
                    0xE6,
                    0x00,
                    0x00,
                    0xF8,
                    0x05,
                    0xCA,
                    0x57
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
