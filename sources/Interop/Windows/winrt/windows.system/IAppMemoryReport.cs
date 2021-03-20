// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D65339B-4D6F-45BC-9C5E-E49B3FF2758D")]
    [NativeTypeName("struct IAppMemoryReport : IInspectable")]
    public unsafe partial struct IAppMemoryReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppMemoryReport*, uint>)(lpVtbl[1]))((IAppMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppMemoryReport*, uint>)(lpVtbl[2]))((IAppMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, IntPtr*, int>)(lpVtbl[4]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, ulong*, int>)(lpVtbl[6]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PeakPrivateCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, ulong*, int>)(lpVtbl[7]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalCommitUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, ulong*, int>)(lpVtbl[8]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalCommitLimit([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IAppMemoryReport*, ulong*, int>)(lpVtbl[9]))((IAppMemoryReport*)Unsafe.AsPointer(ref this), value);
        }
    }
}
