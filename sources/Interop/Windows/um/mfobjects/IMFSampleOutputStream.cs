// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FEED468-6F7E-440D-869A-49BDD283AD0D")]
    [NativeTypeName("struct IMFSampleOutputStream : IUnknown")]
    public unsafe partial struct IMFSampleOutputStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, uint>)(lpVtbl[1]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, uint>)(lpVtbl[2]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginWriteSample([NativeTypeName("IMFSample *")] IMFSample* pSample, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, IMFSample*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pSample, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndWriteSample([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<IMFSampleOutputStream*, int>)(lpVtbl[5]))((IMFSampleOutputStream*)Unsafe.AsPointer(ref this));
        }
    }
}
