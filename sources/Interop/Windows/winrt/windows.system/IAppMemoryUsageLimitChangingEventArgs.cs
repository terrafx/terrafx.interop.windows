// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79F86664-FECA-4DA5-9E40-2BC63EFDC979")]
    [NativeTypeName("struct IAppMemoryUsageLimitChangingEventArgs : IInspectable")]
    public unsafe partial struct IAppMemoryUsageLimitChangingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, uint>)(lpVtbl[1]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, uint>)(lpVtbl[2]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_OldLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, ulong*, int>)(lpVtbl[6]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NewLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryUsageLimitChangingEventArgs*, ulong*, int>)(lpVtbl[7]))((IAppMemoryUsageLimitChangingEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
