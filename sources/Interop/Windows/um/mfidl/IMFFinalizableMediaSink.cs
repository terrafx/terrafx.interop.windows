// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EAECB74A-9A50-42CE-9541-6A7F57AA4AD7")]
    [NativeTypeName("struct IMFFinalizableMediaSink : IMFMediaSink")]
    public unsafe partial struct IMFFinalizableMediaSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint>)(lpVtbl[1]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint>)(lpVtbl[2]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint*, int>)(lpVtbl[3]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pdwCharacteristics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, [NativeTypeName("IMFMediaType *")] IMFMediaType* pMediaType, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFMediaType*, IMFStreamSink**, int>)(lpVtbl[4]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, pMediaType, ppStreamSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, int>)(lpVtbl[5]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint*, int>)(lpVtbl[6]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pcStreamSinkCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkByIndex([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[7]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwIndex, ppStreamSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStreamSinkById([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, [NativeTypeName("IMFStreamSink **")] IMFStreamSink** ppStreamSink)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[8]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, ppStreamSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pPresentationClock)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFPresentationClock*, int>)(lpVtbl[9]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pPresentationClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPresentationClock([NativeTypeName("IMFPresentationClock **")] IMFPresentationClock** ppPresentationClock)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFPresentationClock**, int>)(lpVtbl[10]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), ppPresentationClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, int>)(lpVtbl[11]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginFinalize([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[12]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndFinalize([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFFinalizableMediaSink*, IMFAsyncResult*, int>)(lpVtbl[13]))((IMFFinalizableMediaSink*)Unsafe.AsPointer(ref this), pResult);
        }
    }
}
