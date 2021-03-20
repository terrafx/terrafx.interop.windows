// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5D50CAC5-92D2-5409-B56F-7F73E10EA4C3")]
    [NativeTypeName("struct IAppUriHandlerHost : IInspectable")]
    public unsafe partial struct IAppUriHandlerHost
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, uint>)(lpVtbl[1]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, uint>)(lpVtbl[2]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, IntPtr*, int>)(lpVtbl[4]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, IntPtr*, int>)(lpVtbl[6]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Name([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IAppUriHandlerHost*, IntPtr, int>)(lpVtbl[7]))((IAppUriHandlerHost*)Unsafe.AsPointer(ref this), value);
        }
    }
}
