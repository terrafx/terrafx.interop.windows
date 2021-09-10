// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA139-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfReadingInformationUIElement : ITfUIElement")]
    [NativeInheritance("ITfUIElement")]
    public unsafe partial struct ITfReadingInformationUIElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint>)(lpVtbl[1]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint>)(lpVtbl[2]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, ushort**, int>)(lpVtbl[3]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, Guid*, int>)(lpVtbl[4]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("BOOL")] int bShow)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, int, int>)(lpVtbl[5]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IsShown([NativeTypeName("BOOL *")] int* pbShow)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, int*, int>)(lpVtbl[6]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[7]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetContext(ITfContext** ppic)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, ITfContext**, int>)(lpVtbl[8]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), ppic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, ushort**, int>)(lpVtbl[9]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxReadingStringLength([NativeTypeName("UINT *")] uint* pcchMax)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[10]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pcchMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetErrorIndex([NativeTypeName("UINT *")] uint* pErrorIndex)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[11]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pErrorIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int IsVerticalOrderPreferred([NativeTypeName("BOOL *")] int* pfVertical)
        {
            return ((delegate* unmanaged<ITfReadingInformationUIElement*, int*, int>)(lpVtbl[12]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pfVertical);
        }
    }
}
