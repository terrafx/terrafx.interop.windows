// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2566E74E-B05D-40C2-9DC1-1A4F039EA120")]
    [NativeTypeName("struct IAppResourceGroupBackgroundTaskReport : IInspectable")]
    public unsafe partial struct IAppResourceGroupBackgroundTaskReport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, uint>)(lpVtbl[1]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, uint>)(lpVtbl[2]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TaskId([NativeTypeName("GUID *")] Guid* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, Guid*, int>)(lpVtbl[6]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, IntPtr*, int>)(lpVtbl[7]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Trigger([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, IntPtr*, int>)(lpVtbl[8]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EntryPoint([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppResourceGroupBackgroundTaskReport*, IntPtr*, int>)(lpVtbl[9]))((IAppResourceGroupBackgroundTaskReport*)Unsafe.AsPointer(ref this), value);
        }
    }
}
