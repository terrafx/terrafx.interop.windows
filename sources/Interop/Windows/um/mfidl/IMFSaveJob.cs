// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9931663-80BF-4C6E-98AF-5DCF58747D1F")]
    [NativeTypeName("struct IMFSaveJob : IUnknown")]
    public unsafe partial struct IMFSaveJob
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSaveJob*, Guid*, void**, int>)(lpVtbl[0]))((IMFSaveJob*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSaveJob*, uint>)(lpVtbl[1]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSaveJob*, uint>)(lpVtbl[2]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginSave([NativeTypeName("IMFByteStream *")] IMFByteStream* pStream, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* pState)
        {
            return ((delegate* stdcall<IMFSaveJob*, IMFByteStream*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pStream, pCallback, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndSave([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFSaveJob*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelSave()
        {
            return ((delegate* stdcall<IMFSaveJob*, int>)(lpVtbl[5]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProgress([NativeTypeName("DWORD *")] uint* pdwPercentComplete)
        {
            return ((delegate* stdcall<IMFSaveJob*, uint*, int>)(lpVtbl[6]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pdwPercentComplete);
        }
    }
}
