// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.collections.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("913337E9-11A1-4345-A3A2-4E7F956E222D")]
    public unsafe partial struct IVector<T>
        where T : unmanaged
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IVector<T>*, Guid*, void**, int>)(lpVtbl[0]))((IVector<T>*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVector<T>*, uint>)(lpVtbl[1]))((IVector<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVector<T>*, uint>)(lpVtbl[2]))((IVector<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVector<T>*, uint*, Guid**, int>)(lpVtbl[3]))((IVector<T>*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVector<T>*, IntPtr*, int>)(lpVtbl[4]))((IVector<T>*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVector<T>*, TrustLevel*, int>)(lpVtbl[5]))((IVector<T>*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("unsigned")] uint index, [NativeTypeName("T_abi *")] T* item)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, T*, int>)(lpVtbl[6]))((IVector<T>*)Unsafe.AsPointer(ref this), index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Size([NativeTypeName("unsigned *")] uint* size)
        {
            return ((delegate* unmanaged<IVector<T>*, uint*, int>)(lpVtbl[7]))((IVector<T>*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetView([NativeTypeName("IVectorView<T_logical> **")] IVectorView<T>** view)
        {
            return ((delegate* unmanaged<IVector<T>*, IVectorView<T>**, int>)(lpVtbl[8]))((IVector<T>*)Unsafe.AsPointer(ref this), view);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IndexOf([NativeTypeName("T_abi")] T value, [NativeTypeName("unsigned *")] uint* index, [NativeTypeName("boolean *")] byte* found)
        {
            return ((delegate* unmanaged<IVector<T>*, T, uint*, byte*, int>)(lpVtbl[9]))((IVector<T>*)Unsafe.AsPointer(ref this), value, index, found);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAt([NativeTypeName("unsigned")] uint index, [NativeTypeName("T_abi")] T item)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, T, int>)(lpVtbl[10]))((IVector<T>*)Unsafe.AsPointer(ref this), index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertAt([NativeTypeName("unsigned")] uint index, [NativeTypeName("T_abi")] T item)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, T, int>)(lpVtbl[11]))((IVector<T>*)Unsafe.AsPointer(ref this), index, item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAt([NativeTypeName("unsigned")] uint index)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, int>)(lpVtbl[12]))((IVector<T>*)Unsafe.AsPointer(ref this), index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Append([NativeTypeName("T_abi")] T item)
        {
            return ((delegate* unmanaged<IVector<T>*, T, int>)(lpVtbl[13]))((IVector<T>*)Unsafe.AsPointer(ref this), item);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAtEnd()
        {
            return ((delegate* unmanaged<IVector<T>*, int>)(lpVtbl[14]))((IVector<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clear()
        {
            return ((delegate* unmanaged<IVector<T>*, int>)(lpVtbl[15]))((IVector<T>*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMany([NativeTypeName("unsigned")] uint startIndex, [NativeTypeName("unsigned")] uint capacity, [NativeTypeName("T_abi *")] T* value, [NativeTypeName("unsigned *")] uint* actual)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, uint, T*, uint*, int>)(lpVtbl[16]))((IVector<T>*)Unsafe.AsPointer(ref this), startIndex, capacity, value, actual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceAll([NativeTypeName("unsigned")] uint count, [NativeTypeName("T_abi *")] T* value)
        {
            return ((delegate* unmanaged<IVector<T>*, uint, T*, int>)(lpVtbl[17]))((IVector<T>*)Unsafe.AsPointer(ref this), count, value);
        }
    }
}
