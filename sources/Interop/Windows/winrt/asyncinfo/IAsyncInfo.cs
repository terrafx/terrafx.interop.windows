// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/asyncinfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000036-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IAsyncInfo : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IAsyncInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncInfo*, uint>)(lpVtbl[1]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncInfo*, uint>)(lpVtbl[2]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAsyncInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAsyncInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAsyncInfo*, IntPtr*, int>)(lpVtbl[4]))((IAsyncInfo*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAsyncInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAsyncInfo*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("unsigned int *")] uint* id)
        {
            return ((delegate* unmanaged<IAsyncInfo*, uint*, int>)(lpVtbl[6]))((IAsyncInfo*)Unsafe.AsPointer(ref this), id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ABI::Windows::Foundation::AsyncStatus *")] AsyncStatus* status)
        {
            return ((delegate* unmanaged<IAsyncInfo*, AsyncStatus*, int>)(lpVtbl[7]))((IAsyncInfo*)Unsafe.AsPointer(ref this), status);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_ErrorCode([NativeTypeName("HRESULT *")] int* errorCode)
        {
            return ((delegate* unmanaged<IAsyncInfo*, int*, int>)(lpVtbl[8]))((IAsyncInfo*)Unsafe.AsPointer(ref this), errorCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return ((delegate* unmanaged<IAsyncInfo*, int>)(lpVtbl[9]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IAsyncInfo*, int>)(lpVtbl[10]))((IAsyncInfo*)Unsafe.AsPointer(ref this));
        }
    }
}
