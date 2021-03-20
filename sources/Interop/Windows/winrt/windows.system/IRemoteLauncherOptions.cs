// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9E3A2788-2891-4CDF-A2D6-9DFF7D02E693")]
    [NativeTypeName("struct IRemoteLauncherOptions : IInspectable")]
    public unsafe partial struct IRemoteLauncherOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, uint>)(lpVtbl[1]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, uint>)(lpVtbl[2]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, IntPtr*, int>)(lpVtbl[4]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** value)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, IUriRuntimeClass**, int>)(lpVtbl[6]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FallbackUri([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* value)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, IUriRuntimeClass*, int>)(lpVtbl[7]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PreferredAppIds([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IRemoteLauncherOptions*, IVector<IntPtr>**, int>)(lpVtbl[8]))((IRemoteLauncherOptions*)Unsafe.AsPointer(ref this), value);
        }
    }
}
