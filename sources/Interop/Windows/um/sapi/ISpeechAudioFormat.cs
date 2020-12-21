// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6E9C590-3E18-40E3-8299-061F98BDE7C7")]
    [NativeTypeName("struct ISpeechAudioFormat : IDispatch")]
    public unsafe partial struct ISpeechAudioFormat
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, uint>)(lpVtbl[1]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, uint>)(lpVtbl[2]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, uint*, int>)(lpVtbl[3]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SpeechAudioFormatType *")] SpeechAudioFormatType* AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, SpeechAudioFormatType*, int>)(lpVtbl[7]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Type(SpeechAudioFormatType AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, SpeechAudioFormatType, int>)(lpVtbl[8]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Guid([NativeTypeName("BSTR *")] ushort** Guid)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, ushort**, int>)(lpVtbl[9]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), Guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Guid([NativeTypeName("BSTR")] ushort* Guid)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, ushort*, int>)(lpVtbl[10]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), Guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWaveFormatEx([NativeTypeName("ISpeechWaveFormatEx **")] ISpeechWaveFormatEx** SpeechWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, ISpeechWaveFormatEx**, int>)(lpVtbl[11]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), SpeechWaveFormatEx);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWaveFormatEx([NativeTypeName("ISpeechWaveFormatEx *")] ISpeechWaveFormatEx* SpeechWaveFormatEx)
        {
            return ((delegate* unmanaged<ISpeechAudioFormat*, ISpeechWaveFormatEx*, int>)(lpVtbl[12]))((ISpeechAudioFormat*)Unsafe.AsPointer(ref this), SpeechWaveFormatEx);
        }
    }
}
