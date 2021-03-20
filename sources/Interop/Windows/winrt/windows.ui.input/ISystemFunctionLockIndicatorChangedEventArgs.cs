// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B212B94E-7A6F-58AE-B304-BAE61D0371B9")]
    [NativeTypeName("struct ISystemFunctionLockIndicatorChangedEventArgs : IInspectable")]
    public unsafe partial struct ISystemFunctionLockIndicatorChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, uint>)(lpVtbl[1]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, uint>)(lpVtbl[2]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, ulong*, int>)(lpVtbl[6]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsIndicatorOn([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, byte*, int>)(lpVtbl[7]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Handled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, byte*, int>)(lpVtbl[8]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Handled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockIndicatorChangedEventArgs*, byte, int>)(lpVtbl[9]))((ISystemFunctionLockIndicatorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
