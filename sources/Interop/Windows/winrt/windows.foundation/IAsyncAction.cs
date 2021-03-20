// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5A648006-843A-4DA9-865B-9D26E5DFAD7B")]
    [NativeTypeName("struct IAsyncAction : IInspectable")]
    public unsafe partial struct IAsyncAction
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncAction*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncAction*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncAction*, uint>)(lpVtbl[1]))((IAsyncAction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncAction*, uint>)(lpVtbl[2]))((IAsyncAction*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAsyncAction*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncAction*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAsyncAction*, IntPtr*, int>)(lpVtbl[4]))((IAsyncAction*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAsyncAction*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncAction*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler *")] IAsyncActionCompletedHandler* handler)
        {
            return ((delegate* unmanaged<IAsyncAction*, IAsyncActionCompletedHandler*, int>)(lpVtbl[6]))((IAsyncAction*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Completed([NativeTypeName("ABI::Windows::Foundation::IAsyncActionCompletedHandler **")] IAsyncActionCompletedHandler** handler)
        {
            return ((delegate* unmanaged<IAsyncAction*, IAsyncActionCompletedHandler**, int>)(lpVtbl[7]))((IAsyncAction*)Unsafe.AsPointer(ref this), handler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResults()
        {
            return ((delegate* unmanaged<IAsyncAction*, int>)(lpVtbl[8]))((IAsyncAction*)Unsafe.AsPointer(ref this));
        }
    }
}
