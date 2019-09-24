// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
    public unsafe struct ID2D1SvgDocument
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1SvgDocument* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1SvgDocument* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1SvgDocument* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1SvgDocument* This, ID2D1Factory** factory);

        /// <summary>Sets the size of the initial viewport.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetViewportSize(ID2D1SvgDocument* This, [NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize);

        /// <summary>Returns the size of the initial viewport.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public delegate D2D_SIZE_F* _GetViewportSize(ID2D1SvgDocument* This, D2D_SIZE_F* _result);

        /// <summary>Sets the root element of the document. The root element must be an 'svg' element. If the element already exists within an svg tree, it is first removed.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetRoot(ID2D1SvgDocument* This, ID2D1SvgElement* root = null);

        /// <summary>Gets the root element of the document.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetRoot(ID2D1SvgDocument* This, ID2D1SvgElement** root);

        /// <summary>Gets the SVG element with the specified ID. If the element cannot be found, the returned element will be null.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindElementById(ID2D1SvgDocument* This, [NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgElement** svgElement);

        /// <summary>Serializes an element and its subtree to XML. The output XML is encoded as UTF-8.</summary>
        /// <param name="outputXmlStream">An output stream to contain the SVG XML subtree.</param>
        /// <param name="subtree">The root of the subtree. If null, the entire document is serialized.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Serialize(ID2D1SvgDocument* This, IStream* outputXmlStream, ID2D1SvgElement* subtree = null);

        /// <summary>Deserializes a subtree from the stream. The stream must have only one root element, but that root element need not be an 'svg' element. The output element is not inserted into this document tree.</summary>
        /// <param name="inputXmlStream">An input stream containing the SVG XML subtree.</param>
        /// <param name="subtree">The root of the subtree.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Deserialize(ID2D1SvgDocument* This, IStream* inputXmlStream, ID2D1SvgElement** subtree);

        /// <summary>Creates a paint object which can be used to set the 'fill' or 'stroke' properties.</summary>
        /// <param name="color">The color used if the paintType is D2D1_SVG_PAINT_TYPE_COLOR.</param>
        /// <param name="id">The element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePaint(ID2D1SvgDocument* This, D2D1_SVG_PAINT_TYPE paintType, [Optional, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional, NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgPaint** paint);

        /// <summary>Creates a dash array object which can be used to set the 'stroke-dasharray' property.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStrokeDashArray(ID2D1SvgDocument* This, [Optional, NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray);

        /// <summary>Creates a points object which can be used to set a 'points' attribute on a 'polygon' or 'polyline' element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePointCollection(ID2D1SvgDocument* This, [Optional, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, ID2D1SvgPointCollection** pointCollection);

        /// <summary>Creates a path data object which can be used to set a 'd' attribute on a 'path' element.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePathData(ID2D1SvgDocument* This, [Optional, NativeTypeName("FLOAT[]")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [Optional, NativeTypeName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, ID2D1SvgPathData** pathData);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetViewportSize>(lpVtbl->SetViewportSize)(This, viewportSize);
            }
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetViewportSize()
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                D2D_SIZE_F result;
                return *Marshal.GetDelegateForFunctionPointer<_GetViewportSize>(lpVtbl->GetViewportSize)(This, &result);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetRoot(ID2D1SvgElement* root = null)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetRoot>(lpVtbl->SetRoot)(This, root);
            }
        }

        public void GetRoot(ID2D1SvgElement** root)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetRoot>(lpVtbl->GetRoot)(This, root);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindElementById([NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgElement** svgElement)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindElementById>(lpVtbl->FindElementById)(This, id, svgElement);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Serialize(IStream* outputXmlStream, ID2D1SvgElement* subtree = null)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Serialize>(lpVtbl->Serialize)(This, outputXmlStream, subtree);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Deserialize(IStream* inputXmlStream, ID2D1SvgElement** subtree)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Deserialize>(lpVtbl->Deserialize)(This, inputXmlStream, subtree);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [Optional, NativeTypeName("D2D1_COLOR_F")] DXGI_RGBA* color, [Optional, NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgPaint** paint)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePaint>(lpVtbl->CreatePaint)(This, paintType, color, id, paint);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokeDashArray([Optional, NativeTypeName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStrokeDashArray>(lpVtbl->CreateStrokeDashArray)(This, dashes, dashesCount, strokeDashArray);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePointCollection([Optional, NativeTypeName("D2D1_POINT_2F[]")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, ID2D1SvgPointCollection** pointCollection)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePointCollection>(lpVtbl->CreatePointCollection)(This, points, pointsCount, pointCollection);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePathData([Optional, NativeTypeName("FLOAT[]")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [Optional, NativeTypeName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, ID2D1SvgPathData** pathData)
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePathData>(lpVtbl->CreatePathData)(This, segmentData, segmentDataCount, commands, commandsCount, pathData);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr SetViewportSize;

            public IntPtr GetViewportSize;

            public IntPtr SetRoot;

            public IntPtr GetRoot;

            public IntPtr FindElementById;

            public IntPtr Serialize;

            public IntPtr Deserialize;

            public IntPtr CreatePaint;

            public IntPtr CreateStrokeDashArray;

            public IntPtr CreatePointCollection;

            public IntPtr CreatePathData;
        }
    }
}
