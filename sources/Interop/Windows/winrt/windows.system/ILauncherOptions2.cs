// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3BA08EB4-6E40-4DCE-A1A3-2F53950AFB49")]
    [NativeTypeName("struct ILauncherOptions2 : IInspectable")]
    public unsafe partial struct ILauncherOptions2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherOptions2*, uint>)(lpVtbl[1]))((ILauncherOptions2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherOptions2*, uint>)(lpVtbl[2]))((ILauncherOptions2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, IntPtr*, int>)(lpVtbl[4]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_TargetApplicationPackageFamilyName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, IntPtr*, int>)(lpVtbl[6]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_TargetApplicationPackageFamilyName([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, IntPtr, int>)(lpVtbl[7]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IInspectable** value)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, IInspectable**, int>)(lpVtbl[8]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_NeighboringFilesQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult *")] IInspectable* value)
        {
            return ((delegate* unmanaged<ILauncherOptions2*, IInspectable*, int>)(lpVtbl[9]))((ILauncherOptions2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
