// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("234261A8-9DB3-4683-AA42-DC6F51D33847")]
    [NativeTypeName("struct ILauncherStatics3 : IInspectable")]
    public unsafe partial struct ILauncherStatics3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherStatics3*, uint>)(lpVtbl[1]))((ILauncherStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherStatics3*, uint>)(lpVtbl[2]))((ILauncherStatics3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, IntPtr*, int>)(lpVtbl[4]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IInspectable* folder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, IInspectable*, IAsyncOperation<byte>**, int>)(lpVtbl[6]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), folder, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IInspectable* folder, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics3*, IInspectable*, IFolderLauncherOptions*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((ILauncherStatics3*)Unsafe.AsPointer(ref this), folder, options, operation);
        }
    }
}
