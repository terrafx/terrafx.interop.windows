// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFF9E781-53EC-484E-BB8A-0E1B5551E35C")]
    [NativeTypeName("struct ISpeechRecognizerStatus : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechRecognizerStatus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint>)(lpVtbl[1]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint>)(lpVtbl[2]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint*, int>)(lpVtbl[3]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_AudioStatus(ISpeechAudioStatus** AudioStatus)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, ISpeechAudioStatus**, int>)(lpVtbl[7]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), AudioStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_CurrentStreamPosition(VARIANT* pCurrentStreamPos)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, VARIANT*, int>)(lpVtbl[8]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pCurrentStreamPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, int*, int>)(lpVtbl[9]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_NumberOfActiveRules([NativeTypeName("long *")] int* NumberOfActiveRules)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, int*, int>)(lpVtbl[10]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), NumberOfActiveRules);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_ClsidEngine([NativeTypeName("BSTR *")] ushort** ClsidEngine)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, ushort**, int>)(lpVtbl[11]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), ClsidEngine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_SupportedLanguages(VARIANT* SupportedLanguages)
        {
            return ((delegate* unmanaged<ISpeechRecognizerStatus*, VARIANT*, int>)(lpVtbl[12]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), SupportedLanguages);
        }
    }
}
