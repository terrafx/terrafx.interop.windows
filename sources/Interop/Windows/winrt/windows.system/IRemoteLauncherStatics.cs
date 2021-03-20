// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D7DB7A93-A30C-48B7-9F21-051026A4E517")]
    [NativeTypeName("struct IRemoteLauncherStatics : IInspectable")]
    public unsafe partial struct IRemoteLauncherStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, Guid*, void**, int>)(lpVtbl[0]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, uint>)(lpVtbl[1]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, uint>)(lpVtbl[2]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, IntPtr*, int>)(lpVtbl[4]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, TrustLevel*, int>)(lpVtbl[5]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IInspectable* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, IInspectable*, IUriRuntimeClass*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[6]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithOptionsAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IInspectable* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, IInspectable*, IUriRuntimeClass*, IRemoteLauncherOptions*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[7]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LaunchUriWithDataAsync([NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")] IInspectable* remoteSystemConnectionRequest, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")] IRemoteLauncherOptions* options, [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* inputData, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **")] IAsyncOperation<RemoteLaunchUriStatus>** operation)
        {
            return ((delegate* unmanaged<IRemoteLauncherStatics*, IInspectable*, IUriRuntimeClass*, IRemoteLauncherOptions*, IPropertySet*, IAsyncOperation<RemoteLaunchUriStatus>**, int>)(lpVtbl[8]))((IRemoteLauncherStatics*)Unsafe.AsPointer(ref this), remoteSystemConnectionRequest, uri, options, inputData, operation);
        }
    }
}
