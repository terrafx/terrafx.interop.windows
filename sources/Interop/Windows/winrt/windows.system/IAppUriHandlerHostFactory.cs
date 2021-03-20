// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("257C3C96-CE04-5F98-96BB-3EBD3E9275BB")]
    [NativeTypeName("struct IAppUriHandlerHostFactory : IInspectable")]
    public unsafe partial struct IAppUriHandlerHostFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, uint>)(lpVtbl[1]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, uint>)(lpVtbl[2]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, IntPtr*, int>)(lpVtbl[4]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, TrustLevel*, int>)(lpVtbl[5]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::System::IAppUriHandlerHost **")] IAppUriHandlerHost** value)
        {
            return ((delegate* unmanaged<IAppUriHandlerHostFactory*, IntPtr, IAppUriHandlerHost**, int>)(lpVtbl[6]))((IAppUriHandlerHostFactory*)Unsafe.AsPointer(ref this), name, value);
        }
    }
}
