// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("08166B47-102E-4B23-A599-BDB98DBFD1F4")]
    [NativeTypeName("struct ISpeechPhraseProperties : IDispatch")]
    public unsafe partial struct ISpeechPhraseProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, uint>)(lpVtbl[1]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, uint>)(lpVtbl[2]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, int*, int>)(lpVtbl[7]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("long")] int Index, ISpeechPhraseProperty** Property)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, int, ISpeechPhraseProperty**, int>)(lpVtbl[8]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), Index, Property);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** EnumVARIANT)
        {
            return ((delegate* unmanaged<ISpeechPhraseProperties*, IUnknown**, int>)(lpVtbl[9]))((ISpeechPhraseProperties*)Unsafe.AsPointer(ref this), EnumVARIANT);
        }
    }
}
