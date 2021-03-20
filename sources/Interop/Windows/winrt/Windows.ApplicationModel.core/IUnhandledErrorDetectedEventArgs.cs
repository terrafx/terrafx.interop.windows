// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("679AB78B-B336-4822-AC40-0D750F0B7A2B")]
    [NativeTypeName("struct IUnhandledErrorDetectedEventArgs : IInspectable")]
    public unsafe partial struct IUnhandledErrorDetectedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, uint>)(lpVtbl[1]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, uint>)(lpVtbl[2]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UnhandledError([NativeTypeName("ABI::Windows::ApplicationModel::Core::IUnhandledError **")] IUnhandledError** value)
        {
            return ((delegate* unmanaged<IUnhandledErrorDetectedEventArgs*, IUnhandledError**, int>)(lpVtbl[6]))((IUnhandledErrorDetectedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
