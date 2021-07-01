// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7BFE112-A4A0-48D9-B602-C313843F6964")]
    [NativeTypeName("struct ISpeechPhraseRule : IDispatch")]
    public unsafe partial struct ISpeechPhraseRule
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, uint>)(lpVtbl[1]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, uint>)(lpVtbl[2]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, ushort**, int>)(lpVtbl[7]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, int*, int>)(lpVtbl[8]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, int*, int>)(lpVtbl[9]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, int*, int>)(lpVtbl[10]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Parent(ISpeechPhraseRule** Parent)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, ISpeechPhraseRule**, int>)(lpVtbl[11]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Children(ISpeechPhraseRules** Children)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, ISpeechPhraseRules**, int>)(lpVtbl[12]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Children);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Confidence(SpeechEngineConfidence* ActualConfidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, SpeechEngineConfidence*, int>)(lpVtbl[13]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), ActualConfidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence(float* EngineConfidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseRule*, float*, int>)(lpVtbl[14]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), EngineConfidence);
        }
    }
}
