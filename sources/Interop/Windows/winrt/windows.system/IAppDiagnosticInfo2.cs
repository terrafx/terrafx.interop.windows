// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF46FBD7-191A-446C-9473-8FBC2374A354")]
    [NativeTypeName("struct IAppDiagnosticInfo2 : IInspectable")]
    public unsafe partial struct IAppDiagnosticInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, uint>)(lpVtbl[1]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, uint>)(lpVtbl[2]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, uint*, Guid**, int>)(lpVtbl[3]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, IntPtr*, int>)(lpVtbl[4]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, TrustLevel*, int>)(lpVtbl[5]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceGroups([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CSystem__CAppResourceGroupInfo_t **")] IVector<IntPtr>** result)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResourceGroupWatcher([NativeTypeName("ABI::Windows::System::IAppResourceGroupInfoWatcher **")] IAppResourceGroupInfoWatcher** result)
        {
            return ((delegate* unmanaged<IAppDiagnosticInfo2*, IAppResourceGroupInfoWatcher**, int>)(lpVtbl[7]))((IAppDiagnosticInfo2*)Unsafe.AsPointer(ref this), result);
        }
    }
}
