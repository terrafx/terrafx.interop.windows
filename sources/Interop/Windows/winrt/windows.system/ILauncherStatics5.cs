// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B24EF84-D895-5FEA-9153-1AC49AED9BA9")]
    [NativeTypeName("struct ILauncherStatics5 : IInspectable")]
    public unsafe partial struct ILauncherStatics5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherStatics5*, uint>)(lpVtbl[1]))((ILauncherStatics5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherStatics5*, uint>)(lpVtbl[2]))((ILauncherStatics5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, IntPtr*, int>)(lpVtbl[4]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderPathAsync([NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, IntPtr, IAsyncOperation<byte>**, int>)(lpVtbl[6]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), path, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderPathWithOptionsAsync([NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, IntPtr, IFolderLauncherOptions*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), path, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderPathForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, IUser*, IntPtr, IAsyncOperation<byte>**, int>)(lpVtbl[8]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), user, path, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFolderPathWithOptionsForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")] IFolderLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics5*, IUser*, IntPtr, IFolderLauncherOptions*, IAsyncOperation<byte>**, int>)(lpVtbl[9]))((ILauncherStatics5*)Unsafe.AsPointer(ref this), user, path, options, operation);
        }
    }
}
