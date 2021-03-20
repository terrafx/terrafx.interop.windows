// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("087305A8-9B70-4782-8741-3A982B6CE5E4")]
    [NativeTypeName("struct IProcessMemoryReport : IInspectable")]
    public unsafe partial struct IProcessMemoryReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, Guid*, void**, int>)(lpVtbl[0]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, uint>)(lpVtbl[1]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, uint>)(lpVtbl[2]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, uint*, Guid**, int>)(lpVtbl[3]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, IntPtr*, int>)(lpVtbl[4]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, TrustLevel*, int>)(lpVtbl[5]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PrivateWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, ulong*, int>)(lpVtbl[6]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TotalWorkingSetUsage([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IProcessMemoryReport*, ulong*, int>)(lpVtbl[7]))((IProcessMemoryReport*)Unsafe.AsPointer(ref this), value);
        }
    }
}
