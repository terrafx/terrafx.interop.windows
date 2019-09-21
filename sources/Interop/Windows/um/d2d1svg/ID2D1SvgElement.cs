// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Interface for all SVG elements.</summary>
    [Guid("AC7B67A6-183E-49C1-A823-0EBE40B0DB29")]
    public unsafe struct ID2D1SvgElement
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgElement* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgElement* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgElement* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region Delegates
        /// <summary>Gets the document that contains this element. Returns null if the element has been removed from the tree.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDocument(
            [In] ID2D1SvgElement* This,
            [Out] ID2D1SvgDocument** document
        );

        /// <summary>Gets the tag name.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTagName(
            [In] ID2D1SvgElement* This,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        );

        /// <summary>Gets the string length of the tag name. The returned string length does not include room for the null terminator.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetTagNameLength(
            [In] ID2D1SvgElement* This
        );

        /// <summary>Returns TRUE if this element represents text content, e.g. the content of a 'title' or 'desc' element. Text content does not have a tag name.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsTextContent(
            [In] ID2D1SvgElement* This
        );

        /// <summary>Gets the parent element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetParent(
            [In] ID2D1SvgElement* This,
            [Out] ID2D1SvgElement** parent
        );

        /// <summary>Returns whether this element has children.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _HasChildren(
            [In] ID2D1SvgElement* This
        );

        /// <summary>Gets the first child of this element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFirstChild(
            [In] ID2D1SvgElement* This,
            [Out] ID2D1SvgElement** child
        );

        /// <summary>Gets the last child of this element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetLastChild(
            [In] ID2D1SvgElement* This,
            [Out] ID2D1SvgElement** child
        );

        /// <summary>Gets the previous sibling of the referenceChild element.</summary>
        /// <param name="referenceChild">The referenceChild must be an immediate child of this element.</param>
        /// <param name="previousChild">The output previousChild element will be non-null if the referenceChild has a previous sibling. If the referenceChild is the first child, the output is null.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetPreviousChild(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* referenceChild,
            [Out] ID2D1SvgElement** previousChild
        );

        /// <summary>Gets the next sibling of the referenceChild element.</summary>
        /// <param name="referenceChild">The referenceChild must be an immediate child of this element.</param>
        /// <param name="nextChild">The output nextChild element will be non-null if the referenceChild has a next sibling. If the referenceChild is the last child, the output is null.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetNextChild(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* referenceChild,
            [Out] ID2D1SvgElement** nextChild
        );

        /// <summary>Inserts newChild as a child of this element, before the referenceChild element. If the newChild element already has a parent, it is removed from this parent as part of the insertion. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be inserted.</param>
        /// <param name="referenceChild">The element that the child should be inserted before. If referenceChild is null, the newChild is placed as the last child. If referenceChild is non-null, it must be an immediate child of this element.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _InsertChildBefore(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* newChild,
            [In] ID2D1SvgElement* referenceChild = null
        );

        /// <summary>Appends newChild to the list of children. If the newChild element already has a parent, it is removed from this parent as part of the append operation. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be appended.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AppendChild(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* newChild
        );

        /// <summary>Replaces the oldChild element with the newChild. This operation removes the oldChild from the tree. If the newChild element already has a parent, it is removed from this parent as part of the replace operation. Returns an error if this element cannot accept children of the type of newChild. Returns an error if the newChild is an ancestor of this element.</summary>
        /// <param name="newChild">The element to be inserted.</param>
        /// <param name="oldChild">The child element to be replaced. The oldChild element must be an immediate child of this element.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ReplaceChild(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* newChild,
            [In] ID2D1SvgElement* oldChild
        );

        /// <summary>Removes the oldChild from the tree. Children of oldChild remain children of oldChild.</summary>
        /// <param name="oldChild">The child element to be removed. The oldChild element must be an immediate child of this element.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveChild(
            [In] ID2D1SvgElement* This,
            [In] ID2D1SvgElement* oldChild
        );

        /// <summary>Creates an element from a tag name. The element is appended to the list of children. Returns an error if this element cannot accept children of the specified type.</summary>
        /// <param name="tagName">The tag name of the new child. A NULL tagName or an empty string is interpreted to be a text content element.</param>
        /// <param name="newChild">The new child element.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateChild(
            [In] ID2D1SvgElement* This,
            [In, Optional, NativeTypeName("PCWSTR")] char* tagName,
            [Out] ID2D1SvgElement** newChild
        );

        /// <summary>Returns true if the attribute is explicitly set on the element or if it is present within an inline style. Returns FALSE if the attribute is not a valid attribute on this element.</summary>
        /// <param name="name">The name of the attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsAttributeSpecified(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        );

        /// <summary>Returns the number of specified attributes on this element. Attributes are only considered specified if they are explicitly set on the element or present within an inline style. Properties that receive their value through CSS inheritance are not considered specified. An attribute can become specified if it is set through a method call. It can become unspecified if it is removed via RemoveAttribute.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetSpecifiedAttributeCount(
            [In] ID2D1SvgElement* This
        );

        /// <summary>Gets the name of the specified attribute at the given index.</summary>
        /// <param name="index">The specified index of the attribute.</param>
        /// <param name="name">Outputs the name of the attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSpecifiedAttributeName(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        );

        /// <summary>Gets the string length of the name of the specified attribute at the given index. The output string length does not include room for the null terminator.</summary>
        /// <param name="index">The specified index of the attribute.</param>
        /// <param name="nameLength">Outputs the string length of the name of the specified attribute.</param>
        /// <param name="inherited">Outputs whether the attribute is set to the 'inherit' value.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSpecifiedAttributeNameLength(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        );

        /// <summary>Removes the attribute from this element. Also removes this attribute from within an inline style if present. Returns an error if the attribute name is not valid on this element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveAttribute(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name
        );

        /// <summary>Sets the value of a text content element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetTextValue(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("WCHAR[]")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        );

        /// <summary>Gets the value of a text content element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetTextValue(
            [In] ID2D1SvgElement* This,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        );

        /// <summary>Gets the length of the text content value. The returned string length does not include room for the null terminator.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetTextValueLength(
            [In] ID2D1SvgElement* This
        );

        /// <summary>Sets an attribute of this element using a string. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetAttributeValue(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [In, NativeTypeName("PCWSTR")] char* value
        );

        /// <summary>Gets an attribute of this element as a string. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified string type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAttributeValue(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [Out, NativeTypeName("PWSTR")] char* value,
            [In, NativeTypeName("UINT32")] uint valueCount
        );

        /// <summary>Gets the string length of an attribute of this element. The returned string length does not include room for the null terminator. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified string type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAttributeValueLength(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [Out, NativeTypeName("UINT32")] uint* valueLength
        );

        /// <summary>Sets an attribute of this element using a POD type. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetAttributeValue1(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_POD_TYPE type,
            [In] void* value,
            [In, NativeTypeName("UINT32")] uint valueSizeInBytes
        );

        /// <summary>Gets an attribute of this element as a POD type. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified POD type.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAttributeValue1(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_POD_TYPE type,
            [Out] void* value,
            [In, NativeTypeName("UINT32")] uint valueSizeInBytes
        );

        /// <summary>Sets an attribute of this element using an interface. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified interface type. Returns an error if the attribute object is already set on an element. A given attribute object may only be set on one element in one attribute location at a time.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetAttributeValue2(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] ID2D1SvgAttribute* value
        );

        /// <summary>Gets an attribute of this element as an interface type. Returns an error if the attribute is not specified. Returns an error if the attribute name is not valid on this element. Returns an error if the attribute cannot be expressed as the specified interface type.</summary>
        /// <param name="riid">The interface ID of the attribute value.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetAttributeValue2(
            [In] ID2D1SvgElement* This,
            [In, NativeTypeName("PCWSTR")] char* name,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** value
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region Methods
        public void GetDocument(
            [Out] ID2D1SvgDocument** document
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDocument>(lpVtbl->GetDocument)(
                    This,
                    document
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTagName(
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTagName>(lpVtbl->GetTagName)(
                    This,
                    name,
                    nameCount
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTagNameLength()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTagNameLength>(lpVtbl->GetTagNameLength)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsTextContent()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsTextContent>(lpVtbl->IsTextContent)(
                    This
                );
            }
        }

        public void GetParent(
            [Out] ID2D1SvgElement** parent
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    parent
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int HasChildren()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HasChildren>(lpVtbl->HasChildren)(
                    This
                );
            }
        }

        public void GetFirstChild(
            [Out] ID2D1SvgElement** child
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFirstChild>(lpVtbl->GetFirstChild)(
                    This,
                    child
                );
            }
        }

        public void GetLastChild(
            [Out] ID2D1SvgElement** child
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetLastChild>(lpVtbl->GetLastChild)(
                    This,
                    child
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreviousChild(
            [In] ID2D1SvgElement* referenceChild,
            [Out] ID2D1SvgElement** previousChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPreviousChild>(lpVtbl->GetPreviousChild)(
                    This,
                    referenceChild,
                    previousChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNextChild(
            [In] ID2D1SvgElement* referenceChild,
            [Out] ID2D1SvgElement** nextChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNextChild>(lpVtbl->GetNextChild)(
                    This,
                    referenceChild,
                    nextChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InsertChildBefore(
            [In] ID2D1SvgElement* newChild,
            [In] ID2D1SvgElement* referenceChild = null
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InsertChildBefore>(lpVtbl->InsertChildBefore)(
                    This,
                    newChild,
                    referenceChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AppendChild(
            [In] ID2D1SvgElement* newChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AppendChild>(lpVtbl->AppendChild)(
                    This,
                    newChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReplaceChild(
            [In] ID2D1SvgElement* newChild,
            [In] ID2D1SvgElement* oldChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReplaceChild>(lpVtbl->ReplaceChild)(
                    This,
                    newChild,
                    oldChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveChild(
            [In] ID2D1SvgElement* oldChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveChild>(lpVtbl->RemoveChild)(
                    This,
                    oldChild
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateChild(
            [In, Optional, NativeTypeName("PCWSTR")] char* tagName,
            [Out] ID2D1SvgElement** newChild
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateChild>(lpVtbl->CreateChild)(
                    This,
                    tagName,
                    newChild
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsAttributeSpecified(
            [In, NativeTypeName("PCWSTR")] char* name,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsAttributeSpecified>(lpVtbl->IsAttributeSpecified)(
                    This,
                    name,
                    inherited
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetSpecifiedAttributeCount()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeCount>(lpVtbl->GetSpecifiedAttributeCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeName(
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeName>(lpVtbl->GetSpecifiedAttributeName)(
                    This,
                    index,
                    name,
                    nameCount,
                    inherited
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecifiedAttributeNameLength(
            [In, NativeTypeName("UINT32")] uint index,
            [Out, NativeTypeName("UINT32")] uint* nameLength,
            [Out, NativeTypeName("BOOL")] int* inherited = null
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecifiedAttributeNameLength>(lpVtbl->GetSpecifiedAttributeNameLength)(
                    This,
                    index,
                    nameLength,
                    inherited
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveAttribute(
            [In, NativeTypeName("PCWSTR")] char* name
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RemoveAttribute>(lpVtbl->RemoveAttribute)(
                    This,
                    name
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextValue(
            [In, NativeTypeName("WCHAR[]")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetTextValue>(lpVtbl->SetTextValue)(
                    This,
                    name,
                    nameCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTextValue(
            [Out, NativeTypeName("PWSTR")] char* name,
            [In, NativeTypeName("UINT32")] uint nameCount
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextValue>(lpVtbl->GetTextValue)(
                    This,
                    name,
                    nameCount
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetTextValueLength()
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetTextValueLength>(lpVtbl->GetTextValueLength)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [In, NativeTypeName("PCWSTR")] char* value
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue>(lpVtbl->SetAttributeValue)(
                    This,
                    name,
                    type,
                    value
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [Out, NativeTypeName("PWSTR")] char* value,
            [In, NativeTypeName("UINT32")] uint valueCount
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue>(lpVtbl->GetAttributeValue)(
                    This,
                    name,
                    type,
                    value,
                    valueCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValueLength(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_STRING_TYPE type,
            [Out, NativeTypeName("UINT32")] uint* valueLength
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValueLength>(lpVtbl->GetAttributeValueLength)(
                    This,
                    name,
                    type,
                    valueLength
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue1(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_POD_TYPE type,
            [In] void* value,
            [In, NativeTypeName("UINT32")] uint valueSizeInBytes
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue1>(lpVtbl->SetAttributeValue1)(
                    This,
                    name,
                    type,
                    value,
                    valueSizeInBytes
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue1(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] D2D1_SVG_ATTRIBUTE_POD_TYPE type,
            [Out] void* value,
            [In, NativeTypeName("UINT32")] uint valueSizeInBytes
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue1>(lpVtbl->GetAttributeValue1)(
                    This,
                    name,
                    type,
                    value,
                    valueSizeInBytes
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue2(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In] ID2D1SvgAttribute* value
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetAttributeValue2>(lpVtbl->SetAttributeValue2)(
                    This,
                    name,
                    value
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue2(
            [In, NativeTypeName("PCWSTR")] char* name,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** value
        )
        {
            fixed (ID2D1SvgElement* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAttributeValue2>(lpVtbl->GetAttributeValue2)(
                    This,
                    name,
                    riid,
                    value
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region Fields
            public IntPtr GetDocument;

            public IntPtr GetTagName;

            public IntPtr GetTagNameLength;

            public IntPtr IsTextContent;

            public IntPtr GetParent;

            public IntPtr HasChildren;

            public IntPtr GetFirstChild;

            public IntPtr GetLastChild;

            public IntPtr GetPreviousChild;

            public IntPtr GetNextChild;

            public IntPtr InsertChildBefore;

            public IntPtr AppendChild;

            public IntPtr ReplaceChild;

            public IntPtr RemoveChild;

            public IntPtr CreateChild;

            public IntPtr IsAttributeSpecified;

            public IntPtr GetSpecifiedAttributeCount;

            public IntPtr GetSpecifiedAttributeName;

            public IntPtr GetSpecifiedAttributeNameLength;

            public IntPtr RemoveAttribute;

            public IntPtr SetTextValue;

            public IntPtr GetTextValue;

            public IntPtr GetTextValueLength;

            public IntPtr SetAttributeValue;

            public IntPtr GetAttributeValue;

            public IntPtr GetAttributeValueLength;

            public IntPtr SetAttributeValue1;

            public IntPtr GetAttributeValue1;

            public IntPtr SetAttributeValue2;

            public IntPtr GetAttributeValue2;
            #endregion
        }
        #endregion
    }
}
