// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("62B3B8FB-F6E7-41BE-BDCB-056B1C29EFC0")]
    [NativeTypeName("struct ISpeechRecoResultTimes : IDispatch")]
    public unsafe partial struct ISpeechRecoResultTimes
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, uint>)(lpVtbl[1]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, uint>)(lpVtbl[2]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StreamTime([NativeTypeName("VARIANT *")] VARIANT* Time)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, VARIANT*, int>)(lpVtbl[7]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), Time);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Length([NativeTypeName("VARIANT *")] VARIANT* Length)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, VARIANT*, int>)(lpVtbl[8]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TickCount([NativeTypeName("long *")] int* TickCount)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, int*, int>)(lpVtbl[9]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), TickCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OffsetFromStart([NativeTypeName("VARIANT *")] VARIANT* OffsetFromStart)
        {
            return ((delegate* stdcall<ISpeechRecoResultTimes*, VARIANT*, int>)(lpVtbl[10]))((ISpeechRecoResultTimes*)Unsafe.AsPointer(ref this), OffsetFromStart);
        }
    }
}
