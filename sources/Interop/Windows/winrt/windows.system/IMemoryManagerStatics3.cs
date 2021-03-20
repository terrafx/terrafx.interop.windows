// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("149B59CE-92AD-4E35-89EB-50DFB4C0D91C")]
    [NativeTypeName("struct IMemoryManagerStatics3 : IInspectable")]
    public unsafe partial struct IMemoryManagerStatics3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, uint>)(lpVtbl[1]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, uint>)(lpVtbl[2]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, IntPtr*, int>)(lpVtbl[4]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TrySetAppMemoryUsageLimit([NativeTypeName("UINT64")] ulong value, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics3*, ulong, byte*, int>)(lpVtbl[6]))((IMemoryManagerStatics3*)Unsafe.AsPointer(ref this), value, result);
        }
    }
}
