// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CD040608-FCF9-585C-BEAB-F1D2EAF364AB")]
    [NativeTypeName("struct ISystemFunctionLockChangedEventArgs : IInspectable")]
    public unsafe partial struct ISystemFunctionLockChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, uint>)(lpVtbl[1]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, uint>)(lpVtbl[2]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, ulong*, int>)(lpVtbl[6]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsLocked([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, byte*, int>)(lpVtbl[7]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Handled([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, byte*, int>)(lpVtbl[8]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Handled([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ISystemFunctionLockChangedEventArgs*, byte, int>)(lpVtbl[9]))((ISystemFunctionLockChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
