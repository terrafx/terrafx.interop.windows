// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E348A69A-8889-4CA3-BE07-D5FFFF5F0804")]
    [NativeTypeName("struct IAppDiagnosticInfo : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, uint>)(lpVtbl[1]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, uint>)(lpVtbl[2]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AppInfo([NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IInspectable** value)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo*, IInspectable**, int>)(lpVtbl[6]))((IAppDiagnosticInfo*)Unsafe.AsPointer(ref this), value);
        }
    }
}
