// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08C0E040-62D1-11D1-9326-0060B067B86E")]
    [NativeTypeName("struct IActiveIMMApp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActiveIMMApp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveIMMApp*, uint>)(lpVtbl[1]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveIMMApp*, uint>)(lpVtbl[2]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AssociateContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIME, [NativeTypeName("HIMC *")] IntPtr* phPrev)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, IntPtr*, int>)(lpVtbl[3]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIME, phPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ConfigureIMEA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDA* pData)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, uint, REGISTERWORDA*, int>)(lpVtbl[4]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ConfigureIMEW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pData)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, uint, REGISTERWORDW*, int>)(lpVtbl[5]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateContext([NativeTypeName("HIMC *")] IntPtr* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr*, int>)(lpVtbl[6]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DestroyContext([NativeTypeName("HIMC")] IntPtr hIME)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, int>)(lpVtbl[7]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIME);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT EnumRegisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordA** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, sbyte*, uint, sbyte*, void*, IEnumRegisterWordA**, int>)(lpVtbl[8]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumRegisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int>)(lpVtbl[9]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EscapeA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, uint, void*, nint*, int>)(lpVtbl[10]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EscapeW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, uint, void*, nint*, int>)(lpVtbl[11]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetCandidateListA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[12]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetCandidateListW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[13]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCandidateListCountA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint*, uint*, int>)(lpVtbl[14]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetCandidateListCountW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint*, uint*, int>)(lpVtbl[15]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetCandidateWindow([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, CANDIDATEFORM*, int>)(lpVtbl[16]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCompositionFontA([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, LOGFONTA*, int>)(lpVtbl[17]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCompositionFontW([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, LOGFONTW*, int>)(lpVtbl[18]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetCompositionStringA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, int*, void*, int>)(lpVtbl[19]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetCompositionStringW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, int*, void*, int>)(lpVtbl[20]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetCompositionWindow([NativeTypeName("HIMC")] IntPtr hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, COMPOSITIONFORM*, int>)(lpVtbl[21]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC *")] IntPtr* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr*, int>)(lpVtbl[22]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetConversionListA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("LPSTR")] sbyte* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, sbyte*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[23]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetConversionListW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("LPWSTR")] ushort* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, ushort*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[24]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetConversionStatus([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pfdwConversion, [NativeTypeName("DWORD *")] uint* pfdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint*, uint*, int>)(lpVtbl[25]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pfdwConversion, pfdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetDefaultIMEWnd([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND *")] IntPtr* phDefWnd)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr*, int>)(lpVtbl[26]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, phDefWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetDescriptionA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, sbyte*, uint*, int>)(lpVtbl[27]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetDescriptionW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, ushort*, uint*, int>)(lpVtbl[28]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetGuideLineA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPSTR")] sbyte* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, sbyte*, uint*, int>)(lpVtbl[29]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetGuideLineW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPWSTR")] ushort* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, ushort*, uint*, int>)(lpVtbl[30]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetIMEFileNameA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, sbyte*, uint*, int>)(lpVtbl[31]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetIMEFileNameW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, ushort*, uint*, int>)(lpVtbl[32]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetOpenStatus([NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, int>)(lpVtbl[33]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetProperty([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("DWORD")] uint fdwIndex, [NativeTypeName("DWORD *")] uint* pdwProperty)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint*, int>)(lpVtbl[34]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, fdwIndex, pdwProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetRegisterWordStyleA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFA* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, STYLEBUFA*, uint*, int>)(lpVtbl[35]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetRegisterWordStyleW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFW* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, STYLEBUFW*, uint*, int>)(lpVtbl[36]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetStatusWindowPos([NativeTypeName("HIMC")] IntPtr hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, POINT*, int>)(lpVtbl[37]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT GetVirtualKey([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT *")] uint* puVirtualKey)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint*, int>)(lpVtbl[38]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, puVirtualKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT InstallIMEA([NativeTypeName("LPSTR")] sbyte* szIMEFileName, [NativeTypeName("LPSTR")] sbyte* szLayoutText, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, sbyte*, sbyte*, IntPtr*, int>)(lpVtbl[39]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT InstallIMEW([NativeTypeName("LPWSTR")] ushort* szIMEFileName, [NativeTypeName("LPWSTR")] ushort* szLayoutText, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, ushort*, ushort*, IntPtr*, int>)(lpVtbl[40]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT IsIME([NativeTypeName("HKL")] IntPtr hKL)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, int>)(lpVtbl[41]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT IsUIMessageA([NativeTypeName("HWND")] IntPtr hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, nuint, nint, int>)(lpVtbl[42]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT IsUIMessageW([NativeTypeName("HWND")] IntPtr hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, nuint, nint, int>)(lpVtbl[43]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT NotifyIME([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, uint, int>)(lpVtbl[44]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT RegisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, sbyte*, uint, sbyte*, int>)(lpVtbl[45]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT RegisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, ushort*, uint, ushort*, int>)(lpVtbl[46]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT ReleaseContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, int>)(lpVtbl[47]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT SetCandidateWindow([NativeTypeName("HIMC")] IntPtr hIMC, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, CANDIDATEFORM*, int>)(lpVtbl[48]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT SetCompositionFontA([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, LOGFONTA*, int>)(lpVtbl[49]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT SetCompositionFontW([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, LOGFONTW*, int>)(lpVtbl[50]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT SetCompositionStringA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, void*, uint, void*, uint, int>)(lpVtbl[51]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT SetCompositionStringW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, void*, uint, void*, uint, int>)(lpVtbl[52]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT SetCompositionWindow([NativeTypeName("HIMC")] IntPtr hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, COMPOSITIONFORM*, int>)(lpVtbl[53]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT SetConversionStatus([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint fdwConversion, [NativeTypeName("DWORD")] uint fdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, int>)(lpVtbl[54]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, fdwConversion, fdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT SetOpenStatus([NativeTypeName("HIMC")] IntPtr hIMC, BOOL fOpen)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, BOOL, int>)(lpVtbl[55]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, fOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT SetStatusWindowPos([NativeTypeName("HIMC")] IntPtr hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, POINT*, int>)(lpVtbl[56]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT SimulateHotKey([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwHotKeyID)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, int>)(lpVtbl[57]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, dwHotKeyID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT UnregisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, sbyte*, uint, sbyte*, int>)(lpVtbl[58]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT UnregisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, ushort*, uint, ushort*, int>)(lpVtbl[59]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT Activate(BOOL fRestoreLayout)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, BOOL, int>)(lpVtbl[60]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), fRestoreLayout);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<IActiveIMMApp*, int>)(lpVtbl[61]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT OnDefWindowProc([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint Msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, nuint, nint, nint*, int>)(lpVtbl[62]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT FilterClientWindows([NativeTypeName("ATOM *")] ushort* aaClassList, [NativeTypeName("UINT")] uint uSize)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, ushort*, uint, int>)(lpVtbl[63]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), aaClassList, uSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT GetCodePageA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT *")] uint* uCodePage)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint*, int>)(lpVtbl[64]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT GetLangId([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LANGID *")] ushort* plid)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, ushort*, int>)(lpVtbl[65]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, plid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT AssociateContextEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, IntPtr, uint, int>)(lpVtbl[66]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIMC, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT DisableIME([NativeTypeName("DWORD")] uint idThread)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, uint, int>)(lpVtbl[67]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), idThread);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT GetImeMenuItemsA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOA* pImeParentMenu, IMEMENUITEMINFOA* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, IMEMENUITEMINFOA*, IMEMENUITEMINFOA*, uint, uint*, int>)(lpVtbl[68]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT GetImeMenuItemsW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOW* pImeParentMenu, IMEMENUITEMINFOW* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, IntPtr, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint*, int>)(lpVtbl[69]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT EnumInputContext([NativeTypeName("DWORD")] uint idThread, IEnumInputContext** ppEnum)
        {
            return ((delegate* unmanaged<IActiveIMMApp*, uint, IEnumInputContext**, int>)(lpVtbl[70]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), idThread, ppEnum);
        }
    }
}
