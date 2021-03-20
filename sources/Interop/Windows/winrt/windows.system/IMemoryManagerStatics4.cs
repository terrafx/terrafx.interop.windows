// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C5A94828-E84E-4886-8A0D-44B3190E3B72")]
    [NativeTypeName("struct IMemoryManagerStatics4 : IInspectable")]
    public unsafe partial struct IMemoryManagerStatics4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, Guid*, void**, int>)(lpVtbl[0]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, uint>)(lpVtbl[1]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, uint>)(lpVtbl[2]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, uint*, Guid**, int>)(lpVtbl[3]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, IntPtr*, int>)(lpVtbl[4]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, TrustLevel*, int>)(lpVtbl[5]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ExpectedAppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IMemoryManagerStatics4*, ulong*, int>)(lpVtbl[6]))((IMemoryManagerStatics4*)Unsafe.AsPointer(ref this), value);
        }
    }
}
