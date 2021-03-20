// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B3B2BEA-A101-41AE-9FBD-028728BAB73D")]
    [NativeTypeName("struct ITimeZoneSettingsStatics : IInspectable")]
    public unsafe partial struct ITimeZoneSettingsStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, Guid*, void**, int>)(lpVtbl[0]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, uint>)(lpVtbl[1]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, uint>)(lpVtbl[2]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, IntPtr*, int>)(lpVtbl[4]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, TrustLevel*, int>)(lpVtbl[5]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CurrentTimeZoneDisplayName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, IntPtr*, int>)(lpVtbl[6]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SupportedTimeZoneDisplayNames([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")] IVectorView<IntPtr>** value)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, IVectorView<IntPtr>**, int>)(lpVtbl[7]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CanChangeTimeZone([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, byte*, int>)(lpVtbl[8]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeTimeZoneByDisplayName([NativeTypeName("HSTRING")] IntPtr timeZoneDisplayName)
        {
            return ((delegate* unmanaged<ITimeZoneSettingsStatics*, IntPtr, int>)(lpVtbl[9]))((ITimeZoneSettingsStatics*)Unsafe.AsPointer(ref this), timeZoneDisplayName);
        }
    }
}
