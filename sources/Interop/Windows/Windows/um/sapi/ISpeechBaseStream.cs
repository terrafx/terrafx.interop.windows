// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("6450336F-7D49-4CED-8097-49D6DEE37294")]
[NativeTypeName("struct ISpeechBaseStream : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechBaseStream : ISpeechBaseStream.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, uint>)(lpVtbl[1]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, uint>)(lpVtbl[2]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, uint*, int>)(lpVtbl[3]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Format(ISpeechAudioFormat** AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT putref_Format(ISpeechAudioFormat* AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
    {
        return ((delegate* unmanaged<ISpeechBaseStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechBaseStream*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Format(ISpeechAudioFormat** AudioFormat);

        [VtblIndex(8)]
        HRESULT putref_Format(ISpeechAudioFormat* AudioFormat);

        [VtblIndex(9)]
        HRESULT Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead);

        [VtblIndex(10)]
        HRESULT Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten);

        [VtblIndex(11)]
        HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, ISpeechAudioFormat**, int> get_Format;

        [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, ISpeechAudioFormat*, int> putref_Format;

        [NativeTypeName("HRESULT (VARIANT *, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, VARIANT*, int, int*, int> Read;

        [NativeTypeName("HRESULT (VARIANT, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, VARIANT, int*, int> Write;

        [NativeTypeName("HRESULT (VARIANT, SpeechStreamSeekPositionType, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechBaseStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int> Seek;
    }
}
