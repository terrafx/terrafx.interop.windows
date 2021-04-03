// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1A9E9F4F-104F-4DB8-A115-EFD7FD0C97AE")]
    [NativeTypeName("struct ISpeechCustomStream : ISpeechBaseStream")]
    public unsafe partial struct ISpeechCustomStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, uint>)(lpVtbl[1]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, uint>)(lpVtbl[2]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, uint*, int>)(lpVtbl[3]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Format(ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_Format(ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BaseStream(IUnknown** ppUnkStream)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, IUnknown**, int>)(lpVtbl[12]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), ppUnkStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_BaseStream(IUnknown* pUnkStream)
        {
            return ((delegate* unmanaged<ISpeechCustomStream*, IUnknown*, int>)(lpVtbl[13]))((ISpeechCustomStream*)Unsafe.AsPointer(ref this), pUnkStream);
        }
    }
}
