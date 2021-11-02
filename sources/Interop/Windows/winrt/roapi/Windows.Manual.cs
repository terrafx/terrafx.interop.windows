// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/roapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static HRESULT ActivateInstance<T>(HSTRING activatableClassId, T** instance) 
            where T : unmanaged
        {
            *instance = null;
            
            IInspectable* pInspectable;
            HRESULT hr = RoActivateInstance(activatableClassId, &pInspectable);
            if (SUCCEEDED(hr))
            {
                if (__uuidof<T>() == IID_IInspectable)
                {
                    *instance = (T*) pInspectable;
                }
                else
                {
                    hr = pInspectable->QueryInterface(__uuidof<T>(), (void**) instance);
                    _ = pInspectable->Release();
                }
            }
            
            return hr;
        }
        
        public static HRESULT GetActivationFactory<T>(HSTRING activatableClassId, T** factory)
            where T : unmanaged
        {
            return RoGetActivationFactory(activatableClassId, __uuidof<T>(), (void**) factory);
        }
    }
}
