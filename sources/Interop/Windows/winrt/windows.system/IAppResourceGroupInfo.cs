// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B913F77A-E807-49F4-845E-7B8BDCFE8EE7")]
    [NativeTypeName("struct IAppResourceGroupInfo : IInspectable")]
    public unsafe partial struct IAppResourceGroupInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, uint>)(lpVtbl[1]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, uint>)(lpVtbl[2]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_InstanceId([NativeTypeName("GUID *")] Guid* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, Guid*, int>)(lpVtbl[6]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsShared([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, byte*, int>)(lpVtbl[7]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBackgroundTaskReports([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupBackgroundTaskReport_t **")] IVector<IntPtr>** result)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMemoryReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupMemoryReport **")] IAppResourceGroupMemoryReport** result)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, IAppResourceGroupMemoryReport**, int>)(lpVtbl[9]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProcessDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CDiagnostics__CProcessDiagnosticInfo_t **")] IVector<IntPtr>** result)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, IVector<IntPtr>**, int>)(lpVtbl[10]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStateReport([NativeTypeName("ABI::Windows::System::IAppResourceGroupStateReport **")] IAppResourceGroupStateReport** result)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfo*, IAppResourceGroupStateReport**, int>)(lpVtbl[11]))((IAppResourceGroupInfo*)Unsafe.AsPointer(ref this), result);
        }
    }
}
