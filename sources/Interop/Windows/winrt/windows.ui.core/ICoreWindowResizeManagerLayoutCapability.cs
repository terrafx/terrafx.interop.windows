// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB74F27B-A544-4301-80E6-0AE033EF4536")]
    [NativeTypeName("struct ICoreWindowResizeManagerLayoutCapability : IInspectable")]
    public unsafe partial struct ICoreWindowResizeManagerLayoutCapability
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, uint>)(lpVtbl[1]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, uint>)(lpVtbl[2]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, IntPtr*, int>)(lpVtbl[4]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ShouldWaitForLayoutCompletion([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, byte, int>)(lpVtbl[6]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ShouldWaitForLayoutCompletion([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ICoreWindowResizeManagerLayoutCapability*, byte*, int>)(lpVtbl[7]))((ICoreWindowResizeManagerLayoutCapability*)Unsafe.AsPointer(ref this), value);
        }
    }
}
