// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C8C06B1-7DB1-4C51-A225-7FAE2D49E431")]
    [NativeTypeName("struct IAppResourceGroupMemoryReport : IInspectable")]
    public unsafe partial struct IAppResourceGroupMemoryReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, uint>)(lpVtbl[1]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, uint>)(lpVtbl[2]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CommitUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[6]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CommitUsageLevel([NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, AppMemoryUsageLevel*, int>)(lpVtbl[7]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[8]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupMemoryReport*, ulong*, int>)(lpVtbl[9]))((IAppResourceGroupMemoryReport*)Unsafe.AsPointer(ref this), value);
        }
    }
}
