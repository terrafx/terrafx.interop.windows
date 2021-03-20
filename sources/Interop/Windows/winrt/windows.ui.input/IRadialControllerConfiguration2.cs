// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D577EF7-3CEE-11E6-B535-001BDC06AB3B")]
    [NativeTypeName("struct IRadialControllerConfiguration2 : IInspectable")]
    public unsafe partial struct IRadialControllerConfiguration2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, uint>)(lpVtbl[1]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, uint>)(lpVtbl[2]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, IntPtr*, int>)(lpVtbl[4]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController *")] IRadialController* value)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, IRadialController*, int>)(lpVtbl[6]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActiveControllerWhenMenuIsSuppressed([NativeTypeName("ABI::Windows::UI::Input::IRadialController **")] IRadialController** value)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, IRadialController**, int>)(lpVtbl[7]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IsMenuSuppressed([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, byte, int>)(lpVtbl[8]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsMenuSuppressed([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IRadialControllerConfiguration2*, byte*, int>)(lpVtbl[9]))((IRadialControllerConfiguration2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
