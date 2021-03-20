// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7A787637-6302-4D2F-BF89-1C12D0B2A6B9")]
    [NativeTypeName("struct IAppResourceGroupInfoWatcherEventArgs : IInspectable")]
    public unsafe partial struct IAppResourceGroupInfoWatcherEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, uint>)(lpVtbl[1]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, uint>)(lpVtbl[2]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppDiagnosticInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSystem__CAppDiagnosticInfo_t **")] IVectorView<IntPtr>** value)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppResourceGroupInfo([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfo **")] IAppResourceGroupInfo** value)
        {
            return ((delegate* unmanaged<IAppResourceGroupInfoWatcherEventArgs*, IAppResourceGroupInfo**, int>)(lpVtbl[7]))((IAppResourceGroupInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
