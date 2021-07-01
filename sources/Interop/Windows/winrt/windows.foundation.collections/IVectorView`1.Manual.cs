// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BBE1FA4C-B0E3-4583-BAEF-1F1B2E483E56")]
    public unsafe partial struct IVectorView<T>
        where T : unmanaged
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVectorView<T>*, Guid*, void**, int>)(lpVtbl[0]))((IVectorView<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint>)(lpVtbl[1]))((IVectorView<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint>)(lpVtbl[2]))((IVectorView<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint*, Guid**, int>)(lpVtbl[3]))((IVectorView<T>*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVectorView<T>*, IntPtr*, int>)(lpVtbl[4]))((IVectorView<T>*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVectorView<T>*, TrustLevel*, int>)(lpVtbl[5]))((IVectorView<T>*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("unsigned")] uint index, [NativeTypeName("T_abi *")] T* item)
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint, T*, int>)(lpVtbl[6]))((IVectorView<T>*)Unsafe.AsPointer(ref this), index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("unsigned *")] uint* size)
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint*, int>)(lpVtbl[7]))((IVectorView<T>*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IndexOf([NativeTypeName("T_abi")] T value, [NativeTypeName("unsigned *")] uint* index, [NativeTypeName("boolean *")] byte* found)
        {
            return ((delegate* unmanaged<IVectorView<T>*, T, uint*, byte*, int>)(lpVtbl[8]))((IVectorView<T>*)Unsafe.AsPointer(ref this), value, index, found);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMany([NativeTypeName("unsigned")] uint startIndex, [NativeTypeName("unsigned")] uint capacity, [NativeTypeName("T_abi *")] T* value, [NativeTypeName("unsigned *")] uint* actual)
        {
            return ((delegate* unmanaged<IVectorView<T>*, uint, uint, T*, uint*, int>)(lpVtbl[9]))((IVectorView<T>*)Unsafe.AsPointer(ref this), startIndex, capacity, value, actual);
        }
    }
}
