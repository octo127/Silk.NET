// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFactory2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFactory2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFactory2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollection* fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollectionPtr, checkForUpdates);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* collectionKeyPtr = &collectionKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* collectionKeyPtr = &collectionKey)
        {
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollection);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
        {
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollectionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
        {
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollection);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
        {
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filePathPtr = &filePath)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filePathPtr = &filePath)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filePathPtr = &filePath)
        {
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* filePathPtr = &filePath)
        {
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
        SilkMarshal.Free((nint)filePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
        }
        SilkMarshal.Free((nint)filePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
        }
        SilkMarshal.Free((nint)filePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
            }
        }
        SilkMarshal.Free((nint)filePathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
        {
            fixed (IDWriteFontFace** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteRenderingParams* renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMonitorRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, nint monitor, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateMonitorRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, nint monitor, ref IDWriteRenderingParams* renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomRenderingParams(this ComPtr<IDWriteFactory2> thisVtbl, float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref IDWriteRenderingParams* renderingParams)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParamsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RegisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontFileLoader fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnregisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontFileLoader* fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontFileLoader fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoaderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
        SilkMarshal.Free((nint)localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
        SilkMarshal.Free((nint)localeNamePtr);
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
        SilkMarshal.Free((nint)localeNamePtr);
        }
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypography(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteTypography** typography)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTypography(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteTypography* typography)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTypography** typographyPtr = &typography)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typographyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiInterop(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteGdiInterop** gdiInterop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiInterop(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteGdiInterop* gdiInterop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteGdiInterop** gdiInteropPtr = &gdiInterop)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInteropPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* @stringPtr = &@string)
        {
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
        }
        SilkMarshal.Free((nint)@stringPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteTextFormat* textFormat, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSignPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteTextFormat textFormat, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSign);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteTextFormat textFormat, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
        {
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSignPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextAnalyzer(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteTextAnalyzer** textAnalyzer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextAnalyzer(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteTextAnalyzer* textAnalyzer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalyzer** textAnalyzerPtr = &textAnalyzer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitutionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
        }
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEudcFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollection, checkForUpdates);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEudcFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollection* fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollectionPtr, checkForUpdates);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontFallback(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontFallback** fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallback);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSystemFontFallback(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontFallback* fontFallback)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFallback** fontFallbackPtr = &fontFallback)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallbackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallbackBuilder(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontFallbackBuilder** fontFallbackBuilder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilder);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFallbackBuilder(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontFallbackBuilder* fontFallbackBuilder)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFallbackBuilder** fontFallbackBuilderPtr = &fontFallbackBuilder)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilderPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
        {
            fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
        {
            fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
        {
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
        {
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphRun* glyphRunPtr = &glyphRun)
        {
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory2*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFactory2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetSystemFontCollection<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> fontCollection, Silk.NET.Core.Bool32 checkForUpdates) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSystemFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf(), checkForUpdates);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, ref fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(collectionLoader, in collectionKey.GetPinnableReference(), collectionKeySize, fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCustomFontCollection<T0, TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(collectionLoader, in collectionKey.GetPinnableReference(), collectionKeySize, ref fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0, TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, ref fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader.GetPinnableReference(), collectionKey, collectionKeySize, fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader.GetPinnableReference(), collectionKey, collectionKeySize, ref fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader.GetPinnableReference(), in collectionKey.GetPinnableReference(), collectionKeySize, fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCustomFontCollection<T0, TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontCollection<T0>(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontCollection(ref collectionLoader.GetPinnableReference(), in collectionKey.GetPinnableReference(), collectionKeySize, ref fontCollection);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontCollectionLoader<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterFontCollectionLoader(ref fontCollectionLoader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontCollectionLoader<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UnregisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontCollectionLoader(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontCollectionLoader> fontCollectionLoader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnregisterFontCollectionLoader(ref fontCollectionLoader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(in filePath.GetPinnableReference(), lastWriteTime, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(in filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(in filePath.GetPinnableReference(), lastWriteTime, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(in filePath.GetPinnableReference(), in lastWriteTime.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(in filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(in filePath.GetPinnableReference(), in lastWriteTime.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFileReference(filePath, in lastWriteTime.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Span<IDWriteFontFileLoader> fontFileLoader, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Span<IDWriteFontFileLoader> fontFileLoader, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, fontFileLoader, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCustomFontFileReference<T0, TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, fontFileLoader, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0, TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, Span<IDWriteFontFileLoader> fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref fontFileLoader.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateCustomFontFileReference<T0, TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateCustomFontFileReference<T0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, Span<IDWriteFontFileLoader> fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateCustomFontFileReference(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref fontFileLoader.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFace<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI1> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, ref fontFace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(fontFaceType, numberOfFiles, in fontFiles, faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateRenderingParams<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateRenderingParams((IDWriteRenderingParams**) renderingParams.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateMonitorRenderingParams<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, nint monitor, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateMonitorRenderingParams(monitor, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateCustomRenderingParams<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateCustomRenderingParams(gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontFileLoader<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RegisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RegisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontFileLoader> fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RegisterFontFileLoader(ref fontFileLoader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontFileLoader<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UnregisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int UnregisterFontFileLoader(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteFontFileLoader> fontFileLoader)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnregisterFontFileLoader(ref fontFileLoader.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(in fontFamilyName.GetPinnableReference(), ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, in localeName.GetPinnableReference(), ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextFormat<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextFormat(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, Span<IDWriteFontCollection> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextFormat(fontFamilyName, ref fontCollection.GetPinnableReference(), fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTypography<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> typography) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTypography((IDWriteTypography**) typography.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiInterop<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> gdiInterop) where TI0 : unmanaged, IComVtbl<IDWriteGdiInterop>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetGdiInterop((IDWriteGdiInterop**) gdiInterop.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, maxWidth, maxHeight, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(in @string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), maxWidth, maxHeight, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(in @string.GetPinnableReference(), stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiCompatibleTextLayout<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGdiCompatibleTextLayout<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGdiCompatibleTextLayout(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, Span<IDWriteTextFormat> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat.GetPinnableReference(), layoutWidth, layoutHeight, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, ref textLayout);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEllipsisTrimmingSign<TI0, TI1>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> textFormat, ref ComPtr<TI1> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ComPtr<TI0> textFormat, ref IDWriteInlineObject* trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, ref trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteTextFormat> textFormat, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipsisTrimmingSign(ref textFormat.GetPinnableReference(), trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEllipsisTrimmingSign<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref IDWriteTextFormat textFormat, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEllipsisTrimmingSign(ref textFormat, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEllipsisTrimmingSign(this ComPtr<IDWriteFactory2> thisVtbl, Span<IDWriteTextFormat> textFormat, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEllipsisTrimmingSign(ref textFormat.GetPinnableReference(), ref trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static int CreateTextAnalyzer<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> textAnalyzer) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalyzer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateTextAnalyzer((IDWriteTextAnalyzer**) textAnalyzer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNumberSubstitution(substitutionMethod, in localeName.GetPinnableReference(), ignoreUserOverride, numberSubstitution);
    }

    /// <summary>To be documented.</summary>
    public static int CreateNumberSubstitution<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNumberSubstitution(substitutionMethod, in localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateNumberSubstitution(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateNumberSubstitution(substitutionMethod, in localeName.GetPinnableReference(), ignoreUserOverride, ref numberSubstitution);
    }

    /// <summary>To be documented.</summary>
    public static int CreateNumberSubstitution<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, in transform.GetPinnableReference(), renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, in transform.GetPinnableReference(), renderingMode, measuringMode, baselineOriginX, baselineOriginY, ref glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun.GetPinnableReference(), pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun.GetPinnableReference(), pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, ref glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun.GetPinnableReference(), pixelsPerDip, in transform.GetPinnableReference(), renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static int CreateGlyphRunAnalysis<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateGlyphRunAnalysis(this ComPtr<IDWriteFactory2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateGlyphRunAnalysis(in glyphRun.GetPinnableReference(), pixelsPerDip, in transform.GetPinnableReference(), renderingMode, measuringMode, baselineOriginX, baselineOriginY, ref glyphRunAnalysis);
    }

    /// <summary>To be documented.</summary>
    public static int GetEudcFontCollection<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> fontCollection, Silk.NET.Core.Bool32 checkForUpdates) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEudcFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf(), checkForUpdates);
    }

    /// <summary>To be documented.</summary>
    public static int GetSystemFontFallback<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSystemFontFallback((IDWriteFontFallback**) fontFallback.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFallbackBuilder<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, ref ComPtr<TI0> fontFallbackBuilder) where TI0 : unmanaged, IComVtbl<IDWriteFontFallbackBuilder>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFallbackBuilder((IDWriteFontFallbackBuilder**) fontFallbackBuilder.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription.GetPinnableReference(), measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription.GetPinnableReference(), measuringMode, worldToDeviceTransform, colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription.GetPinnableReference(), measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription.GetPinnableReference(), measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), glyphRunDescription, measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), glyphRunDescription, measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, in glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), measuringMode, worldToDeviceTransform, colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static int TranslateColorGlyphRun<TI0>(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, in glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TranslateColorGlyphRun(this ComPtr<IDWriteFactory2> thisVtbl, float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRun> glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphRunDescription> glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun.GetPinnableReference(), in glyphRunDescription.GetPinnableReference(), measuringMode, in worldToDeviceTransform.GetPinnableReference(), colorPaletteIndex, ref colorLayers);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFactory2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
