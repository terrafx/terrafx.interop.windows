// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11B103D8-1142-4EDF-A093-82FB3915F8CC")]
    [NativeTypeName("struct ISpeechAudioBufferInfo : IDispatch")]
    public unsafe partial struct ISpeechAudioBufferInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, uint>)(lpVtbl[1]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, uint>)(lpVtbl[2]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, uint*, int>)(lpVtbl[3]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_MinNotification([NativeTypeName("long *")] int* MinNotification)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int*, int>)(lpVtbl[7]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), MinNotification);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_MinNotification([NativeTypeName("long")] int MinNotification)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int, int>)(lpVtbl[8]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), MinNotification);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_BufferSize([NativeTypeName("long *")] int* BufferSize)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int*, int>)(lpVtbl[9]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), BufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_BufferSize([NativeTypeName("long")] int BufferSize)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int, int>)(lpVtbl[10]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), BufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_EventBias([NativeTypeName("long *")] int* EventBias)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int*, int>)(lpVtbl[11]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), EventBias);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_EventBias([NativeTypeName("long")] int EventBias)
        {
            return ((delegate* stdcall<ISpeechAudioBufferInfo*, int, int>)(lpVtbl[12]))((ISpeechAudioBufferInfo*)Unsafe.AsPointer(ref this), EventBias);
        }
    }
}
