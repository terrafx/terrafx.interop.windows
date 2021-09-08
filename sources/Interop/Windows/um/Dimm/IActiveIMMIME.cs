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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int AssociateContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIME, [NativeTypeName("HIMC *")] IntPtr* phPrev)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, IntPtr*, int>)(lpVtbl[3]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIME, phPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ConfigureIMEA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDA* pData)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, uint, REGISTERWORDA*, int>)(lpVtbl[4]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ConfigureIMEW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pData)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, uint, REGISTERWORDW*, int>)(lpVtbl[5]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContext([NativeTypeName("HIMC *")] IntPtr* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr*, int>)(lpVtbl[6]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyContext([NativeTypeName("HIMC")] IntPtr hIME)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[7]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIME);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRegisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordA** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, sbyte*, uint, sbyte*, void*, IEnumRegisterWordA**, int>)(lpVtbl[8]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRegisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** pEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int>)(lpVtbl[9]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int EscapeA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, uint, void*, nint*, int>)(lpVtbl[10]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int EscapeW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uEscape, [NativeTypeName("LPVOID")] void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, uint, void*, nint*, int>)(lpVtbl[11]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateListA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[12]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateListW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pCandList, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[13]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateListCountA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, uint*, int>)(lpVtbl[14]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateListCountW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, uint*, int>)(lpVtbl[15]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetCandidateWindow([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, CANDIDATEFORM*, int>)(lpVtbl[16]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompositionFontA([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, LOGFONTA*, int>)(lpVtbl[17]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompositionFontW([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, LOGFONTW*, int>)(lpVtbl[18]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompositionStringA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, int*, void*, int>)(lpVtbl[19]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompositionStringW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, int*, void*, int>)(lpVtbl[20]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetCompositionWindow([NativeTypeName("HIMC")] IntPtr hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, COMPOSITIONFORM*, int>)(lpVtbl[21]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC *")] IntPtr* phIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr*, int>)(lpVtbl[22]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, phIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int GetConversionListA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("LPSTR")] sbyte* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, sbyte*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[23]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int GetConversionListW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("LPWSTR")] ushort* pSrc, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("UINT")] uint uFlag, CANDIDATELIST* pDst, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, ushort*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[24]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetConversionStatus([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pfdwConversion, [NativeTypeName("DWORD *")] uint* pfdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, uint*, int>)(lpVtbl[25]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pfdwConversion, pfdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultIMEWnd([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HWND *")] IntPtr* phDefWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr*, int>)(lpVtbl[26]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, phDefWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescriptionA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, sbyte*, uint*, int>)(lpVtbl[27]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescriptionW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szDescription, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, ushort*, uint*, int>)(lpVtbl[28]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuideLineA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPSTR")] sbyte* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, sbyte*, uint*, int>)(lpVtbl[29]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int GetGuideLineW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPWSTR")] ushort* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, ushort*, uint*, int>)(lpVtbl[30]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetIMEFileNameA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, sbyte*, uint*, int>)(lpVtbl[31]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int GetIMEFileNameW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szFileName, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, ushort*, uint*, int>)(lpVtbl[32]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int GetOpenStatus([NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[33]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("DWORD")] uint fdwIndex, [NativeTypeName("DWORD *")] uint* pdwProperty)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint*, int>)(lpVtbl[34]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, fdwIndex, pdwProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegisterWordStyleA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFA* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, STYLEBUFA*, uint*, int>)(lpVtbl[35]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegisterWordStyleW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT")] uint nItem, STYLEBUFW* pStyleBuf, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, STYLEBUFW*, uint*, int>)(lpVtbl[36]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatusWindowPos([NativeTypeName("HIMC")] IntPtr hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, POINT*, int>)(lpVtbl[37]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int GetVirtualKey([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT *")] uint* puVirtualKey)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, int>)(lpVtbl[38]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, puVirtualKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int InstallIMEA([NativeTypeName("LPSTR")] sbyte* szIMEFileName, [NativeTypeName("LPSTR")] sbyte* szLayoutText, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, sbyte*, sbyte*, IntPtr*, int>)(lpVtbl[39]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int InstallIMEW([NativeTypeName("LPWSTR")] ushort* szIMEFileName, [NativeTypeName("LPWSTR")] ushort* szLayoutText, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, ushort*, ushort*, IntPtr*, int>)(lpVtbl[40]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int IsIME([NativeTypeName("HKL")] IntPtr hKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[41]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int IsUIMessageA([NativeTypeName("HWND")] IntPtr hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, nuint, nint, int>)(lpVtbl[42]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int IsUIMessageW([NativeTypeName("HWND")] IntPtr hWndIME, [NativeTypeName("UINT")] uint msg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, nuint, nint, int>)(lpVtbl[43]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyIME([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, uint, int>)(lpVtbl[44]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, sbyte*, uint, sbyte*, int>)(lpVtbl[45]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, ushort*, uint, ushort*, int>)(lpVtbl[46]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseContext([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, int>)(lpVtbl[47]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int SetCandidateWindow([NativeTypeName("HIMC")] IntPtr hIMC, CANDIDATEFORM* pCandidate)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, CANDIDATEFORM*, int>)(lpVtbl[48]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCandidate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionFontA([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTA* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, LOGFONTA*, int>)(lpVtbl[49]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionFontW([NativeTypeName("HIMC")] IntPtr hIMC, LOGFONTW* plf)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, LOGFONTW*, int>)(lpVtbl[50]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, plf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionStringA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, void*, uint, void*, uint, int>)(lpVtbl[51]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionStringW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, void*, uint, void*, uint, int>)(lpVtbl[52]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionWindow([NativeTypeName("HIMC")] IntPtr hIMC, COMPOSITIONFORM* pCompForm)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, COMPOSITIONFORM*, int>)(lpVtbl[53]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int SetConversionStatus([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint fdwConversion, [NativeTypeName("DWORD")] uint fdwSentence)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, int>)(lpVtbl[54]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, fdwConversion, fdwSentence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpenStatus([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("BOOL")] int fOpen)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int, int>)(lpVtbl[55]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, fOpen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int SetStatusWindowPos([NativeTypeName("HIMC")] IntPtr hIMC, POINT* pptPos)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, POINT*, int>)(lpVtbl[56]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pptPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int SimulateHotKey([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwHotKeyID)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, int>)(lpVtbl[57]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, dwHotKeyID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterWordA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, sbyte*, uint, sbyte*, int>)(lpVtbl[58]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterWordW([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szUnregister)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, ushort*, uint, ushort*, int>)(lpVtbl[59]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int GenerateMessage([NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[60]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int LockIMC([NativeTypeName("HIMC")] IntPtr hIMC, INPUTCONTEXT** ppIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, INPUTCONTEXT**, int>)(lpVtbl[61]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, ppIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockIMC([NativeTypeName("HIMC")] IntPtr hIMC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[62]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int GetIMCLockCount([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwLockCount)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, int>)(lpVtbl[63]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, pdwLockCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int CreateIMCC([NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("HIMCC *")] IntPtr* phIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, IntPtr*, int>)(lpVtbl[64]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwSize, phIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int DestroyIMCC([NativeTypeName("HIMCC")] IntPtr hIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[65]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int LockIMCC([NativeTypeName("HIMCC")] IntPtr hIMCC, void** ppv)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, void**, int>)(lpVtbl[66]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockIMCC([NativeTypeName("HIMCC")] IntPtr hIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[67]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int ReSizeIMCC([NativeTypeName("HIMCC")] IntPtr hIMCC, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("HIMCC *")] IntPtr* phIMCC)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, IntPtr*, int>)(lpVtbl[68]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, dwSize, phIMCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int GetIMCCSize([NativeTypeName("HIMCC")] IntPtr hIMCC, [NativeTypeName("DWORD *")] uint* pdwSize)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, int>)(lpVtbl[69]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, pdwSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int GetIMCCLockCount([NativeTypeName("HIMCC")] IntPtr hIMCC, [NativeTypeName("DWORD *")] uint* pdwLockCount)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, int>)(lpVtbl[70]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMCC, pdwLockCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int GetHotKey([NativeTypeName("DWORD")] uint dwHotKeyID, [NativeTypeName("UINT *")] uint* puModifiers, [NativeTypeName("UINT *")] uint* puVKey, [NativeTypeName("HKL *")] IntPtr* phKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, uint*, uint*, IntPtr*, int>)(lpVtbl[71]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwHotKeyID, puModifiers, puVKey, phKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int SetHotKey([NativeTypeName("DWORD")] uint dwHotKeyID, [NativeTypeName("UINT")] uint uModifiers, [NativeTypeName("UINT")] uint uVKey, [NativeTypeName("HKL")] IntPtr hKL)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, uint, uint, IntPtr, int>)(lpVtbl[72]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), dwHotKeyID, uModifiers, uVKey, hKL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int CreateSoftKeyboard([NativeTypeName("UINT")] uint uType, [NativeTypeName("HWND")] IntPtr hOwner, int x, int y, [NativeTypeName("HWND *")] IntPtr* phSoftKbdWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, IntPtr, int, int, IntPtr*, int>)(lpVtbl[73]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), uType, hOwner, x, y, phSoftKbdWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int DestroySoftKeyboard([NativeTypeName("HWND")] IntPtr hSoftKbdWnd)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int>)(lpVtbl[74]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hSoftKbdWnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int ShowSoftKeyboard([NativeTypeName("HWND")] IntPtr hSoftKbdWnd, int nCmdShow)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, int, int>)(lpVtbl[75]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hSoftKbdWnd, nCmdShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int GetCodePageA([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("UINT *")] uint* uCodePage)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint*, int>)(lpVtbl[76]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, uCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int GetLangId([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("LANGID *")] ushort* plid)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, ushort*, int>)(lpVtbl[77]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hKL, plid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int KeybdEvent([NativeTypeName("LANGID")] ushort lgidIME, [NativeTypeName("BYTE")] byte bVk, [NativeTypeName("BYTE")] byte bScan, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwExtraInfo)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, ushort, byte, byte, uint, uint, int>)(lpVtbl[78]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), lgidIME, bVk, bScan, dwFlags, dwExtraInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int LockModal()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[79]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockModal()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[80]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int AssociateContextEx([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, IntPtr, uint, int>)(lpVtbl[81]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, hIMC, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int DisableIME([NativeTypeName("DWORD")] uint idThread)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, int>)(lpVtbl[82]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), idThread);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int GetImeMenuItemsA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOA* pImeParentMenu, IMEMENUITEMINFOA* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, IMEMENUITEMINFOA*, IMEMENUITEMINFOA*, uint, uint*, int>)(lpVtbl[83]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int GetImeMenuItemsW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOW* pImeParentMenu, IMEMENUITEMINFOW* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint*, int>)(lpVtbl[84]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int EnumInputContext([NativeTypeName("DWORD")] uint idThread, IEnumInputContext** ppEnum)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, uint, IEnumInputContext**, int>)(lpVtbl[85]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), idThread, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int RequestMessageA([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, nuint, nint, nint*, int>)(lpVtbl[86]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int RequestMessageW([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, nuint, nint, nint*, int>)(lpVtbl[87]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hIMC, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int SendIMCA([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, nuint, nint, nint*, int>)(lpVtbl[88]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, uMsg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int SendIMCW([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("UINT")] uint uMsg, [NativeTypeName("WPARAM")] nuint wParam, [NativeTypeName("LPARAM")] nint lParam, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIMMIME*, IntPtr, uint, nuint, nint, nint*, int>)(lpVtbl[89]))((IActiveIMMIME*)Unsafe.AsPointer(ref this), hWnd, uMsg, wParam, lParam, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int IsSleeping()
        {
            return ((delegate* unmanaged<IActiveIMMIME*, int>)(lpVtbl[90]))((IActiveIMMIME*)Unsafe.AsPointer(ref this));
        }
    }
}
