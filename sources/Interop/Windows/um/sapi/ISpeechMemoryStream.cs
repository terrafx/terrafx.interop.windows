// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EEB14B68-808B-4ABE-A5EA-B51DA7588008")]
    [NativeTypeName("struct ISpeechMemoryStream : ISpeechBaseStream")]
    [NativeInheritance("ISpeechBaseStream")]
    public unsafe partial struct ISpeechMemoryStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, uint>)(lpVtbl[1]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, uint>)(lpVtbl[2]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, uint*, int>)(lpVtbl[3]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Format(ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT putref_Format(ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetData(VARIANT Data)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, VARIANT, int>)(lpVtbl[12]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetData(VARIANT* pData)
        {
            return ((delegate* unmanaged<ISpeechMemoryStream*, VARIANT*, int>)(lpVtbl[13]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), pData);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, ISpeechAudioFormat**, int> get_Format;

            [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, ISpeechAudioFormat*, int> putref_Format;

            [NativeTypeName("HRESULT (VARIANT *, long, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, VARIANT*, int, int*, int> Read;

            [NativeTypeName("HRESULT (VARIANT, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, VARIANT, int*, int> Write;

            [NativeTypeName("HRESULT (VARIANT, SpeechStreamSeekPositionType, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int> Seek;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, VARIANT, int> SetData;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechMemoryStream*, VARIANT*, int> GetData;
        }
    }
}
