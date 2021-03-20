// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A4ED5C81-76C9-40BD-8BE6-B1D90FB20AE7")]
    [NativeTypeName("struct IAsyncActionCompletedHandler : IUnknown")]
    public unsafe partial struct IAsyncActionCompletedHandler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncActionCompletedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncActionCompletedHandler*, uint>)(lpVtbl[1]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncActionCompletedHandler*, uint>)(lpVtbl[2]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("ABI::Windows::Foundation::IAsyncAction *")] IAsyncAction* asyncInfo, [NativeTypeName("ABI::Windows::Foundation::AsyncStatus")] AsyncStatus asyncStatus)
        {
            return ((delegate* unmanaged<IAsyncActionCompletedHandler*, IAsyncAction*, AsyncStatus, int>)(lpVtbl[3]))((IAsyncActionCompletedHandler*)Unsafe.AsPointer(ref this), asyncInfo, asyncStatus);
        }
    }
}
