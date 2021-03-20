// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FF1C4C4A-9287-470B-836E-9086E3126ADE")]
    [NativeTypeName("struct IAcceleratorKeyEventArgs : IInspectable")]
    public unsafe partial struct IAcceleratorKeyEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, uint>)(lpVtbl[1]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, uint>)(lpVtbl[2]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EventType([NativeTypeName("ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *")] CoreAcceleratorKeyEventType* value)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, CoreAcceleratorKeyEventType*, int>)(lpVtbl[6]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VirtualKey([NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, VirtualKey*, int>)(lpVtbl[7]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_KeyStatus([NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")] CorePhysicalKeyStatus* value)
        {
            return ((delegate* unmanaged<IAcceleratorKeyEventArgs*, CorePhysicalKeyStatus*, int>)(lpVtbl[8]))((IAcceleratorKeyEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
