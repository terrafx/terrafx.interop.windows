// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/strsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyA"]/*' />
    public static HRESULT StringCchCopyA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc)
    {
        HRESULT hr;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerA(pszDest, cchDest, null, pszSrc, (2147483647 - 1));
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyW"]/*' />
    public static HRESULT StringCchCopyW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc)
    {
        HRESULT hr;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerW(pszDest, cchDest, null, pszSrc, (2147483647 - 1));
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyA"]/*' />
    public static HRESULT StringCbCopyA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerA(pszDest, cchDest, null, pszSrc, (2147483647 - 1));
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyW"]/*' />
    public static HRESULT StringCbCopyW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerW(pszDest, cchDest, null, pszSrc, (2147483647 - 1));
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyExA"]/*' />
    public static HRESULT StringCchCopyExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestA(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcA(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                    if (cchDest != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (cchDest == 0)
                {
                    if (*pszSrc != (sbyte)('\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDest, cchDest, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDest + cchCopied;
                    cchRemaining = cchDest - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(sbyte));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (cchDest != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(sbyte));
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyExW"]/*' />
    public static HRESULT StringCchCopyExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestW(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcW(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                    if (cchDest != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (cchDest == 0)
                {
                    if (*pszSrc != '\0')
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDest, cchDest, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDest + cchCopied;
                    cchRemaining = cchDest - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(char));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (cchDest != 0)
                {
                    *pszDest = '\0';
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(char));
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyNA"]/*' />
    public static HRESULT StringCchCopyNA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy)
    {
        HRESULT hr;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            if (cchToCopy > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
                *pszDest = (sbyte)('\0');
            }
            else
            {
                hr = StringCopyWorkerA(pszDest, cchDest, null, pszSrc, cchToCopy);
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyNW"]/*' />
    public static HRESULT StringCchCopyNW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy)
    {
        HRESULT hr;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            if (cchToCopy > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
                *pszDest = '\0';
            }
            else
            {
                hr = StringCopyWorkerW(pszDest, cchDest, null, pszSrc, cchToCopy);
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyNA"]/*' />
    public static HRESULT StringCbCopyNA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cbToCopy)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            nuint cchToCopy = cbToCopy / 1;

            if (unchecked(cchToCopy) > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
                *pszDest = (sbyte)('\0');
            }
            else
            {
                hr = StringCopyWorkerA(pszDest, cchDest, null, pszSrc, cchToCopy);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyNW"]/*' />
    public static HRESULT StringCbCopyNW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cbToCopy)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            nuint cchToCopy = cbToCopy / 2;

            if (unchecked(cchToCopy) > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
                *pszDest = '\0';
            }
            else
            {
                hr = StringCopyWorkerW(pszDest, cchDest, null, pszSrc, cchToCopy);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyNExA"]/*' />
    public static HRESULT StringCchCopyNExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestA(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcA(&pszSrc, &cchToCopy, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                    if (cchDest != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (cchDest == 0)
                {
                    if ((cchToCopy != 0) && (*pszSrc != (sbyte)('\0')))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    cchRemaining = cchDest - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(sbyte));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (cchDest != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(sbyte));
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyNExW"]/*' />
    public static HRESULT StringCchCopyNExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestW(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcW(&pszSrc, &cchToCopy, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                    if (cchDest != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (cchDest == 0)
                {
                    if ((cchToCopy != 0) && (*pszSrc != '\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    cchRemaining = cchDest - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(char));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (cchDest != 0)
                {
                    *pszDest = '\0';
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(char));
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatA"]/*' />
    public static HRESULT StringCchCatA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerA(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, (2147483647 - 1));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatW"]/*' />
    public static HRESULT StringCchCatW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerW(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, (2147483647 - 1));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatA"]/*' />
    public static HRESULT StringCbCatA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc)
    {
        HRESULT hr;
        nuint cchDestLength;
        nuint cchDest = cbDest / 1;

        hr = StringValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerA(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, (2147483647 - 1));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatW"]/*' />
    public static HRESULT StringCbCatW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc)
    {
        HRESULT hr;
        nuint cchDestLength;
        nuint cchDest = cbDest / 2;

        hr = StringValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringCopyWorkerW(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, (2147483647 - 1));
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatExA"]/*' />
    public static HRESULT StringCchCatExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcA(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (cchRemaining <= 1)
                {
                    if (*pszSrc != (sbyte)('\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDestEnd, cchRemaining, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(sbyte));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(sbyte));
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatExW"]/*' />
    public static HRESULT StringCchCatExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcW(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (cchRemaining <= 1)
                {
                    if (*pszSrc != '\0')
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDestEnd, cchRemaining, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(char));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(char));
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatExA"]/*' />
    public static HRESULT StringCbCatExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcA(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (unchecked(cchRemaining) <= 1)
                {
                    if (*pszSrc != (sbyte)('\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDestEnd, cchRemaining, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && unchecked(cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatExW"]/*' />
    public static HRESULT StringCbCatExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcW(&pszSrc, null, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (unchecked(cchRemaining) <= 1)
                {
                    if (*pszSrc != '\0')
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDestEnd, cchRemaining, &cchCopied, pszSrc, (2147483647 - 1));
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0)
                    {
                        nuint cbRemaining;

                        cbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatNA"]/*' />
    public static HRESULT StringCchCatNA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cchToAppend)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            if (cchToAppend > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
            }
            else
            {
                hr = StringCopyWorkerA(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, cchToAppend);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatNW"]/*' />
    public static HRESULT StringCchCatNW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cchToAppend)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            if (cchToAppend > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
            }
            else
            {
                hr = StringCopyWorkerW(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, cchToAppend);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatNA"]/*' />
    public static HRESULT StringCbCatNA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cbToAppend)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            nuint cchToAppend = cbToAppend / 1;

            if (unchecked(cchToAppend) > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
            }
            else
            {
                hr = StringCopyWorkerA(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, cchToAppend);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatNW"]/*' />
    public static HRESULT StringCbCatNW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cbToAppend)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;
        nuint cchDestLength;

        hr = StringValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            nuint cchToAppend = cbToAppend / 2;

            if (unchecked(cchToAppend) > (2147483647 - 1))
            {
                hr = ((HRESULT)(0x80070057));
            }
            else
            {
                hr = StringCopyWorkerW(pszDest + cchDestLength, cchDest - cchDestLength, null, pszSrc, cchToAppend);
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatNExA"]/*' />
    public static HRESULT StringCchCatNExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cchToAppend, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcA(&pszSrc, &cchToAppend, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (cchRemaining <= 1)
                {
                    if ((cchToAppend != 0) && (*pszSrc != (sbyte)('\0')))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDestEnd, cchRemaining, &cchCopied, pszSrc, cchToAppend);
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(sbyte));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(sbyte));
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatNExW"]/*' />
    public static HRESULT StringCchCatNExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cchToAppend, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;

            hr = StringExValidateSrcW(&pszSrc, &cchToAppend, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (cchRemaining <= 1)
                {
                    if ((cchToAppend != 0) && (*pszSrc != '\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDestEnd, cchRemaining, &cchCopied, pszSrc, cchToAppend);
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = cchRemaining * (uint)(sizeof(char));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(char));
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatNExA"]/*' />
    public static HRESULT StringCbCatNExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cbToAppend, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthA(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;
            nuint cchToAppend = cbToAppend / 1;

            hr = StringExValidateSrcA(&pszSrc, &cchToAppend, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (unchecked(cchRemaining) <= 1)
                {
                    if (unchecked(cchToAppend != 0) && (*pszSrc != (sbyte)('\0')))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDestEnd, cchRemaining, &cchCopied, pszSrc, cchToAppend);
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && unchecked(cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatNExW"]/*' />
    public static HRESULT StringCbCatNExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cbToAppend, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;
        nuint cchDestLength;

        hr = StringExValidateDestAndLengthW(pszDest, cchDest, &cchDestLength, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest + cchDestLength;
            nuint cchRemaining = cchDest - cchDestLength;
            nuint cchToAppend = cbToAppend / 2;

            hr = StringExValidateSrcW(&pszSrc, &cchToAppend, 2147483647, dwFlags);
            if ((((HRESULT)(hr)) >= 0))
            {
                if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else if (unchecked(cchRemaining) <= 1)
                {
                    if (unchecked(cchToAppend != 0) && (*pszSrc != '\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = ((HRESULT)(0x80070057));
                        }
                        else
                        {
                            hr = ((HRESULT)(0x8007007A));
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDestEnd, cchRemaining, &cchCopied, pszSrc, cchToAppend);
                    pszDestEnd = pszDestEnd + cchCopied;
                    cchRemaining = cchRemaining - cchCopied;
                    if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0)
                    {
                        nuint cbRemaining;

                        cbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, cchDestLength, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                }
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGetsA"]/*' />
    public static HRESULT StringCchGetsA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest)
    {
        HRESULT hr;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringGetsWorkerA(pszDest, cchDest, null);
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGetsW"]/*' />
    public static HRESULT StringCchGetsW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest)
    {
        HRESULT hr;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringGetsWorkerW(pszDest, cchDest, null);
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGetsA"]/*' />
    public static HRESULT StringCbGetsA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringValidateDestA(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringGetsWorkerA(pszDest, cchDest, null);
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGetsW"]/*' />
    public static HRESULT StringCbGetsW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringValidateDestW(pszDest, cchDest, 2147483647);
        if ((((HRESULT)(hr)) >= 0))
        {
            hr = StringGetsWorkerW(pszDest, cchDest, null);
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGetsExA"]/*' />
    public static HRESULT StringCchGetsExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestA(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
            {
                hr = ((HRESULT)(0x80070057));
                if (cchDest != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }
            else if (cchDest == 0)
            {
                if (pszDest == null)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else
                {
                    hr = ((HRESULT)(0x8007007A));
                }
            }
            else
            {
                nuint cchNewDestLength = 0;

                hr = StringGetsWorkerA(pszDest, cchDest, &cchNewDestLength);
                pszDestEnd = pszDest + cchNewDestLength;
                cchRemaining = cchDest - cchNewDestLength;
                if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                {
                    nuint cbRemaining;

                    cbRemaining = cchRemaining * (uint)(sizeof(sbyte));
                    _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(sbyte));
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))) || (hr == ((HRESULT)(0x80070026))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGetsExW"]/*' />
    public static HRESULT StringCchGetsExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        hr = StringExValidateDestW(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
            {
                hr = ((HRESULT)(0x80070057));
                if (cchDest != 0)
                {
                    *pszDest = '\0';
                }
            }
            else if (cchDest == 0)
            {
                if (pszDest == null)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else
                {
                    hr = ((HRESULT)(0x8007007A));
                }
            }
            else
            {
                nuint cchNewDestLength = 0;

                hr = StringGetsWorkerW(pszDest, cchDest, &cchNewDestLength);
                pszDestEnd = pszDest + cchNewDestLength;
                cchRemaining = cchDest - cchNewDestLength;
                if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && (cchRemaining > 1))
                {
                    nuint cbRemaining;

                    cbRemaining = cchRemaining * (uint)(sizeof(char));
                    _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cchDest != 0))
            {
                nuint cbDest;

                cbDest = cchDest * (uint)(sizeof(char));
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))) || (hr == ((HRESULT)(0x80070026))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcchRemaining) != null)
                {
                    *pcchRemaining = cchRemaining;
                }
            }
        }
        else if (cchDest > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGetsExA"]/*' />
    public static HRESULT StringCbGetsExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringExValidateDestA(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
            {
                hr = ((HRESULT)(0x80070057));
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }
            else if (unchecked(cchDest) == 0)
            {
                if (pszDest == null)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else
                {
                    hr = ((HRESULT)(0x8007007A));
                }
            }
            else
            {
                nuint cchNewDestLength = 0;

                hr = StringGetsWorkerA(pszDest, cchDest, &cchNewDestLength);
                pszDestEnd = pszDest + cchNewDestLength;
                cchRemaining = cchDest - cchNewDestLength;
                if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0 && unchecked(cchRemaining > 1))
                {
                    nuint cbRemaining;

                    cbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                    _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))) || (hr == ((HRESULT)(0x80070026))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(sbyte))) + (cbDest % (uint)(sizeof(sbyte)));
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGetsExW"]/*' />
    public static HRESULT StringCbGetsExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringExValidateDestW(pszDest, cchDest, 2147483647, dwFlags);
        if ((((HRESULT)(hr)) >= 0))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            if ((dwFlags & unchecked(~(0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000))) != 0)
            {
                hr = ((HRESULT)(0x80070057));
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = '\0';
                }
            }
            else if (unchecked(cchDest) == 0)
            {
                if (pszDest == null)
                {
                    hr = ((HRESULT)(0x80070057));
                }
                else
                {
                    hr = ((HRESULT)(0x8007007A));
                }
            }
            else
            {
                nuint cchNewDestLength = 0;

                hr = StringGetsWorkerW(pszDest, cchDest, &cchNewDestLength);
                pszDestEnd = pszDest + cchNewDestLength;
                cchRemaining = cchDest - cchNewDestLength;
                if ((((HRESULT)(hr)) >= 0) && (dwFlags & 0x00000200) != 0)
                {
                    nuint cbRemaining;

                    cbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                    _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                }
            }

            if ((((HRESULT)(hr)) < 0) && (dwFlags & (0x00001000 | 0x00000400 | 0x00000800)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if ((((HRESULT)(hr)) >= 0) || (hr == ((HRESULT)(0x8007007A))) || (hr == ((HRESULT)(0x80070026))))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = (cchRemaining * (uint)(sizeof(char))) + (cbDest % (uint)(sizeof(char)));
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchLengthA"]/*' />
    public static HRESULT StringCchLengthA([NativeTypeName("STRSAFE_PCNZCH")] sbyte* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr;

        if ((psz == null) || (cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = StringLengthWorkerA(psz, cchMax, pcchLength);
        }

        if ((((HRESULT)(hr)) < 0) && (pcchLength) != null)
        {
            *pcchLength = 0;
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchLengthW"]/*' />
    public static HRESULT StringCchLengthW([NativeTypeName("STRSAFE_PCNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr;

        if ((psz == null) || (cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = StringLengthWorkerW(psz, cchMax, pcchLength);
        }

        if ((((HRESULT)(hr)) < 0) && (pcchLength) != null)
        {
            *pcchLength = 0;
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbLengthA"]/*' />
    public static HRESULT StringCbLengthA([NativeTypeName("STRSAFE_PCNZCH")] sbyte* psz, [NativeTypeName("size_t")] nuint cbMax, [NativeTypeName("size_t *")] nuint* pcbLength)
    {
        HRESULT hr;
        nuint cchMax = cbMax / 1;
        nuint cchLength = 0;

        if ((psz == null) || unchecked(cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = StringLengthWorkerA(psz, cchMax, &cchLength);
        }

        if ((pcbLength) != null)
        {
            if ((((HRESULT)(hr)) >= 0))
            {
                *pcbLength = cchLength * (uint)(sizeof(sbyte));
            }
            else
            {
                *pcbLength = 0;
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbLengthW"]/*' />
    public static HRESULT StringCbLengthW([NativeTypeName("STRSAFE_PCNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cbMax, [NativeTypeName("size_t *")] nuint* pcbLength)
    {
        HRESULT hr;
        nuint cchMax = cbMax / 2;
        nuint cchLength = 0;

        if ((psz == null) || unchecked(cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = StringLengthWorkerW(psz, cchMax, &cchLength);
        }

        if ((pcbLength) != null)
        {
            if ((((HRESULT)(hr)) >= 0))
            {
                *pcbLength = cchLength * (uint)(sizeof(char));
            }
            else
            {
                *pcbLength = 0;
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnalignedStringCchLengthW"]/*' />
    public static HRESULT UnalignedStringCchLengthW([NativeTypeName("STRSAFE_PCUNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr;

        if ((psz == null) || (cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = UnalignedStringLengthWorkerW(psz, cchMax, pcchLength);
        }

        if ((((HRESULT)(hr)) < 0) && (pcchLength) != null)
        {
            *pcchLength = 0;
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnalignedStringCbLengthW"]/*' />
    public static HRESULT UnalignedStringCbLengthW([NativeTypeName("STRSAFE_PCUNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cbMax, [NativeTypeName("size_t *")] nuint* pcbLength)
    {
        HRESULT hr;
        nuint cchMax = cbMax / 2;
        nuint cchLength = 0;

        if ((psz == null) || unchecked(cchMax > 2147483647))
        {
            hr = ((HRESULT)(0x80070057));
        }
        else
        {
            hr = UnalignedStringLengthWorkerW(psz, cchMax, &cchLength);
        }

        if ((pcbLength) != null)
        {
            if ((((HRESULT)(hr)) >= 0))
            {
                *pcbLength = cchLength * (uint)(sizeof(char));
            }
            else
            {
                *pcbLength = 0;
            }
        }

        return hr;
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_USE_SECURE_CRT"]/*' />
    [NativeTypeName("#define STRSAFE_USE_SECURE_CRT 0")]
    public const int STRSAFE_USE_SECURE_CRT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_MAX_CCH"]/*' />
    [NativeTypeName("#define STRSAFE_MAX_CCH 2147483647")]
    public const int STRSAFE_MAX_CCH = 2147483647;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_MAX_LENGTH"]/*' />
    [NativeTypeName("#define STRSAFE_MAX_LENGTH (STRSAFE_MAX_CCH - 1)")]
    public const int STRSAFE_MAX_LENGTH = (2147483647 - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_IGNORE_NULLS"]/*' />
    [NativeTypeName("#define STRSAFE_IGNORE_NULLS 0x00000100")]
    public const int STRSAFE_IGNORE_NULLS = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_FILL_BEHIND_NULL"]/*' />
    [NativeTypeName("#define STRSAFE_FILL_BEHIND_NULL 0x00000200")]
    public const int STRSAFE_FILL_BEHIND_NULL = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_FILL_ON_FAILURE"]/*' />
    [NativeTypeName("#define STRSAFE_FILL_ON_FAILURE 0x00000400")]
    public const int STRSAFE_FILL_ON_FAILURE = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_NULL_ON_FAILURE"]/*' />
    [NativeTypeName("#define STRSAFE_NULL_ON_FAILURE 0x00000800")]
    public const int STRSAFE_NULL_ON_FAILURE = 0x00000800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_NO_TRUNCATION"]/*' />
    [NativeTypeName("#define STRSAFE_NO_TRUNCATION 0x00001000")]
    public const int STRSAFE_NO_TRUNCATION = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_VALID_FLAGS"]/*' />
    [NativeTypeName("#define STRSAFE_VALID_FLAGS (0x000000FF | STRSAFE_IGNORE_NULLS | STRSAFE_FILL_BEHIND_NULL | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE | STRSAFE_NO_TRUNCATION)")]
    public const int STRSAFE_VALID_FLAGS = (0x000000FF | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800 | 0x00001000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_E_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define STRSAFE_E_INSUFFICIENT_BUFFER ((HRESULT)0x8007007AL)")]
    public const int STRSAFE_E_INSUFFICIENT_BUFFER = unchecked((int)(0x8007007A));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_E_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STRSAFE_E_INVALID_PARAMETER ((HRESULT)0x80070057L)")]
    public const int STRSAFE_E_INVALID_PARAMETER = unchecked((int)(0x80070057));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STRSAFE_E_END_OF_FILE"]/*' />
    [NativeTypeName("#define STRSAFE_E_END_OF_FILE ((HRESULT)0x80070026L)")]
    public const int STRSAFE_E_END_OF_FILE = unchecked((int)(0x80070026));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_CYCLOMATIC_COMPLEXITY"]/*' />
    [NativeTypeName("#define __WARNING_CYCLOMATIC_COMPLEXITY 28734")]
    public const int __WARNING_CYCLOMATIC_COMPLEXITY = 28734;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_USING_UNINIT_VAR"]/*' />
    [NativeTypeName("#define __WARNING_USING_UNINIT_VAR 6001")]
    public const int __WARNING_USING_UNINIT_VAR = 6001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_RETURN_UNINIT_VAR"]/*' />
    [NativeTypeName("#define __WARNING_RETURN_UNINIT_VAR 6101")]
    public const int __WARNING_RETURN_UNINIT_VAR = 6101;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_DEREF_NULL_PTR"]/*' />
    [NativeTypeName("#define __WARNING_DEREF_NULL_PTR 6011")]
    public const int __WARNING_DEREF_NULL_PTR = 6011;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_MISSING_ZERO_TERMINATION2"]/*' />
    [NativeTypeName("#define __WARNING_MISSING_ZERO_TERMINATION2 6054")]
    public const int __WARNING_MISSING_ZERO_TERMINATION2 = 6054;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_WRITE_OVERRUN"]/*' />
    [NativeTypeName("#define __WARNING_WRITE_OVERRUN 6386")]
    public const int __WARNING_WRITE_OVERRUN = 6386;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_INVALID_PARAM_VALUE_1"]/*' />
    [NativeTypeName("#define __WARNING_INVALID_PARAM_VALUE_1 6387")]
    public const int __WARNING_INVALID_PARAM_VALUE_1 = 6387;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_UNSAFE_STRING_FUNCTION"]/*' />
    [NativeTypeName("#define __WARNING_UNSAFE_STRING_FUNCTION 25025")]
    public const int __WARNING_UNSAFE_STRING_FUNCTION = 25025;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_INCORRECT_ANNOTATION"]/*' />
    [NativeTypeName("#define __WARNING_INCORRECT_ANNOTATION 26007")]
    public const int __WARNING_INCORRECT_ANNOTATION = 26007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_POTENTIAL_BUFFER_OVERFLOW_HIGH_PRIORITY"]/*' />
    [NativeTypeName("#define __WARNING_POTENTIAL_BUFFER_OVERFLOW_HIGH_PRIORITY 26015")]
    public const int __WARNING_POTENTIAL_BUFFER_OVERFLOW_HIGH_PRIORITY = 26015;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_PRECONDITION_NULLTERMINATION_VIOLATION"]/*' />
    [NativeTypeName("#define __WARNING_PRECONDITION_NULLTERMINATION_VIOLATION 26035")]
    public const int __WARNING_PRECONDITION_NULLTERMINATION_VIOLATION = 26035;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_POSTCONDITION_NULLTERMINATION_VIOLATION"]/*' />
    [NativeTypeName("#define __WARNING_POSTCONDITION_NULLTERMINATION_VIOLATION 26036")]
    public const int __WARNING_POSTCONDITION_NULLTERMINATION_VIOLATION = 26036;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_HIGH_PRIORITY_OVERFLOW_POSTCONDITION"]/*' />
    [NativeTypeName("#define __WARNING_HIGH_PRIORITY_OVERFLOW_POSTCONDITION 26045")]
    public const int __WARNING_HIGH_PRIORITY_OVERFLOW_POSTCONDITION = 26045;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_RANGE_POSTCONDITION_VIOLATION"]/*' />
    [NativeTypeName("#define __WARNING_RANGE_POSTCONDITION_VIOLATION 26061")]
    public const int __WARNING_RANGE_POSTCONDITION_VIOLATION = 26061;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_POTENTIAL_RANGE_POSTCONDITION_VIOLATION"]/*' />
    [NativeTypeName("#define __WARNING_POTENTIAL_RANGE_POSTCONDITION_VIOLATION 26071")]
    public const int __WARNING_POTENTIAL_RANGE_POSTCONDITION_VIOLATION = 26071;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_INVALID_PARAM_VALUE_3"]/*' />
    [NativeTypeName("#define __WARNING_INVALID_PARAM_VALUE_3 28183")]
    public const int __WARNING_INVALID_PARAM_VALUE_3 = 28183;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_RETURNING_BAD_RESULT"]/*' />
    [NativeTypeName("#define __WARNING_RETURNING_BAD_RESULT 28196")]
    public const int __WARNING_RETURNING_BAD_RESULT = 28196;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_BANNED_API_USAGE"]/*' />
    [NativeTypeName("#define __WARNING_BANNED_API_USAGE 28719")]
    public const int __WARNING_BANNED_API_USAGE = 28719;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.__WARNING_POST_EXPECTED"]/*' />
    [NativeTypeName("#define __WARNING_POST_EXPECTED 28210")]
    public const int __WARNING_POST_EXPECTED = 28210;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopy"]/*' />
    [NativeTypeName("#define StringCchCopy StringCchCopyW")]
    public static delegate*<char*, nuint, char*, HRESULT> StringCchCopy => &StringCchCopyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopy"]/*' />
    [NativeTypeName("#define StringCbCopy StringCbCopyW")]
    public static delegate*<char*, nuint, char*, HRESULT> StringCbCopy => &StringCbCopyW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyEx"]/*' />
    [NativeTypeName("#define StringCchCopyEx StringCchCopyExW")]
    public static delegate*<char*, nuint, char*, char**, nuint*, uint, HRESULT> StringCchCopyEx => &StringCchCopyExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyEx"]/*' />
    [NativeTypeName("#define StringCbCopyEx StringCbCopyExW")]
    public static delegate*<char*, nuint, char*, char**, nuint*, uint, HRESULT> StringCbCopyEx => &StringCbCopyExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyN"]/*' />
    [NativeTypeName("#define StringCchCopyN StringCchCopyNW")]
    public static delegate*<char*, nuint, char*, nuint, HRESULT> StringCchCopyN => &StringCchCopyNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyN"]/*' />
    [NativeTypeName("#define StringCbCopyN StringCbCopyNW")]
    public static delegate*<char*, nuint, char*, nuint, HRESULT> StringCbCopyN => &StringCbCopyNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCopyNEx"]/*' />
    [NativeTypeName("#define StringCchCopyNEx StringCchCopyNExW")]
    public static delegate*<char*, nuint, char*, nuint, char**, nuint*, uint, HRESULT> StringCchCopyNEx => &StringCchCopyNExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCopyNEx"]/*' />
    [NativeTypeName("#define StringCbCopyNEx StringCbCopyNExW")]
    public static delegate*<char*, nuint, char*, nuint, char**, nuint*, uint, HRESULT> StringCbCopyNEx => &StringCbCopyNExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCat"]/*' />
    [NativeTypeName("#define StringCchCat StringCchCatW")]
    public static delegate*<char*, nuint, char*, HRESULT> StringCchCat => &StringCchCatW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCat"]/*' />
    [NativeTypeName("#define StringCbCat StringCbCatW")]
    public static delegate*<char*, nuint, char*, HRESULT> StringCbCat => &StringCbCatW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatEx"]/*' />
    [NativeTypeName("#define StringCchCatEx StringCchCatExW")]
    public static delegate*<char*, nuint, char*, char**, nuint*, uint, HRESULT> StringCchCatEx => &StringCchCatExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatEx"]/*' />
    [NativeTypeName("#define StringCbCatEx StringCbCatExW")]
    public static delegate*<char*, nuint, char*, char**, nuint*, uint, HRESULT> StringCbCatEx => &StringCbCatExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatN"]/*' />
    [NativeTypeName("#define StringCchCatN StringCchCatNW")]
    public static delegate*<char*, nuint, char*, nuint, HRESULT> StringCchCatN => &StringCchCatNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatN"]/*' />
    [NativeTypeName("#define StringCbCatN StringCbCatNW")]
    public static delegate*<char*, nuint, char*, nuint, HRESULT> StringCbCatN => &StringCbCatNW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchCatNEx"]/*' />
    [NativeTypeName("#define StringCchCatNEx StringCchCatNExW")]
    public static delegate*<char*, nuint, char*, nuint, char**, nuint*, uint, HRESULT> StringCchCatNEx => &StringCchCatNExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbCatNEx"]/*' />
    [NativeTypeName("#define StringCbCatNEx StringCbCatNExW")]
    public static delegate*<char*, nuint, char*, nuint, char**, nuint*, uint, HRESULT> StringCbCatNEx => &StringCbCatNExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGets"]/*' />
    [NativeTypeName("#define StringCchGets StringCchGetsW")]
    public static delegate*<char*, nuint, HRESULT> StringCchGets => &StringCchGetsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGets"]/*' />
    [NativeTypeName("#define StringCbGets StringCbGetsW")]
    public static delegate*<char*, nuint, HRESULT> StringCbGets => &StringCbGetsW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchGetsEx"]/*' />
    [NativeTypeName("#define StringCchGetsEx StringCchGetsExW")]
    public static delegate*<char*, nuint, char**, nuint*, uint, HRESULT> StringCchGetsEx => &StringCchGetsExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbGetsEx"]/*' />
    [NativeTypeName("#define StringCbGetsEx StringCbGetsExW")]
    public static delegate*<char*, nuint, char**, nuint*, uint, HRESULT> StringCbGetsEx => &StringCbGetsExW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCchLength"]/*' />
    [NativeTypeName("#define StringCchLength StringCchLengthW")]
    public static delegate*<char*, nuint, nuint*, HRESULT> StringCchLength => &StringCchLengthW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.StringCbLength"]/*' />
    [NativeTypeName("#define StringCbLength StringCbLengthW")]
    public static delegate*<char*, nuint, nuint*, HRESULT> StringCbLength => &StringCbLengthW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnalignedStringCchLength"]/*' />
    [NativeTypeName("#define UnalignedStringCchLength UnalignedStringCchLengthW")]
    public static delegate*<char*, nuint, nuint*, HRESULT> UnalignedStringCchLength => &UnalignedStringCchLengthW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnalignedStringCbLength"]/*' />
    [NativeTypeName("#define UnalignedStringCbLength UnalignedStringCbLengthW")]
    public static delegate*<char*, nuint, nuint*, HRESULT> UnalignedStringCbLength => &UnalignedStringCbLengthW;
}
