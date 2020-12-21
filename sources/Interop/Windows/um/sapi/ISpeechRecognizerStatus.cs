// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BFF9E781-53EC-484E-BB8A-0E1B5551E35C")]
    [NativeTypeName("struct ISpeechRecognizerStatus : IDispatch")]
    public unsafe partial struct ISpeechRecognizerStatus
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, uint>)(lpVtbl[1]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, uint>)(lpVtbl[2]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, uint*, int>)(lpVtbl[3]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioStatus([NativeTypeName("ISpeechAudioStatus **")] ISpeechAudioStatus** AudioStatus)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, ISpeechAudioStatus**, int>)(lpVtbl[7]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), AudioStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentStreamPosition([NativeTypeName("VARIANT *")] VARIANT* pCurrentStreamPos)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, VARIANT*, int>)(lpVtbl[8]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), pCurrentStreamPos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentStreamNumber([NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, int*, int>)(lpVtbl[9]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfActiveRules([NativeTypeName("long *")] int* NumberOfActiveRules)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, int*, int>)(lpVtbl[10]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), NumberOfActiveRules);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ClsidEngine([NativeTypeName("BSTR *")] ushort** ClsidEngine)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, ushort**, int>)(lpVtbl[11]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), ClsidEngine);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedLanguages([NativeTypeName("VARIANT *")] VARIANT* SupportedLanguages)
        {
            return ((delegate* unmanaged[Stdcall]<ISpeechRecognizerStatus*, VARIANT*, int>)(lpVtbl[12]))((ISpeechRecognizerStatus*)Unsafe.AsPointer(ref this), SupportedLanguages);
        }
    }
}
