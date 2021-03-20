// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAFA21D8-B071-4CD8-853E-341203E557D3")]
    [NativeTypeName("struct ILauncherOptions : IInspectable")]
    public unsafe partial struct ILauncherOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherOptions*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherOptions*, uint>)(lpVtbl[1]))((ILauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherOptions*, uint>)(lpVtbl[2]))((ILauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherOptions*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr*, int>)(lpVtbl[4]))((ILauncherOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherOptions*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TreatAsUntrusted([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, byte*, int>)(lpVtbl[6]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TreatAsUntrusted([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, byte, int>)(lpVtbl[7]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayApplicationPicker([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, byte*, int>)(lpVtbl[8]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DisplayApplicationPicker([NativeTypeName("boolean")] byte value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, byte, int>)(lpVtbl[9]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UI([NativeTypeName("ABI::Windows::System::ILauncherUIOptions **")] ILauncherUIOptions** value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, ILauncherUIOptions**, int>)(lpVtbl[10]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PreferredApplicationPackageFamilyName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr*, int>)(lpVtbl[11]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PreferredApplicationPackageFamilyName([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr, int>)(lpVtbl[12]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PreferredApplicationDisplayName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr*, int>)(lpVtbl[13]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_PreferredApplicationDisplayName([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr, int>)(lpVtbl[14]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IUriRuntimeClass**, int>)(lpVtbl[15]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IUriRuntimeClass*, int>)(lpVtbl[16]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContentType([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr*, int>)(lpVtbl[17]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ContentType([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ILauncherOptions*, IntPtr, int>)(lpVtbl[18]))((ILauncherOptions*)Unsafe.AsPointer(ref this), value);
        }
    }
}
