// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3B9C7E7A-6EEE-4DED-9092-11657279ADBE")]
    [NativeTypeName("struct ISpeechTextSelectionInformation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechTextSelectionInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, uint>)(lpVtbl[1]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, uint>)(lpVtbl[2]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, uint*, int>)(lpVtbl[3]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_ActiveOffset([NativeTypeName("long")] int ActiveOffset)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int, int>)(lpVtbl[7]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), ActiveOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_ActiveOffset([NativeTypeName("long *")] int* ActiveOffset)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int*, int>)(lpVtbl[8]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), ActiveOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_ActiveLength([NativeTypeName("long")] int ActiveLength)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int, int>)(lpVtbl[9]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), ActiveLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_ActiveLength([NativeTypeName("long *")] int* ActiveLength)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int*, int>)(lpVtbl[10]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), ActiveLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_SelectionOffset([NativeTypeName("long")] int SelectionOffset)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int, int>)(lpVtbl[11]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), SelectionOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_SelectionOffset([NativeTypeName("long *")] int* SelectionOffset)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int*, int>)(lpVtbl[12]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), SelectionOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_SelectionLength([NativeTypeName("long")] int SelectionLength)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int, int>)(lpVtbl[13]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), SelectionLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_SelectionLength([NativeTypeName("long *")] int* SelectionLength)
        {
            return ((delegate* unmanaged<ISpeechTextSelectionInformation*, int*, int>)(lpVtbl[14]))((ISpeechTextSelectionInformation*)Unsafe.AsPointer(ref this), SelectionLength);
        }
    }
}
