// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E1C4BF0E-2D53-11D2-93E1-0060B067B86E")]
    [NativeTypeName("struct IActiveIME2 : IActiveIME")]
    [NativeInheritance("IActiveIME")]
    public unsafe partial struct IActiveIME2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActiveIME2*, Guid*, void**, int>)(lpVtbl[0]))((IActiveIME2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActiveIME2*, uint>)(lpVtbl[1]))((IActiveIME2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActiveIME2*, uint>)(lpVtbl[2]))((IActiveIME2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Inquire([NativeTypeName("DWORD")] uint dwSystemInfoFlags, IMEINFO* pIMEInfo, [NativeTypeName("LPWSTR")] ushort* szWndClass, [NativeTypeName("DWORD *")] uint* pdwPrivate)
        {
            return ((delegate* unmanaged<IActiveIME2*, uint, IMEINFO*, ushort*, uint*, int>)(lpVtbl[3]))((IActiveIME2*)Unsafe.AsPointer(ref this), dwSystemInfoFlags, pIMEInfo, szWndClass, pdwPrivate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ConversionList([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("LPWSTR")] ushort* szSource, [NativeTypeName("UINT")] uint uFlag, [NativeTypeName("UINT")] uint uBufLen, CANDIDATELIST* pDest, [NativeTypeName("UINT *")] uint* puCopied)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, ushort*, uint, uint, CANDIDATELIST*, uint*, int>)(lpVtbl[4]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, szSource, uFlag, uBufLen, pDest, puCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Configure([NativeTypeName("HKL")] IntPtr hKL, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pRegisterWord)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, IntPtr, uint, REGISTERWORDW*, int>)(lpVtbl[5]))((IActiveIME2*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pRegisterWord);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Destroy([NativeTypeName("UINT")] uint uReserved)
        {
            return ((delegate* unmanaged<IActiveIME2*, uint, int>)(lpVtbl[6]))((IActiveIME2*)Unsafe.AsPointer(ref this), uReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Escape([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uEscape, void* pData, [NativeTypeName("LRESULT *")] nint* plResult)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, uint, void*, nint*, int>)(lpVtbl[7]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, uEscape, pData, plResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveContext([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("BOOL")] int fFlag)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, int, int>)(lpVtbl[8]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, fFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessKey([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("UINT")] uint uVirKey, [NativeTypeName("DWORD")] uint lParam, [NativeTypeName("BYTE *")] byte* pbKeyState)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, uint, uint, byte*, int>)(lpVtbl[9]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, uVirKey, lParam, pbKeyState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Notify([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, uint, uint, uint, int>)(lpVtbl[10]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int Select([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("BOOL")] int fSelect)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, int, int>)(lpVtbl[11]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, fSelect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetCompositionString([NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD")] uint dwIndex, void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
        {
            return ((delegate* unmanaged<IActiveIME2*, IntPtr, uint, void*, uint, void*, uint, int>)(lpVtbl[12]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int ToAsciiEx([NativeTypeName("UINT")] uint uVirKey, [NativeTypeName("UINT")] uint uScanCode, [NativeTypeName("BYTE *")] byte* pbKeyState, [NativeTypeName("UINT")] uint fuState, [NativeTypeName("HIMC")] IntPtr hIMC, [NativeTypeName("DWORD *")] uint* pdwTransBuf, [NativeTypeName("UINT *")] uint* puSize)
        {
            return ((delegate* unmanaged<IActiveIME2*, uint, uint, byte*, uint, IntPtr, uint*, uint*, int>)(lpVtbl[13]))((IActiveIME2*)Unsafe.AsPointer(ref this), uVirKey, uScanCode, pbKeyState, fuState, hIMC, pdwTransBuf, puSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szString)
        {
            return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, int>)(lpVtbl[14]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int UnregisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szString)
        {
            return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, int>)(lpVtbl[15]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetRegisterWordStyle([NativeTypeName("UINT")] uint nItem, STYLEBUFW* pStyleBuf, [NativeTypeName("UINT *")] uint* puBufSize)
        {
            return ((delegate* unmanaged<IActiveIME2*, uint, STYLEBUFW*, uint*, int>)(lpVtbl[16]))((IActiveIME2*)Unsafe.AsPointer(ref this), nItem, pStyleBuf, puBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRegisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** ppEnum)
        {
            return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int>)(lpVtbl[17]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szRegister, pData, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetCodePageA([NativeTypeName("UINT *")] uint* uCodePage)
        {
            return ((delegate* unmanaged<IActiveIME2*, uint*, int>)(lpVtbl[18]))((IActiveIME2*)Unsafe.AsPointer(ref this), uCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetLangId([NativeTypeName("LANGID *")] ushort* plid)
        {
            return ((delegate* unmanaged<IActiveIME2*, ushort*, int>)(lpVtbl[19]))((IActiveIME2*)Unsafe.AsPointer(ref this), plid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int Sleep()
        {
            return ((delegate* unmanaged<IActiveIME2*, int>)(lpVtbl[20]))((IActiveIME2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int Unsleep([NativeTypeName("BOOL")] int fDead)
        {
            return ((delegate* unmanaged<IActiveIME2*, int, int>)(lpVtbl[21]))((IActiveIME2*)Unsafe.AsPointer(ref this), fDead);
        }
    }
}
