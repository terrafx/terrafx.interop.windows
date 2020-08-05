// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9285B776-2E7B-4BC0-B53E-580EB6FA967F")]
    [NativeTypeName("struct ISpeechObjectTokens : IDispatch")]
    public unsafe partial struct ISpeechObjectTokens
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, uint>)(lpVtbl[1]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, uint>)(lpVtbl[2]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, uint*, int>)(lpVtbl[3]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, int*, int>)(lpVtbl[7]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), Count);
        }

        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("long")] int Index, [NativeTypeName("ISpeechObjectToken **")] ISpeechObjectToken** Token)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, int, ISpeechObjectToken**, int>)(lpVtbl[8]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), Index, Token);
        }

        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum([NativeTypeName("IUnknown **")] IUnknown** ppEnumVARIANT)
        {
            return ((delegate* stdcall<ISpeechObjectTokens*, IUnknown**, int>)(lpVtbl[9]))((ISpeechObjectTokens*)Unsafe.AsPointer(ref this), ppEnumVARIANT);
        }
    }
}
