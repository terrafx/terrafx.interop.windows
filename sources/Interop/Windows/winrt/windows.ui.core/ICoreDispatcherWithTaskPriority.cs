// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAFAECAD-484D-41BE-BA80-1D58C65263EA")]
    [NativeTypeName("struct ICoreDispatcherWithTaskPriority : IInspectable")]
    public unsafe partial struct ICoreDispatcherWithTaskPriority
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, Guid*, void**, int>)(lpVtbl[0]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, uint>)(lpVtbl[1]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, uint>)(lpVtbl[2]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, IntPtr*, int>)(lpVtbl[4]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, TrustLevel*, int>)(lpVtbl[5]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority *")] CoreDispatcherPriority* value)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority*, int>)(lpVtbl[6]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_CurrentPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority value)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority, int>)(lpVtbl[7]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldYield([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, byte*, int>)(lpVtbl[8]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ShouldYieldToPriority([NativeTypeName("ABI::Windows::UI::Core::CoreDispatcherPriority")] CoreDispatcherPriority priority, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, CoreDispatcherPriority, byte*, int>)(lpVtbl[9]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this), priority, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StopProcessEvents()
        {
            return ((delegate* unmanaged<ICoreDispatcherWithTaskPriority*, int>)(lpVtbl[10]))((ICoreDispatcherWithTaskPriority*)Unsafe.AsPointer(ref this));
        }
    }
}
