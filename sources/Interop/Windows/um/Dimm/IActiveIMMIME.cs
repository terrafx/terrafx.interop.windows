// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08C03411-F96B-11D0-A475-00AA006BCC59")]
    [NativeTypeName("struct IActiveIMMIME : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IActiveIMMIME
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint>)(lpVtbl[1]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint>)(lpVtbl[2]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AssociateContext(HWND hWnd, HIMC hIME, HIMC* phPrev)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, HIMC, HIMC*, int>)(lpVtbl[3]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIME, phPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT ConfigureIMEA(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDA* pData)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HWND, uint, REGISTERWORDA*, int>)(lpVtbl[4]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ConfigureIMEW(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pData)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HWND, uint, REGISTERWORDW*, int>)(lpVtbl[5]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateContext(HIMC* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC*, int>)(lpVtbl[6]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT DestroyContext(HIMC hIME)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, int>)(lpVtbl[7]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIME);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT EnumRegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordA** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, sbyte*, uint, sbyte*, void*, IEnumRegisterWordA**, int>)(lpVtbl[8]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EnumRegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int>)(lpVtbl[9]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT EscapeA(HKL hKL, HIMC hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HIMC, uint, void*, nint*, int>)(lpVtbl[10]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EscapeW(HKL hKL, HIMC hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HIMC, uint, void*, nint*, int>)(lpVtbl[11]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetCandidateListA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[12]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetCandidateListW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[13]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCandidateListCountA(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint*, uint*, int>)(lpVtbl[14]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetCandidateListCountW(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint*, uint*, int>)(lpVtbl[15]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetCandidateWindow(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, CANDIDATEFORM*, int>)(lpVtbl[16]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetCompositionFontA(HIMC hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, LOGFONTA*, int>)(lpVtbl[17]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetCompositionFontW(HIMC hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, LOGFONTW*, int>)(lpVtbl[18]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, int*, void*, int>)(lpVtbl[19]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, int*, void*, int>)(lpVtbl[20]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, COMPOSITIONFORM*, int>)(lpVtbl[21]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetContext(HWND hWnd, HIMC* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, HIMC*, int>)(lpVtbl[22]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT GetConversionListA(HKL hKL, HIMC hIMC, [NativeTypeName("LPSTR")] sbyte* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HIMC, sbyte*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[23]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetConversionListW(HKL hKL, HIMC hIMC, [NativeTypeName("LPWSTR")] ushort* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, HIMC, ushort*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[24]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT GetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pfdwConversion, [NativeTypeName("DWORD *")] uint* pfdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint*, uint*, int>)(lpVtbl[25]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pfdwConversion, pfdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetDefaultIMEWnd(HWND hWnd, HWND* phDefWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, HWND*, int>)(lpVtbl[26]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, phDefWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetDescriptionA(HKL hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, sbyte*, uint*, int>)(lpVtbl[27]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetDescriptionW(HKL hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, ushort*, uint*, int>)(lpVtbl[28]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT GetGuideLineA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPSTR")] sbyte* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, sbyte*, uint*, int>)(lpVtbl[29]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetGuideLineW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPWSTR")] ushort* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, ushort*, uint*, int>)(lpVtbl[30]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetIMEFileNameA(HKL hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, sbyte*, uint*, int>)(lpVtbl[31]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetIMEFileNameW(HKL hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, ushort*, uint*, int>)(lpVtbl[32]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetOpenStatus(HIMC hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, int>)(lpVtbl[33]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT GetProperty(HKL hKL, [NativeTypeName("DWORD")] uint fdwIndex, [NativeTypeName("DWORD *")] uint* pdwProperty)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, uint*, int>)(lpVtbl[34]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, fdwIndex, pdwProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetRegisterWordStyleA(HKL hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFA* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, STYLEBUFA*, uint*, int>)(lpVtbl[35]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetRegisterWordStyleW(HKL hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFW* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint, STYLEBUFW*, uint*, int>)(lpVtbl[36]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetStatusWindowPos(HIMC hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, POINT*, int>)(lpVtbl[37]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT GetVirtualKey(HWND hWnd, [NativeTypeName("UINT *")] uint* puVirtualKey)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint*, int>)(lpVtbl[38]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, puVirtualKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT InstallIMEA([NativeTypeName("LPSTR")] sbyte* szIMEFileName, [NativeTypeName("LPSTR")] sbyte* szLayoutText, HKL* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, sbyte*, sbyte*, HKL*, int>)(lpVtbl[39]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT InstallIMEW([NativeTypeName("LPWSTR")] ushort* szIMEFileName, [NativeTypeName("LPWSTR")] ushort* szLayoutText, HKL* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, ushort*, ushort*, HKL*, int>)(lpVtbl[40]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT IsIME(HKL hKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, int>)(lpVtbl[41]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT IsUIMessageA(HWND hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint, nuint, nint, int>)(lpVtbl[42]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT IsUIMessageW(HWND hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint, nuint, nint, int>)(lpVtbl[43]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT NotifyIME(HIMC hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, uint, int>)(lpVtbl[44]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT RegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, sbyte*, uint, sbyte*, int>)(lpVtbl[45]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT RegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, ushort*, uint, ushort*, int>)(lpVtbl[46]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT ReleaseContext(HWND hWnd, HIMC hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, HIMC, int>)(lpVtbl[47]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT SetCandidateWindow(HIMC hIMC, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, CANDIDATEFORM*, int>)(lpVtbl[48]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT SetCompositionFontA(HIMC hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, LOGFONTA*, int>)(lpVtbl[49]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT SetCompositionFontW(HIMC hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, LOGFONTW*, int>)(lpVtbl[50]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT SetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, void*, uint, void*, uint, int>)(lpVtbl[51]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT SetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, void*, uint, void*, uint, int>)(lpVtbl[52]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT SetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, COMPOSITIONFORM*, int>)(lpVtbl[53]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT SetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD")] uint fdwConversion, [NativeTypeName("DWORD")] uint fdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, int>)(lpVtbl[54]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, fdwConversion, fdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT SetOpenStatus(HIMC hIMC, BOOL fOpen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, BOOL, int>)(lpVtbl[55]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, fOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT SetStatusWindowPos(HIMC hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, POINT*, int>)(lpVtbl[56]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT SimulateHotKey(HWND hWnd, [NativeTypeName("DWORD")] uint dwHotKeyID)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint, int>)(lpVtbl[57]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, dwHotKeyID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT UnregisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, sbyte*, uint, sbyte*, int>)(lpVtbl[58]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT UnregisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, ushort*, uint, ushort*, int>)(lpVtbl[59]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT GenerateMessage(HIMC hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, int>)(lpVtbl[60]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT LockIMC(HIMC hIMC, INPUTCONTEXT** ppIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, INPUTCONTEXT**, int>)(lpVtbl[61]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, ppIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT UnlockIMC(HIMC hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, int>)(lpVtbl[62]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT GetIMCLockCount(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwLockCount)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint*, int>)(lpVtbl[63]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwLockCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT CreateIMCC([NativeTypeName("DWORD")] uint dwSize, HIMCC* phIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, HIMCC*, int>)(lpVtbl[64]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwSize, phIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT DestroyIMCC(HIMCC hIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, int>)(lpVtbl[65]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT LockIMCC(HIMCC hIMCC, void** ppv)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, void**, int>)(lpVtbl[66]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT UnlockIMCC(HIMCC hIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, int>)(lpVtbl[67]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public HRESULT ReSizeIMCC(HIMCC hIMCC, [NativeTypeName("DWORD")] uint dwSize, HIMCC* phIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, uint, HIMCC*, int>)(lpVtbl[68]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, dwSize, phIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public HRESULT GetIMCCSize(HIMCC hIMCC, [NativeTypeName("DWORD *")] uint* pdwSize)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, uint*, int>)(lpVtbl[69]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, pdwSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT GetIMCCLockCount(HIMCC hIMCC, [NativeTypeName("DWORD *")] uint* pdwLockCount)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMCC, uint*, int>)(lpVtbl[70]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, pdwLockCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT GetHotKey([NativeTypeName("DWORD")] uint dwHotKeyID, [NativeTypeName("UINT *")] uint* puModifiers, [NativeTypeName("UINT *")] uint* puVKey, HKL* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, uint*, uint*, HKL*, int>)(lpVtbl[71]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwHotKeyID, puModifiers, puVKey, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT SetHotKey([NativeTypeName("DWORD")] uint dwHotKeyID, [NativeTypeName("UINT")] uint uModifiers, [NativeTypeName("UINT")] uint uVKey, HKL hKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, uint, uint, HKL, int>)(lpVtbl[72]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwHotKeyID, uModifiers, uVKey, hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public HRESULT CreateSoftKeyboard([NativeTypeName("UINT")] uint uType, HWND hOwner, int x, int y, HWND* phSoftKbdWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, HWND, int, int, HWND*, int>)(lpVtbl[73]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), uType, hOwner, x, y, phSoftKbdWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public HRESULT DestroySoftKeyboard(HWND hSoftKbdWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, int>)(lpVtbl[74]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hSoftKbdWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public HRESULT ShowSoftKeyboard(HWND hSoftKbdWnd, int nCmdShow)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, int, int>)(lpVtbl[75]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hSoftKbdWnd, nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public HRESULT GetCodePageA(HKL hKL, [NativeTypeName("UINT *")] uint* uCodePage)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, uint*, int>)(lpVtbl[76]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public HRESULT GetLangId(HKL hKL, [NativeTypeName("LANGID *")] ushort* plid)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HKL, ushort*, int>)(lpVtbl[77]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, plid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public HRESULT KeybdEvent([NativeTypeName("LANGID")] ushort lgidIME, [NativeTypeName("BYTE")] byte bVk, [NativeTypeName("BYTE")] byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwExtraInfo)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, ushort, byte, byte, uint, uint, int>)(lpVtbl[78]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), lgidIME, bVk, bScan, dwFlags, dwExtraInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public HRESULT LockModal()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[79]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public HRESULT UnlockModal()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[80]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public HRESULT AssociateContextEx(HWND hWnd, HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, HIMC, uint, int>)(lpVtbl[81]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIMC, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public HRESULT DisableIME([NativeTypeName("DWORD")] uint idThread)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, int>)(lpVtbl[82]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), idThread);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public HRESULT GetImeMenuItemsA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOA* pImeParentMenu, IMEMENUITEMINFOA* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, IMEMENUITEMINFOA*, IMEMENUITEMINFOA*, uint, uint*, int>)(lpVtbl[83]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public HRESULT GetImeMenuItemsW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOW* pImeParentMenu, IMEMENUITEMINFOW* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint*, int>)(lpVtbl[84]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public HRESULT EnumInputContext([NativeTypeName("DWORD")] uint idThread, IEnumInputContext** ppEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, IEnumInputContext**, int>)(lpVtbl[85]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), idThread, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public HRESULT RequestMessageA(HIMC hIMC, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, nuint, nint, nint*, int>)(lpVtbl[86]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT RequestMessageW(HIMC hIMC, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HIMC, nuint, nint, nint*, int>)(lpVtbl[87]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT SendIMCA(HWND hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint, nuint, nint, nint*, int>)(lpVtbl[88]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, uMsg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT SendIMCW(HWND hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, HWND, uint, nuint, nint, nint*, int>)(lpVtbl[89]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, uMsg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT IsSleeping()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[90]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }
    }
}
