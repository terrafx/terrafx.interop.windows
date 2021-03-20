// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("277151C3-9E3E-42F6-91A4-5DFDEB232451")]
    [NativeTypeName("struct ILauncherStatics : IInspectable")]
    public unsafe partial struct ILauncherStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ILauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((ILauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILauncherStatics*, uint>)(lpVtbl[1]))((ILauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILauncherStatics*, uint>)(lpVtbl[2]))((ILauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ILauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ILauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ILauncherStatics*, IntPtr*, int>)(lpVtbl[4]))((ILauncherStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ILauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((ILauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IInspectable* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics*, IInspectable*, IAsyncOperation<byte>**, int>)(lpVtbl[6]))((ILauncherStatics*)Unsafe.AsPointer(ref this), file, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchFileWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IInspectable* file, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics*, IInspectable*, ILauncherOptions*, IAsyncOperation<byte>**, int>)(lpVtbl[7]))((ILauncherStatics*)Unsafe.AsPointer(ref this), file, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics*, IUriRuntimeClass*, IAsyncOperation<byte>**, int>)(lpVtbl[8]))((ILauncherStatics*)Unsafe.AsPointer(ref this), uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithOptionsAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")] IAsyncOperation<byte>** operation)
        {
            return ((delegate* unmanaged<ILauncherStatics*, IUriRuntimeClass*, ILauncherOptions*, IAsyncOperation<byte>**, int>)(lpVtbl[9]))((ILauncherStatics*)Unsafe.AsPointer(ref this), uri, options, operation);
        }
    }
}
