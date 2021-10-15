// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C2B5F241-DAA0-4507-9E16-5A1EAA2B7A5C")]
    [NativeTypeName("struct ISpRecognizer : ISpProperties")]
    [NativeInheritance("ISpProperties")]
    public unsafe partial struct ISpRecognizer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecognizer*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecognizer*, uint>)(lpVtbl[1]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecognizer*, uint>)(lpVtbl[2]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int lValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, int, int>)(lpVtbl[3]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, lValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG *")] int* plValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, int*, int>)(lpVtbl[4]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, plValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPCWSTR")] ushort* pValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pName, ppCoMemValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetRecognizer(ISpObjectToken* pRecognizer)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[7]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pRecognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecognizer(ISpObjectToken** ppRecognizer)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[8]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppRecognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetInput(IUnknown* pUnkInput, [NativeTypeName("BOOL")] int fAllowFormatChanges)
        {
            return ((delegate* unmanaged<ISpRecognizer*, IUnknown*, int, int>)(lpVtbl[9]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pUnkInput, fAllowFormatChanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputObjectToken(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[10]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputStream(ISpStreamFormat** ppStream)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpStreamFormat**, int>)(lpVtbl[11]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRecoContext(ISpRecoContext** ppNewCtxt)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpRecoContext**, int>)(lpVtbl[12]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppNewCtxt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoProfile(ISpObjectToken** ppToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken**, int>)(lpVtbl[13]))((ISpRecognizer*)Unsafe.AsPointer(ref this), ppToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetRecoProfile(ISpObjectToken* pToken)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpObjectToken*, int>)(lpVtbl[14]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int IsSharedInstance()
        {
            return ((delegate* unmanaged<ISpRecognizer*, int>)(lpVtbl[15]))((ISpRecognizer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoState(SPRECOSTATE* pState)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOSTATE*, int>)(lpVtbl[16]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetRecoState(SPRECOSTATE NewState)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOSTATE, int>)(lpVtbl[17]))((ISpRecognizer*)Unsafe.AsPointer(ref this), NewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetStatus(SPRECOGNIZERSTATUS* pStatus)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPRECOGNIZERSTATUS*, int>)(lpVtbl[18]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormat(SPSTREAMFORMATTYPE WaveFormatType, [NativeTypeName("GUID *")] Guid* pFormatId, WAVEFORMATEX** ppCoMemWFEX)
        {
            return ((delegate* unmanaged<ISpRecognizer*, SPSTREAMFORMATTYPE, Guid*, WAVEFORMATEX**, int>)(lpVtbl[19]))((ISpRecognizer*)Unsafe.AsPointer(ref this), WaveFormatType, pFormatId, ppCoMemWFEX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int IsUISupported([NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData, [NativeTypeName("BOOL *")] int* pfSupported)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ushort*, void*, uint, int*, int>)(lpVtbl[20]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pszTypeOfUI, pvExtraData, cbExtraData, pfSupported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int DisplayUI([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszTypeOfUI, void* pvExtraData, [NativeTypeName("ULONG")] uint cbExtraData)
        {
            return ((delegate* unmanaged<ISpRecognizer*, IntPtr, ushort*, ushort*, void*, uint, int>)(lpVtbl[21]))((ISpRecognizer*)Unsafe.AsPointer(ref this), hwndParent, pszTitle, pszTypeOfUI, pvExtraData, cbExtraData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int EmulateRecognition(ISpPhrase* pPhrase)
        {
            return ((delegate* unmanaged<ISpRecognizer*, ISpPhrase*, int>)(lpVtbl[22]))((ISpRecognizer*)Unsafe.AsPointer(ref this), pPhrase);
        }
    }
}
