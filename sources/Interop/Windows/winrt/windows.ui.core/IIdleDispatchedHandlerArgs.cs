// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("98BB6A24-DC1C-43CB-B4ED-D1C0EB2391F3")]
    [NativeTypeName("struct IIdleDispatchedHandlerArgs : IInspectable")]
    public unsafe partial struct IIdleDispatchedHandlerArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, Guid*, void**, int>)(lpVtbl[0]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, uint>)(lpVtbl[1]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, uint>)(lpVtbl[2]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, IntPtr*, int>)(lpVtbl[4]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, TrustLevel*, int>)(lpVtbl[5]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsDispatcherIdle([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IIdleDispatchedHandlerArgs*, byte*, int>)(lpVtbl[6]))((IIdleDispatchedHandlerArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
