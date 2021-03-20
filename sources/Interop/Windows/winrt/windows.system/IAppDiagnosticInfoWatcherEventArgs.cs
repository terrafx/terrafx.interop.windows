// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7017C716-E1DA-4C65-99DF-046DFF5BE71A")]
    [NativeTypeName("struct IAppDiagnosticInfoWatcherEventArgs : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfoWatcherEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, uint>)(lpVtbl[1]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, uint>)(lpVtbl[2]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppDiagnosticInfo([NativeTypeName("ABI::Windows::System::IAppDiagnosticInfo **")] IAppDiagnosticInfo** value)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfoWatcherEventArgs*, IAppDiagnosticInfo**, int>)(lpVtbl[6]))((IAppDiagnosticInfoWatcherEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
