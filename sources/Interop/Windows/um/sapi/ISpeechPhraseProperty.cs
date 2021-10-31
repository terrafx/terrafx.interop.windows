// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE563D48-961E-4732-A2E1-378A42B430BE")]
    [NativeTypeName("struct ISpeechPhraseProperty : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechPhraseProperty
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, uint>)(lpVtbl[1]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, uint>)(lpVtbl[2]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, ushort**, int>)(lpVtbl[7]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int>)(lpVtbl[8]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Value(VARIANT* Value)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int>)(lpVtbl[10]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, int*, int>)(lpVtbl[11]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_EngineConfidence(float* Confidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, float*, int>)(lpVtbl[12]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_Confidence(SpeechEngineConfidence* Confidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, SpeechEngineConfidence*, int>)(lpVtbl[13]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Parent(ISpeechPhraseProperty** ParentProperty)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, ISpeechPhraseProperty**, int>)(lpVtbl[14]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), ParentProperty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_Children(ISpeechPhraseProperties** Children)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperty*, ISpeechPhraseProperties**, int>)(lpVtbl[15]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Children);
        }
    }
}
