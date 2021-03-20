// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("555C0DB8-39A8-49FA-B4F6-A2C7FC2842EC")]
    [NativeTypeName("struct ITimeZoneSettingsStatics2 : IInspectable")]
    public unsafe partial struct ITimeZoneSettingsStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, Guid*, void**, int>)(lpVtbl[0]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, uint>)(lpVtbl[1]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, uint>)(lpVtbl[2]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, IntPtr*, int>)(lpVtbl[4]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, TrustLevel*, int>)(lpVtbl[5]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AutoUpdateTimeZoneAsync([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CAutoUpdateTimeZoneStatus_t **")] IAsyncOperation<AutoUpdateTimeZoneStatus>** operation)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics2*, TimeSpan, IAsyncOperation<AutoUpdateTimeZoneStatus>**, int>)(lpVtbl[6]))((ITimeZoneSettingsStatics2*)Unsafe.AsPointer(ref this), timeout, operation);
        }
    }
}
