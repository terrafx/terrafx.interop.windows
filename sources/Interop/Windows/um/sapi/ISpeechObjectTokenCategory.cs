// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CA7EAC50-2D01-4145-86D4-5AE7D70F4469")]
    [NativeTypeName("struct ISpeechObjectTokenCategory : IDispatch")]
    public unsafe partial struct ISpeechObjectTokenCategory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, uint>)(lpVtbl[1]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, uint>)(lpVtbl[2]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, uint*, int>)(lpVtbl[3]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("BSTR *")] ushort** Id)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, ushort**, int>)(lpVtbl[7]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Default([NativeTypeName("const BSTR")] ushort* TokenId)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, ushort*, int>)(lpVtbl[8]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), TokenId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Default([NativeTypeName("BSTR *")] ushort** TokenId)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, ushort**, int>)(lpVtbl[9]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), TokenId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetId([NativeTypeName("const BSTR")] ushort* Id, [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, ushort*, short, int>)(lpVtbl[10]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), Id, CreateIfNotExist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDataKey(SpeechDataKeyLocation Location, [NativeTypeName("ISpeechDataKey **")] ISpeechDataKey** DataKey)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, SpeechDataKeyLocation, ISpeechDataKey**, int>)(lpVtbl[11]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), Location, DataKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumerateTokens([NativeTypeName("BSTR")] ushort* RequiredAttributes, [NativeTypeName("BSTR")] ushort* OptionalAttributes, [NativeTypeName("ISpeechObjectTokens **")] ISpeechObjectTokens** Tokens)
        {
            return ((delegate* stdcall<ISpeechObjectTokenCategory*, ushort*, ushort*, ISpeechObjectTokens**, int>)(lpVtbl[12]))((ISpeechObjectTokenCategory*)Unsafe.AsPointer(ref this), RequiredAttributes, OptionalAttributes, Tokens);
        }
    }
}
